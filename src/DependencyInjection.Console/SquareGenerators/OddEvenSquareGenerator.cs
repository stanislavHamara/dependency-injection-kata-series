using DependencyInjection.Console.Entities;

namespace DependencyInjection.Console.SquareGenerators
{
    internal class OddEvenSquareGenerator : ISquareGenerator
    {
        public Square GenerateSquare(int width, int height, int i, int j)
        {
            return ((i ^ j) & 1) == 0 ? Square.White : Square.Black;
        }
    }
}