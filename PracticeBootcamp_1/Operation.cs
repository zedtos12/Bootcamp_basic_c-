using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeBootcamp_1
{
    internal class Operation
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Operation Section");
            Console.WriteLine();

            //Operation

            int a = 30;
            int b = 60;
            int c = 25;
            int d = 4;
            int e = 3;

            #region sum
            int sum = a + b;
            Console.WriteLine("a + b = " + sum);
            #endregion

            Console.WriteLine();

            #region Difference
            int difference = b - a;
            int difference2 = a - b;

            Console.WriteLine("b - a = " + difference);
            Console.WriteLine("a - b = " + difference2);
            #endregion

            Console.WriteLine();

            #region Product 
            int product = e * d;
            Console.WriteLine("e * d = " + product);
            #endregion

            Console.WriteLine();

            #region division 
            int division = b / a;
            int divison2 = b / c;

            Console.WriteLine("b / a = " + division);
            Console.WriteLine("b / c = " + divison2);
            #endregion

            Console.WriteLine();

            #region modulo 
            int module1 = b % a;
            int module2 = b % c;

            Console.WriteLine("b % a = " + module1);
            Console.WriteLine("b % c = " + module2);
            #endregion

            Console.WriteLine();
        }
    }
}
