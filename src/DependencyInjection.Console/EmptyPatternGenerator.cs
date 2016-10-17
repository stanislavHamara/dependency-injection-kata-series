namespace DependencyInjection.Console
{
    class EmptyPatternGenerator : IPatternGenerator
    {
        public Pattern Generate(int width, int height)
        {
            return new Pattern(width, height);
        }
    }
}