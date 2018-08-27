using System;

namespace _993A___TwoSquares
{
    class Square {
        // Constructor
        public Square() {

        }

        public void print() {
            Console.WriteLine("aa");
        }

        public static Square newSquareFromInput()
        {
            string[] tokens = Console.ReadLine().Split();
            return new Square();
        }
    };

    class Program
    {
        static void Main(string[] args)
        {
            Square a = Square.newSquareFromInput();
            Square b = Square.newSquareFromInput();

            a.print();
            b.print();

            Console.WriteLine("No");
        }
    }
}
