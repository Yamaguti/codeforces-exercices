using System;

namespace _993A___TwoSquares
{
    class Point {
        public double x, y;

        public Point(double x, double y) {
            this.x = x;
            this.y = y;
        }

        private Double signOnHalfPlane(Point p0, Point p1) {
            return (this.x - p1.x) * (p0.y - p1.y) - (p0.x - p1.x) * (this.y - p1.y);
        }

        public Boolean PointInsideTriange(Point p0, Point p1, Point p2) {
            Boolean b1, b2, b3;

            b1 = this.signOnHalfPlane(p0, p1) < 0;
            b2 = this.signOnHalfPlane(p1, p2) < 0;
            b3 = this.signOnHalfPlane(p2, p0) < 0;

            return ((b1 == b2) && (b2 == b3));
    }

    class Square {
        public Point p0;
        public Point p1;
        public Point p2;
        public Point p3;
        
        // Constructor
        public Square(double x0, double y0, double x1, double y1, double x2, double y2, double x3, double y3) {
            p0 = new Point(x0, y0);
            p1 = new Point(x1, y1);
            p2 = new Point(x2, y2);
            p3 = new Point(x3, y3);
        }

        public static Square newSquareFromInput()
        {
            string[] tokens = Console.ReadLine().Split();
            return new Square(
                double.Parse(tokens[0]),
                double.Parse(tokens[1]),
                double.Parse(tokens[2]),
                double.Parse(tokens[3]),
                double.Parse(tokens[4]),
                double.Parse(tokens[5]),
                double.Parse(tokens[6]),
                double.Parse(tokens[7])
            );
        }

        public Boolean DoesItIntersects(Square other) {
            
            
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
