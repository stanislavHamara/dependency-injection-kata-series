using System;
using System.IO;

namespace DependencyInjection.Console
{
    internal class TextPatternWriter : IPatternWriter
    {
        private readonly TextWriter _textWriter;

        public TextPatternWriter()
        {
            _textWriter = System.Console.Out;
        }

        public void Write(Pattern pattern)
        {
            var squares = pattern.Squares;

            for (int horizIndex = 0; horizIndex < squares.GetLength(0); ++horizIndex)
            {
                for (int vertIndex = 0; vertIndex < squares.GetLength(1); ++vertIndex)
                {
                    var squareCharacter = GetCharacter(squares[horizIndex, vertIndex]);
                    _textWriter.Write(squareCharacter);
                }
                _textWriter.WriteLine();
            }
        }

        private static char GetCharacter(Square square)
        {
            switch (square)
            {
                case Square.White:
                    return '.';
                case Square.Black:
                    return '#';
                default:
                    throw new ArgumentException("Char not found for square type " + square);
            }
        }
    }
}