namespace DependencyInjection.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var useColors = args.Length > 0 && args[0] == "colors";

            var patternSimulation = new PatternApp(useColors);
            patternSimulation.Run();
        }
    }
}
