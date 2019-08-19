using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using classes;
using inheritance;


namespace homework
{
    class Program
    {
        static List<double> GetCoordinates(string s)
        {
            double number;
            string[] coordinatesStringArray = s.Split(',');

            List<double> coordinates = new List<double>();

            foreach (var c in coordinatesStringArray)
            {
                bool success = Double.TryParse(c, out number);
                if (success)
                {
                    coordinates.Add(number);
                }
                else
                {                    
                    throw new FormatException();
                }
            }       
            
            return coordinates;
        }

        static double GetRadius()
        {
            double radius;

            bool success = Double.TryParse(Console.ReadLine(), out radius);

            if (success)
            {
                return radius;
            }
            else
            {
                throw new FormatException();
            }
        }

        static void Main(string[] args)
        {
            #region ClassesHomework            

            Console.WriteLine("Classes homework \n");

            #region Task 1 and 2

            Console.WriteLine("Task 1 and 2 \n Enter rectangle coordinates (x1,y1,x2,y2):");            

            string coordinatesString = Console.ReadLine();

            List<double> coordinates = GetCoordinates(coordinatesString);

            classes.Task1_3.Rectangle rectangle = new classes.Task1_3.Rectangle(new classes.Task1_3.Point(coordinates[0], coordinates[1]), new classes.Task1_3.Point(coordinates[2], coordinates[3]));
            Console.WriteLine("The area of rectangle = " + rectangle.GetArea());
            Console.WriteLine("The perimeter of rectangle = " + rectangle.GetPerimeter());

            #endregion

            #region Task 3

            Console.WriteLine("\n Task 3 \n Enter circle radious:");

            double radius = GetRadius();

            classes.Task1_3.Circle circle = new classes.Task1_3.Circle();
            Console.WriteLine("The area of circle = " + circle.GetArea(radius));
            Console.WriteLine("The length of circle = " + circle.GetLength(radius));

            #endregion

            #region Task 4

            Console.WriteLine("\n Task 4 \n Enter rectangle coordinates (x1,y1,x2,y2):");

            //coordinatesString = Console.ReadLine();

            //coordinates = GetCoordinates(coordinatesString);
                        
            Console.WriteLine("The area of staticRectangle = " + classes.Task4.Rectangle.GetArea(new classes.Task4.Point(coordinates[0], coordinates[1]), new classes.Task4.Point(coordinates[2], coordinates[3])));
            Console.WriteLine("The perimeter of staticRectangle = " + classes.Task4.Rectangle.GetPerimeter(new classes.Task4.Point(coordinates[0], coordinates[1]), new classes.Task4.Point(coordinates[2], coordinates[3])));

            Console.WriteLine("\n Task 4 \n Enter circle radious:");

            //radius = GetRadius();

            Console.WriteLine("The area of circle = " + classes.Task4.Circle.GetArea(radius));
            Console.WriteLine("The length of circle = " + classes.Task4.Circle.GetLength(radius));

            #endregion

            #region Task 5

            Console.WriteLine("\n Task 5 \n Enter complex real and imaginary parts (x1,y1,x2,y2):");

            string partsString = Console.ReadLine();

            coordinates = GetCoordinates(partsString);

            classes.Task5.Complex complex1 = new classes.Task5.Complex(coordinates[0], coordinates[1]);
            classes.Task5.Complex complex2 = new classes.Task5.Complex(coordinates[2], coordinates[3]);

            Console.WriteLine("Complex addition = " + (complex1 + complex2));
            Console.WriteLine("Complex subtraction = " + (complex1 - complex2));
            Console.WriteLine("Complex multiplication = " + (complex1 * complex2));
            Console.WriteLine("Complex division = " + (complex1 / complex2));

            #endregion

            #endregion

            #region InheritanceHomework

            #region Task 1 and 2

            Console.WriteLine("\n Inheritance Homework \n \n Task 1 and 2");

            inheritance.Task1_2.Square inharitanceSquare = new inheritance.Task1_2.Square(1, 2);
            inheritance.Task1_2.Rectangle inharitanceRectangle = new inheritance.Task1_2.Rectangle(2, 3);

            inharitanceSquare.Draw();
            inharitanceRectangle.Draw();

            #endregion

            #region Task 3

            Console.WriteLine("\n Task 3");

            inheritance.Task3.Figure figure3 = new inheritance.Task3.Figure();
            inheritance.Task3.Square square3 = new inheritance.Task3.Square();
            inheritance.Task3.Rectangle rectangle3 = new inheritance.Task3.Rectangle();

            figure3.Draw();
            (square3 as inheritance.Task3.Figure).Draw();
            rectangle3.Draw();

            #endregion                                

            #region Task 4

            Console.WriteLine("\n Task 4");

            Task4.Figure figure4 = new Task4.Figure();
            Task4.Square square4 = new Task4.Square();
            Task4.Rectangle rectangle4 = new Task4.Rectangle();

            Task4.DrawAll(figure4, square4, rectangle4);

            #endregion

            #endregion

            Console.ReadLine();
        }
    }
}
