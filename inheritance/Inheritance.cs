using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    namespace Task1_2
    {
        public abstract class Figure
        {
            public double X { get; }
            public double Y { get; }

            public Figure() { }

            public Figure(double x, double y)
            {
                X = x;
                Y = y;
            }

            public abstract void Draw();
        }

        public class Square : Figure
        {
            public Square() { }
            public Square(double x, double y) : base(x, y) { }

            public override void Draw()
            {
                Console.WriteLine("Drawing the Square");
            }
        }

        public class Rectangle : Figure
        {
            public Rectangle() { }
            public Rectangle(double x, double y) : base(x, y) { }

            public override void Draw()
            {
                Console.WriteLine("Drawing the Rectangle");
            }
        }
    }    

    namespace Task3
    {
        public class Figure
        {
            public double X { get; }
            public double Y { get; }

            public Figure() { }

            public Figure(double x, double y)
            {
                X = x;
                Y = y;
            }

            public virtual void Draw()
            {
                Console.WriteLine("Drawing the Figure");
            }
        }

        public class Square : Figure
        {
            public Square() { }
            public Square(double x, double y) : base(x, y) { }

            public override void Draw()
            {
                Console.WriteLine("Drawing the Square");
            }
        }

        public class Rectangle : Figure
        {
            public Rectangle() { }
            public Rectangle(double x, double y) : base(x, y) { }

            public override void Draw()
            {
                Console.WriteLine("Drawing the Rectangle");
            }
        }
    }

    public class Task4
    {
        public interface IDrawable
        {
            void Draw();
        }

        public class Figure : IDrawable
        {
            public double X { get; }
            public double Y { get; }

            public Figure() { }

            public Figure(double x, double y)
            {
                X = x;
                Y = y;
            }

            public virtual void Draw()
            {
                Console.WriteLine("Drawing the Figure");
            }
        }

        public class Square : Figure
        {
            public Square() { }
            public Square(double x, double y) : base(x, y) { }

            public override void Draw()
            {
                Console.WriteLine("Drawing the Square");
            }
        }

        public class Rectangle : Figure
        {
            public Rectangle() { }
            public Rectangle(double x, double y) : base(x, y) { }

            public override void Draw()
            {
                Console.WriteLine("Drawing the Rectangle");
            }
        }

        static public void DrawAll(params IDrawable[] array)
        {
            foreach (var a in array)
            {
                if (a is Figure)
                    (a as Figure).Draw();
                else if (a is Square)
                    (a as Square).Draw();
                else if (a is Rectangle)
                    (a as Rectangle).Draw();
            }
        }
    }
}
