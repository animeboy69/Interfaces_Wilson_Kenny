using System;

namespace Interfaces_Wilson_Kenny
{
    class Program
    {
        static void Main(string[] args)
        {
            Game myGame = new Game("E", "FPS", "ZombCube");
            Console.WriteLine(myGame.Describe());
            myGame.PlayGame();

            Movie myMovie = new Movie("PG-13", "Sci-Fi/Adventure", "Star Wars Revenge of the Sith");
            Console.WriteLine(myMovie.Describe());
            myMovie.PlayMovie();
        }
    }
}
