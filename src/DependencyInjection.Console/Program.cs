using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection.Console
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        class MazeSimulation
        {
            private IMazeWriter _mazeWriter;
            private IMazeGenerator _mazeGenerator;

            public MazeSimulation()
            {
                _mazeWriter = new ConsoleMazeWriter();
                _mazeGenerator = new MazeGenerator();
            }
        }

        private interface IMazeWriter
        {
            void Write(Maze maze);
        }

        class ConsoleMazeWriter : IMazeWriter
        {
            public void Write(Maze maze)
            {
            }
        }

        private interface IMazeGenerator
        {
        }

        class MazeGenerator : IMazeGenerator
        {
            public Maze Generate()
            {
                return new Maze();
            }
        }

        class Maze
        {
        }
    }
}
