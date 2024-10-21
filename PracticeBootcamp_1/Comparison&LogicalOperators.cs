using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeBootcamp_1
{
    internal class Comparison_LogicalOperators
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Comparison & Logical Operators Section");
            Console.WriteLine();

            //Comparison Operators
            int a = 60;
            int b = 30;
            int c = 60;

            #region equal 
            bool equal = a == b;
            bool equal2 = a == c;

            Console.WriteLine("a == b = " + equal);
            Console.WriteLine("a == c = " + equal2);
            #endregion

            Console.WriteLine();

            #region grater or less 
            bool isGreater = a > b;
            bool isLess = a < b;

            bool isGreaterOrEqual = a >= b;
            bool isLessOrEqual = a <= b;

            Console.WriteLine("a > b = " + isGreater);
            Console.WriteLine("a < b = " + isLess);
            Console.WriteLine();
            Console.WriteLine("a >= b = " + isGreaterOrEqual);
            Console.WriteLine("a <= b = " + isLessOrEqual);
            #endregion

            Console.WriteLine();

            //logical Operators
            bool trueValue = true;
            bool falseValue = false;

            bool andResult = trueValue && falseValue;
            bool orResult = trueValue || falseValue;
            bool notResult = !trueValue;

            Console.WriteLine();
        }
    }
}
