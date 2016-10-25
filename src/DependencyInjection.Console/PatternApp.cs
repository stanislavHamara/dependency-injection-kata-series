using DependencyInjection.Console.PatternGenerators;

namespace DependencyInjection.Console
{
    internal class PatternApp
    {
        private readonly PatternWriter _patternWriter;
        private readonly IPatternGenerator _patternGenerator;

        public PatternApp(bool useColours)
        {
            _patternWriter = new PatternWriter(useColours);
            _patternGenerator = new SquarePaintingPatternGenerator();
        }

        public void Run()
        {
            var pattern = _patternGenerator.Generate(10, 10);
            _patternWriter.Write(pattern);
        }
    }
}