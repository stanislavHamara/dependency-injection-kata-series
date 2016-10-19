using DependencyInjection.Console.Entities;

namespace DependencyInjection.Console.PatternWriters
{
    internal interface IPatternWriter
    {
        void Write(Pattern pattern);
    }
}