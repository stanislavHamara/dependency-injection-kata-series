using DependencyInjection.Console.Entities;
using DependencyInjection.Console.SquarePainters;

namespace DependencyInjection.Console.PatternGenerators
{
    internal class SquareIndependentPatternGenerator : IPatternGenerator
    {
        private readonly ISquarePainter _squarePainter;

        public SquareIndependentPatternGenerator()
        {
            _squarePainter = new CircleSquarePainter();
        }

        public Pattern Generate(int width, int height)
        {
            var generate = new Pattern(width, height);
            var squares = generate.Squares;

            for (var i = 0; i < width; ++i)
            {
                for (var j = 0; j < height; ++j)
                {
                    squares[i, j] = _squarePainter.PaintSquare(width, height, i, j);
                }
            }

            return generate;
        }
    }
}