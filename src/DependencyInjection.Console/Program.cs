using System;
using System.IO;

namespace DependencyInjection.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            bool useColors = args.Length > 0 && args[0] == "colors";

            var patternSimulation = new PatternApp(useColors);
            patternSimulation.Run();
        }

        class PatternApp
        {
            private readonly IPatternWriter _patternWriter;
            private readonly IPatternGenerator _patternGenerator;

            public PatternApp(bool useColours)
            {
                _patternWriter = useColours ? (IPatternWriter)new ColorTextPatternWriter() : new TextPatternWriter();
                _patternGenerator = new OddEvenPatternGenerator();
            }

            public void Run()
            {
                var pattern = _patternGenerator.Generate(10, 10);
                _patternWriter.Write(pattern);
            }
        }

        private interface IPatternWriter
        {
            void Write(Pattern pattern);
        }

        class TextPatternWriter : IPatternWriter
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

        private interface IPatternGenerator
        {
            Pattern Generate(int width, int height);
        }

        class EmptyPatternGenerator : IPatternGenerator
        {
            public Pattern Generate(int width, int height)
            {
                return new Pattern(width, height);
            }
        }

        class OddEvenPatternGenerator : IPatternGenerator
        {
            public Pattern Generate(int width, int height)
            {
                var generate = new Pattern(width, height);
                var squares = generate.Squares;

                for (int horizIndex = 0; horizIndex < squares.GetLength(0); ++horizIndex)
                {
                    for (int vertIndex = 0; vertIndex < squares.GetLength(1); ++vertIndex)
                    {
                        squares[horizIndex, vertIndex] = (horizIndex ^ vertIndex) % 2 == 0 ? Square.White : Square.Black;
                    }
                }

                return generate;
            }
        }

        class Pattern
        {
            public Pattern(int width, int height)
            {
                Squares = new Square[width, height];
            }

            public Square[,] Squares { get; }
        }

        enum Square
        {
            White,
            Black,
        }

        class ColorTextPatternWriter : IPatternWriter
        {
            public void Write(Pattern pattern)
            {
            }
        }
    }
}
