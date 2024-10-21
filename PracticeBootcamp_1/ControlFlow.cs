using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeBootcamp_1
{
    internal class ControlFlow
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Control Flow Section");
            Console.WriteLine();

            #region if else statement
            int number = 100;

            if (number == 100)
            {
                Console.WriteLine("Number is 100");
            }
            else
            {
                Console.WriteLine("Number is not 100");
            }
            #endregion

            #region Switch statement
            int day = 1;

            switch (day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
            }
            #endregion

            Console.WriteLine();

            #region for and foreach loop
            List<string> listAnimals = new List<string>();
            listAnimals.Add("Cat");
            listAnimals.Add("Dog");
            listAnimals.Add("Bird");

            for (int i = 0; i < listAnimals.Count; i++)
            {
                Console.WriteLine(listAnimals[i]);
            }

            Console.WriteLine();

            foreach (var animal in listAnimals)
            {
                Console.WriteLine(animal);
            }

            #endregion

            Console.WriteLine();

            #region while loop and do while lopp
            int num = 0;

            while (num < 5)
            {
                Console.WriteLine(num);
                num++;
            }

            Console.WriteLine();
            num = 0;

            do
            {
                Console.WriteLine(num);
                num++;
            } while (num < 5);

            #endregion
        }
    }
}
