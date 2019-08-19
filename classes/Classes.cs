using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes
{
    namespace Task1_3
    {
        public class Point
        {
            public double X { get; set; }
            public double Y { get; set; }

            public Point() { }
            public Point(double x, double y)
            {
                X = x;
                Y = y;
            }
        }

        public class Rectangle
        {
            private Point a;
            private Point c;

            private Point b;

            private double ab;
            private double bc;


            public Rectangle() { }
            public Rectangle(Point a, Point c)
            {
                this.a = a;
                this.c = c;
                b = new Point(a.X, c.Y);

                ab = GetSquareRoot((b.X - a.X) * (b.X - a.X) + (b.Y - a.Y) * (b.Y - a.Y));
                bc = GetSquareRoot((c.X - b.X) * (c.X - b.X) + (c.Y - b.Y) * (c.Y - b.Y));
            }

            private double GetSquareRoot(double number)
            {
                if (number > 0)
                {
                    double root = number / 3;
                    int i;
                    for (i = 0; i < 32; i++)
                        root = (root + number / root) / 2;
                    return root;
                }
                else if (number == 0)
                    return 0;
                else
                {
                    throw new Exception("The argument is less than 0!");
                }
            }

            public double GetPerimeter()
            {
                return (ab + bc) * 2;
            }

            public double GetArea()
            {
                return ab * bc;
            }
        }

        public class Circle
        {
            private const double Pi = 3.14;

            public double GetLength(double radius)
            {
                return 2 * Pi * radius;
            }

            public double GetArea(double radius)
            {
                return Pi * radius * radius;
            }
        }
    }
    
    namespace Task4
    {
        public class Point
        {
            public double X { get; set; }
            public double Y { get; set; }

            public Point() { }
            public Point(double x, double y)
            {
                X = x;
                Y = y;
            }
        }

        public static class Rectangle
        {
            private static double ab;
            private static double bc;
         
            private static double GetSquareRoot(double number)
            {
                if (number > 0)
                {
                    double root = number / 3;
                    int i;
                    for (i = 0; i < 32; i++)
                        root = (root + number / root) / 2;
                    return root;
                }
                else if (number == 0)
                    return 0;
                else
                {
                    throw new Exception("The argument is less than 0!");
                }
            }

            private static void GetRectangle(Point a, Point c)
            {
                Point b = new Point(a.X, c.Y);

                ab = GetSquareRoot((b.X - a.X) * (b.X - a.X) + (b.Y - a.Y) * (b.Y - a.Y));
                bc = GetSquareRoot((c.X - b.X) * (c.X - b.X) + (c.Y - b.Y) * (c.Y - b.Y));                
            }

            public static double GetPerimeter(Point a, Point c)
            {
                GetRectangle(a, c);

                return (ab + bc) * 2;
            }

            public static double GetArea(Point a, Point c)
            {
                GetRectangle(a, c);

                return ab * bc;
            }
        }

        public static class Circle
        {
            private const double Pi = 3.14;

            public static double GetLength(double radius)
            {
                return 2 * Pi * radius;
            }

            public static double GetArea(double radius)
            {
                return Pi * radius * radius;
            }
        }
    }

    namespace Task5
    {
        public class Complex
        {
            #region Properties

            public double Real { get; set; }
            public double Imaginary { get; set; }

            #endregion

            #region Constructors

            public Complex() { }

            public Complex(double real, double imaginary)
            {
                Real = real;
                Imaginary = imaginary;
            }

            #endregion

            #region Operators

            public static Complex operator +(Complex one, Complex two)
            {
                return new Complex { Real = one.Real + two.Real, Imaginary = one.Imaginary + two.Imaginary };
            }

            public static Complex operator -(Complex one, Complex two)
            {
                return new Complex { Real = one.Real - two.Real, Imaginary = one.Imaginary - two.Imaginary };
            }

            public static Complex operator *(Complex one, Complex two)
            {
                return new Complex { Real = one.Real * two.Real - one.Imaginary * two.Imaginary, Imaginary = one.Real * two.Imaginary + one.Imaginary * two.Real };
            }

            public static Complex operator /(Complex one, Complex two)
            {
                return new Complex
                {
                    Real = (one.Real * two.Real + one.Imaginary * two.Imaginary) / (two.Real * two.Real + two.Imaginary * two.Imaginary),
                    Imaginary = (two.Real * one.Imaginary - one.Real * two.Imaginary) / (two.Real * two.Real + two.Imaginary * two.Imaginary)
                };
            }

            #endregion

            public override string ToString()
            {
                return (String.Format("{0} + {1}i", Real, Imaginary));
            }
        }
    }    
}
