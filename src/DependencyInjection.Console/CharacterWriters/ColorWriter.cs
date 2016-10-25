using System;
using DependencyInjection.Console.Entities;

namespace DependencyInjection.Console.CharacterWriters
{
    internal class ColorWriter : ICharacterWriter
    {
        private readonly ICharacterWriter _innerWriter;

        public ColorWriter(ICharacterWriter innerWriter)
        {
            _innerWriter = innerWriter;
        }

        public void Write(Square square)
        {
            var color = GetColor(square);
            System.Console.BackgroundColor = color;
            System.Console.ForegroundColor = color;

            _innerWriter.Write(square);

            System.Console.ResetColor();
        }

        private static ConsoleColor GetColor(Square square)
        {
            switch (square)
            {
                case Square.White:
                    return ConsoleColor.White;
                case Square.Black:
                    return ConsoleColor.Black;
                default:
                    throw new ArgumentException("Color not found for square type " + square);
            }
        }

        public void WriteLine()
        {
            _innerWriter.WriteLine();
        }
    }
}
