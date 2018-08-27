using System;

namespace _993A___TwoSquares
{
    class Square {
        // Constructor
        public Square(int x0, int y0, int x1, int y1, int x2, int y2, int x3, int y3) {

        }

        public void print() {
            Console.WriteLine("aa");
        }

        public Boolean DoesItIntersects(Square other) {
            return false;
        }

        public static Square newSquareFromInput()
        {
            string[] tokens = Console.ReadLine().Split();
            return new Square(
                int.Parse(tokens[0]),
                int.Parse(tokens[1]),
                int.Parse(tokens[2]),
                int.Parse(tokens[3]),
                int.Parse(tokens[4]),
                int.Parse(tokens[5]),
                int.Parse(tokens[6]),
                int.Parse(tokens[7])
            );
        }
    };

    class Program
    {
        static void Main(string[] args)
        {
            Square a = Square.newSquareFromInput();
            Square b = Square.newSquareFromInput();

            if (a.DoesItIntersects(b)) {
                Console.WriteLine("Yes");
            } else {
                Console.WriteLine("No");
            }            
        }
    }
}
