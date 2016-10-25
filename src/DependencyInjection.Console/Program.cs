﻿namespace DependencyInjection.Console
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var useColors = args.Length > 0 && args[0] == "colors";

            var app = new PatternApp(useColors);
            app.Run();
        }
    }
}
