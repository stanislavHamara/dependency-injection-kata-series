namespace DependencyInjection.Console
{
    internal abstract class SquareIndependentPatternGenerator : IPatternGenerator
    {
        public Pattern Generate(int width, int height)
        {
            var generate = new Pattern(width, height);
            var squares = generate.Squares;

            for (var i = 0; i < width; ++i)
            {
                for (var j = 0; j < height; ++j)
                {
                    squares[i, j] = GenerateSquare(width, height, i, j);
                }
            }

            return generate;
        }

        protected abstract Square GenerateSquare(int width, int height, int i, int j);
    }
}