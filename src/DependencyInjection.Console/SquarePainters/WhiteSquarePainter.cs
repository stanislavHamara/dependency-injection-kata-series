using DependencyInjection.Console.Entities;

namespace DependencyInjection.Console.SquarePainters
{
    internal class  WhiteSquarePainter : ISquarePainter
    {
        public Square PaintSquare(int width, int height, int i, int j)
        {
            return Square.White;
        }
    }
}