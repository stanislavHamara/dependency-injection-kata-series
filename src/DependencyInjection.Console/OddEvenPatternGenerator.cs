namespace DependencyInjection.Console
{
    internal class OddEvenPatternGenerator : IPatternGenerator
    {
        public Pattern Generate(int width, int height)
        {
            var generate = new Pattern(width, height);
            var squares = generate.Squares;

            for (var i = 0; i < squares.GetLength(0); ++i)
            {
                for (var j = 0; j < squares.GetLength(1); ++j)
                {
                    squares[i, j] = ((i ^ j) & 1) == 0 ? Square.White : Square.Black;
                }
            }

            return generate;
        }
    }
}