namespace DependencyInjection.Console.Entities
{
    internal class Pattern
    {
        public Pattern(int width, int height)
        {
            Squares = new Square[width, height];
        }

        public Square[,] Squares { get; }
    }
}