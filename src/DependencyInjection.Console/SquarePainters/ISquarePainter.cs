using DependencyInjection.Console.Entities;

namespace DependencyInjection.Console.SquarePainters
{
    internal interface ISquarePainter
    {
        Square PaintSquare(int width, int height, int i, int j);
    }
}