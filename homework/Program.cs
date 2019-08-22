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

        public static int GetPageNumber()
        {
            int pageNumber;

            bool success = Int32.TryParse(Console.ReadLine(), out pageNumber);

            if (success && pageNumber > 0)
            {
                return pageNumber;
            }
            else
            {
                return -1;
            }
        }

        public static List<string> GetListOfStrings()
        {
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            var strings = new List<string>();
            var random = new Random();

            for (int i = 0; i < 101; i++)
            {
                var stringChars = new char[4];


                for (int j = 0; j < stringChars.Length; j++)
                {
                    stringChars[j] = chars[random.Next(chars.Length)];
                }

                strings.Add(new String(stringChars));
            }

            return strings; 
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

            #region CollectionsHomework

            Console.WriteLine("Collections Homework");

            #region Task 1

            var people = new List<collections.Task1_2.Person>
            {
                new collections.Task1_2.Person{Name = "Tom", Age = 22, PhoneNumbers = new List<string>() { "Tom's number #1", "Tom's number #2", "Tom's number #3" } },
                new collections.Task1_2.Person{Name = "Ann", Age = 21, PhoneNumbers = new List<string>() { "Ann's number #1", "Ann's number #2", "Ann's number #3" } },
                new collections.Task1_2.Person{Name = "Rob", Age = 22, PhoneNumbers = new List<string>() { "Rob's number #1", "Rob's number #2", "Rob's number #3" } },
                new collections.Task1_2.Person{Name = "Jane", Age = 25, PhoneNumbers = new List<string>() { "Jane's number #1", "Jane's number #2", "Jane's number #3" } },
                new collections.Task1_2.Person{Name = "John", Age = 22, PhoneNumbers = new List<string>() { "John's number #1", "John's number #2", "John's number #3" } },
                new collections.Task1_2.Person{Name = "Sid", Age = 25, PhoneNumbers = new List<string>() { "Sid's number #1", "Sid's number #2", "Sid's number #3" } },
            };

            Console.WriteLine("\nTask 1 \n");

            foreach (var person in people)
            {
                Console.WriteLine("Name: {0}, age: {1}", person.Name, person.Age);
            }

            #endregion

            #region Task2

            people.AddRange(new List<collections.Task1_2.Person>
            {
                new collections.Task1_2.Person{Name = "Nancy", Age = 24, PhoneNumbers = new List<string>() { "Nancy's number #1", "Nancy's number #2", "Nancy's number #3" } },
                new collections.Task1_2.Person{Name = "Alex", Age = 23, PhoneNumbers = new List<string>() { "Alex's number #1", "Alex's number #2", "Alex's number #3" } }
            });

            Console.WriteLine("\nTask 2 \n");

            foreach (var person in people)
            {
                Console.WriteLine("Name: {0}", person.Name);

                foreach (var number in person.PhoneNumbers)
                {
                    Console.WriteLine($"\t {number}");
                }
            }

            #endregion

            #region Task 3

            Console.WriteLine("\nTask 3 \n");

            var strings = GetListOfStrings();

            Console.WriteLine("The count before transformation is " + strings.Count);

            strings = strings.Distinct().ToList();

            for (int i = 0; i < strings.Count; i++)
            {
                if (strings[i].StartsWith("Z"))
                    strings.Remove(strings[i]);
            }

            Console.WriteLine("The count after transformation is " + strings.Count);

            strings.Sort((a, b) => -1 * a.CompareTo(b));

            Console.WriteLine("Enter the number of page:");

            int pageNumber = GetPageNumber();

            collections.Task3.ListExtention.DisplayPage(strings, pageNumber);

            #endregion

            #endregion

            Console.ReadLine();
        }
    }
}
