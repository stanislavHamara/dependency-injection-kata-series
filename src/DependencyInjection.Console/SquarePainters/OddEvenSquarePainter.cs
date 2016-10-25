using DependencyInjection.Console.Entities;

namespace DependencyInjection.Console.SquarePainters
{
    internal class OddEvenSquarePainter : ISquarePainter
    {
        public Square PaintSquare(int width, int height, int i, int j)
        {
            return ((i ^ j) & 1) == 0 ? Square.White : Square.Black;
        }
    }
}