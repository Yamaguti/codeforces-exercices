using System;

namespace _1A_TheatreSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tokens = Console.ReadLine().Split();

            double height = double.Parse(tokens[0]);
            double width = double.Parse(tokens[1]);
            double tileSize = double.Parse(tokens[2]);


            long amountTiles = (long) (Math.Ceiling(width/tileSize) * Math.Ceiling(height/tileSize));
            Console.WriteLine(amountTiles);
        }
    }
}