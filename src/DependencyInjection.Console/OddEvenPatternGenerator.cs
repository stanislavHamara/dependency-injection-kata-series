namespace DependencyInjection.Console
{
    internal class OddEvenPatternGenerator : SquareIndependentPatternGenerator
    {
        protected override Square GenerateSquare(int width, int height, int i, int j)
        {
            return ((i ^ j) & 1) == 0 ? Square.White : Square.Black;
        }
    }
}