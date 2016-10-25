using System;
using DependencyInjection.Console.Entities;

namespace DependencyInjection.Console.SquarePainters
{
    internal class CircleSquarePainter : ISquarePainter
    {
        public Square PaintSquare(int width, int height, int i, int j)
        {
            return Math.Pow(Math.Pow(i/ (double)(width-1) - 0.5,2) + Math.Pow(j/(double)(height-1) - 0.5, 2), 0.5) < 0.5 ? Square.White : Square.Black;
        }
    }
}