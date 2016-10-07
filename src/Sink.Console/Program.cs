using System;
using System.IO;
using System.Linq;
using System.Reflection;

namespace Sink.Console
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Main(args, System.Console.Out);

            System.Console.WriteLine("Press 'q' to quit");
            while (System.Console.ReadKey(true).Key != ConsoleKey.Q)
            {
            }
        }

        public static void Main(string[] args, TextWriter output)
        {
            var synchronizer = new Synchronizer(output);
            synchronizer.Start(args.Any() ? args[0] : GetExecutionPath());
        }

        private static string GetExecutionPath()
        {
            return Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
        }
    }
}