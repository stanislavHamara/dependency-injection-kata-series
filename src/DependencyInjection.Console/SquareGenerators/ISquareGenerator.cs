using DependencyInjection.Console.Entities;

namespace DependencyInjection.Console.SquareGenerators
{
    interface ISquareGenerator
    {
        Square GenerateSquare(int width, int height, int i, int j);
    }
}