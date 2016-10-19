namespace DependencyInjection.Console
{
    interface ISquareGenerator
    {
        Square GenerateSquare(int width, int height, int i, int j);
    }
}