using DependencyInjection.Console.Entities;

namespace DependencyInjection.Console.PatternGenerators
{
    internal interface IPatternGenerator
    {
        Pattern Generate(int width, int height);
    }
}