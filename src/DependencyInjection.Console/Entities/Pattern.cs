namespace DependencyInjection.Console.Entities
{
    internal class Pattern
    {
        public Pattern(int width, int height)
        {
            Squares = new Square[height, width];
        }

        public Square[,] Squares { get; }
    }
}