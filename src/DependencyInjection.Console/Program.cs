using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var mazeSimulation = new MazeSimulation();
            mazeSimulation.Run();
        }

        class MazeSimulation
        {
            private IMazeWriter _mazeWriter;
            private IMazeGenerator _mazeGenerator;

            public MazeSimulation()
            {
                _mazeWriter = new TextMazeWriter();
                _mazeGenerator = new EmptyMazeGenerator();
            }

            public void Run()
            {
            }
        }

        private interface IMazeWriter
        {
            void Write(Maze maze);
        }

        class TextMazeWriter : IMazeWriter
        {
            private readonly TextWriter _textWriter;

            public TextMazeWriter()
            {
                _textWriter = System.Console.Out;
            }

            public void Write(Maze maze)
            {

            }
        }

        private interface IMazeGenerator
        {
        }

        class EmptyMazeGenerator : IMazeGenerator
        {
            public Maze Generate(int width, int height)
            {
                return new Maze(width, height);
            }
        }

        class Maze
        {
            public Maze(int width, int height)
            {
                Squares = new Square[width, height];
            }

            public Square[,] Squares { get; }
        }

        enum Square
        {
            Open,
            Wall,
        }
    }
}
