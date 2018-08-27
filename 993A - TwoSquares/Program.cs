using System;

namespace _993A___TwoSquares
{
    class Line {
        public int x0;
        public int y0;
        public int x1;
        public int y1;
        
        public Line(int x0, int y0, int x1, int y1) {
            this.x0 = x0;
            this.y0 = y0;

            this.x1 = x1;
            this.y1 = y1;
        }
    }

    class Square {
        public Line l0;
        public Line l1;
        public Line l2;
        public Line l3;
        public Line da;
        public Line db;

        // Constructor
        public Square(int x0, int y0, int x1, int y1, int x2, int y2, int x3, int y3) {
            l0 = new Line(x0, y0, x1, y1);
            l1 = new Line(x1, y1, x2, y2);
            da = new Line(x1, y0, x0, y0);

            
            l2 = new Line(x2, y2, x3, y3);
            l3 = new Line(x3, y3, x0, y0);
            db = new Line(x0, y0, x2, y2);
        }

        public void print() {
            Console.WriteLine("aa");
        }

        public Boolean DoesItIntersects(Square other) {
            
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
