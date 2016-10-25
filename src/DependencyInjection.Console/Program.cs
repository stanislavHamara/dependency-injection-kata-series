using NDesk.Options;

namespace DependencyInjection.Console
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var useColors = false;

            var optionSet = new OptionSet
            {
                {"c|colors", value => useColors = value != null}
            };
            optionSet.Parse(args);

            var app = new PatternApp(useColors);
            app.Run();
        }
    }
}
