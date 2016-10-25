using DependencyInjection.Console.Entities;

namespace DependencyInjection.Console.CharacterWriters
{
    internal interface ICharacterWriter
    {
        void Write(Square square);

        void WriteLine();
    }
}