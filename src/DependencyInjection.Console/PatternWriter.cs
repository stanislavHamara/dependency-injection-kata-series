using DependencyInjection.Console.CharacterWriters;
using DependencyInjection.Console.Entities;

namespace DependencyInjection.Console
{
    internal class PatternWriter
    {
        private readonly ICharacterWriter _characterWriter;

        public PatternWriter(bool useColours)
        {
            _characterWriter = new AsciiWriter();
        }

        public void Write(Pattern pattern)
        {
            var squares = pattern.Squares;

            for (var horizIndex = 0; horizIndex < squares.GetLength(0); ++horizIndex)
            {
                for (var vertIndex = 0; vertIndex < squares.GetLength(1); ++vertIndex)
                {
                    _characterWriter.Write(squares[horizIndex, vertIndex]);
                }
                _characterWriter.WriteLine();
            }
        }
    }
}