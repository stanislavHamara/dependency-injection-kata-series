namespace DependencyInjection.Console
{
    internal class PatternApp
    {
        private readonly PatternWriter _patternWriter;
        private readonly PatternGenerator _patternGenerator;

        public PatternApp(bool useColours)
        {
            _patternWriter = new PatternWriter(useColours);
            _patternGenerator = new PatternGenerator();
        }

        public void Run()
        {
            var pattern = _patternGenerator.Generate(25, 15);
            _patternWriter.Write(pattern);
        }
    }
}