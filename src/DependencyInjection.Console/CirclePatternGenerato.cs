using System;

namespace DependencyInjection.Console
{
    internal class CirclePatternGenerator : IPatternGenerator
    {
        public Pattern Generate(int width, int height)
        {
            var generate = new Pattern(width, height);
            var squares = generate.Squares;

            for (var i = 0; i < width; ++i)
            {
                for (var j = 0; j < height; ++j)
                {
                    squares[i, j] = Math.Pow(Math.Pow(i/ (double)(width-1) - 0.5,2) + Math.Pow(j/(double)(height-1) - 0.5, 2), 0.5) < 0.5 ? Square.White : Square.Black;
                }
            }

            return generate;
        }
    }
}