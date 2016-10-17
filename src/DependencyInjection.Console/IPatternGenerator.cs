namespace DependencyInjection.Console
{
    internal interface IPatternGenerator
    {
        Pattern Generate(int width, int height);
    }
}