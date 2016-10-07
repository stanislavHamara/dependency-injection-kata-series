using System.IO;

namespace Sink
{
    public class Synchronizer
    {
        private readonly TextWriter _output;
        private readonly Watcher _watcher;

        public Synchronizer(TextWriter output)
        {
            _output = output;

            _watcher = new Watcher();
            _watcher.FileAdded += FileAdded;
            _watcher.FileDeleted += FileDeleted;
        }

        public void Start(string path)
        {
            _watcher.StartWatching(path);
        }

        private void FileAdded(object sender, FileEventArgs e)
        {
            _output.WriteLine($"A  {e.RelativePath}");
        }

        private void FileDeleted(object sender, FileEventArgs e)
        {
            _output.WriteLine($"D  {e.RelativePath}");
        }
    }
}