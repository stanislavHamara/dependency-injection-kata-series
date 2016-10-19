using DependencyInjection.Console.PatternGenerators;
using DependencyInjection.Console.PatternWriters;

namespace DependencyInjection.Console
{
    internal class PatternApp
    {
        private readonly IPatternWriter _patternWriter;
        private readonly IPatternGenerator _patternGenerator;

        public PatternApp(bool useColours)
        {
            _patternWriter = useColours ? (IPatternWriter) new ColorTextPatternWriter() : new TextPatternWriter();
            _patternGenerator = new SquareIndependentPatternGenerator();
        }

        public void Run()
        {
            var pattern = _patternGenerator.Generate(10, 10);
            _patternWriter.Write(pattern);
        }
    }
}