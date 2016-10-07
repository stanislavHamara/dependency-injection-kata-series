using System;
using System.IO;
using System.Threading;
using NUnit.Framework;

namespace Sink.Console.Tests
{
    [TestFixture]
    public class ProgramShould
    {
        private string _targetFolder;

        [SetUp]
        public void SetUp()
        {
            _targetFolder = NewTemporaryDirectory();
        }

        [TearDown]
        public void TearDown()
        {
            DeleteDirectory(_targetFolder);
        }

        [Test]
        public void WatchFileChangesInFolder()
        {
            var output = new StringWriter();
            StartProgram(output);

            AddFile("one.txt");
            AddFile("two.txt");
            DeleteFile("one.txt");
            AddFile("three.txt");
            DeleteFile("two.txt");
            DeleteFile("three.txt");

            Assert.That(output.Lines(), Is.EqualTo(new[]
            {
                "A  one.txt",
                "A  two.txt",
                "D  one.txt",
                "A  three.txt",
                "D  two.txt",
                "D  three.txt",
            }));
        }

        private void StartProgram(TextWriter output)
        {
            Program.Main(new[] {_targetFolder}, output);
        }

        private void AddFile(string path)
        {
            var fullPath = Path.Combine(_targetFolder, path);
            File.WriteAllText(fullPath, string.Empty);
            Thread.Sleep(50);
        }

        private void DeleteFile(string path)
        {
            var fullPath = Path.Combine(_targetFolder, path);
            File.Delete(fullPath);
            Thread.Sleep(50);
        }

        private static string NewTemporaryDirectory()
        {
            var tempDirectory = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());
            Directory.CreateDirectory(tempDirectory);
            return tempDirectory;
        }

        private static void DeleteDirectory(string path)
        {
            Directory.Delete(path, true);
        }
    }

    internal static class StringWriterExtensions
    {
        public static string[] Lines(this TextWriter text)
        {
            return text.ToString().Split(new[] {Environment.NewLine}, StringSplitOptions.RemoveEmptyEntries);
        }
    }
}
