using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collections
{
    namespace Task1_2
    {
        public class Person
        {
            public string Name { get; set; }

            public int Age { get; set; }

            public IEnumerable<string> PhoneNumbers { get; set; }
        }

    }

    namespace Task3
    {
        public static class ListExtention
        {
            public static void DisplayPage(this List<string> listOfStrings, int pageNumber)
            {
                if (pageNumber != -1)
                {
                    if (pageNumber * 5 <= listOfStrings.Count + 5)
                    {
                        if (pageNumber * 5 < listOfStrings.Count - 5)
                        {
                            for (int i = 5 * (pageNumber - 1); i < 5 * pageNumber; i++)
                                Console.WriteLine(listOfStrings[i]);
                        }

                        else
                        {
                            for (int i = 5 * (pageNumber - 1); i < listOfStrings.Count; i++)
                                Console.WriteLine(listOfStrings[i]);
                        }
                    }
                    else
                    {
                        Console.WriteLine("The list is not so big!");
                    }
                }
            }
        }
    }
}
