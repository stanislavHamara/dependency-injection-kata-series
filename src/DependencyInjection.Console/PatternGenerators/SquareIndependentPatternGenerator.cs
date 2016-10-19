using DependencyInjection.Console.Entities;
using DependencyInjection.Console.SquareGenerators;

namespace DependencyInjection.Console.PatternGenerators
{
    internal class SquareIndependentPatternGenerator : IPatternGenerator
    {
        private readonly ISquareGenerator _squareGenerator;

        public SquareIndependentPatternGenerator()
        {
            _squareGenerator = new CircleSquareGenerator();
        }

        public Pattern Generate(int width, int height)
        {
            var generate = new Pattern(width, height);
            var squares = generate.Squares;

            for (var i = 0; i < width; ++i)
            {
                for (var j = 0; j < height; ++j)
                {
                    squares[i, j] = _squareGenerator.GenerateSquare(width, height, i, j);
                }
            }

            return generate;
        }
    }
}