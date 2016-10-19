using DependencyInjection.Console.Entities;

namespace DependencyInjection.Console.SquareGenerators
{
    class WhiteSquareGenerator : ISquareGenerator
    {
        public Square GenerateSquare(int width, int height, int i, int j)
        {
            return Square.White;
        }
    }
}