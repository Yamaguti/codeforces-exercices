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

        public Boolean IsPointInsideTriange(Point p0, Point p1, Point p2) {
            Boolean b1, b2, b3;

            b1 = this.signOnHalfPlane(p0, p1) < 0;
            b2 = this.signOnHalfPlane(p1, p2) < 0;
            b3 = this.signOnHalfPlane(p2, p0) < 0;

            return ((b1 == b2) && (b2 == b3));
    }

    class Square {
        public Point p0, p1, p2, p3;
        
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

        // Does any of my square's vertexes intersects a triangle v0, v1, v2?
        public Boolean doesSquareHaveAPointInsideTriangle(Point v0, Point v1, Point v2) {
            if (this.p0.IsPointInsideTriange(v0, v1, v2) || this.p1.IsPointInsideTriange(v0, v1, v2) || this.p2.IsPointInsideTriange(v0, v1, v2) || this.p3.IsPointInsideTriange(v0, v1, v2))
                return true; 
            return false;
        }

        // Let us consider a square as two triangles with no intersection. This method checks for each of these triangles if the other square has a vertex inside it.
        // It then swaps one square for the other and repeat the test. This is relevant because the check for intersections happens only at vertexes.
        public Boolean DoesItIntersects(Square other) {
            // first triangle check
            if (other.doesSquareHaveAPointInsideTriangle(this.p0, this.p1, this.p2))
                return true;

            // second triangle check
            if (other.doesSquareHaveAPointInsideTriangle(this.p2, this.p3, this.p0))
                return true;

            // first triangle check, swapped
            if (this.doesSquareHaveAPointInsideTriangle(other.p0, other.p1, other.p2))
                return true;

            // second triangle check, swapped
            if (this.doesSquareHaveAPointInsideTriangle(other.p2, other.p3, other.p0))
                return true;

            return false;
        }
    }

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
