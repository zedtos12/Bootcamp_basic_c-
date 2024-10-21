using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeBootcamp_1
{
    internal class Variable
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Variable Section");
            Console.WriteLine();

            //Variable Type

            #region Integer 
            int angka1 = 30;
            int angka2 = 40;

            Console.WriteLine("angka 1 = " + angka1);
            Console.WriteLine("angka 2 = " + angka2);
            #endregion

            Console.WriteLine();

            #region Float Variable
            float float1 = 3.2f;
            float float2 = 4.5f;

            Console.WriteLine("float 1 = " + float1);
            Console.WriteLine("float 2 = " + float2);
            #endregion

            Console.WriteLine();

            #region double
            double double1 = 3.51231;
            double double2 = 4.23231;

            Console.WriteLine("double 1 = " + double1);
            Console.WriteLine("double 2 = " + double2);
            #endregion

            Console.WriteLine();

            #region decimal 
            decimal decimal1 = 3.5123123m;
            decimal decimal2 = 3.2312312m;

            Console.WriteLine("decimal 1 = " + decimal1);
            Console.WriteLine("decimal 2 = " + decimal2);
            #endregion

            #region Proving Decimal better than float and double
            // Menggunakan float
            float floatNumber = 1.1234567f + 0.0000001f;
            Console.WriteLine("Hasil dengan float: " + floatNumber);

            // Menggunakan double
            double doubleNumber = 1.123456789012345 + 0.000000000000001;
            Console.WriteLine("Hasil dengan double: " + doubleNumber);

            // Menggunakan decimal
            decimal decimalNumber = 1.1234567890123456789012345678m + 0.0000000000000000000000000001m;
            Console.WriteLine("Hasil dengan decimal: " + decimalNumber);
            #endregion

            Console.WriteLine();

            #region boolean 
            bool booleanTrue = true;
            bool booleanFalse = false;

            Console.WriteLine("boolean true = " + booleanTrue);
            Console.WriteLine("boolean false = " + booleanFalse);
            #endregion

            Console.WriteLine();

            #region char
            char a = 'a';
            char b = 'b';

            Console.WriteLine("char a = " + a);
            Console.WriteLine("char b = " + b);
            #endregion

            Console.WriteLine();

            #region string 
            string string1 = "Hello";
            string string2 = "world";

            Console.WriteLine("string 1 = " + string1);
            Console.WriteLine("string 2 = " + string2);
            #endregion

            #region var
            var varInteger = 30;
            var varString = "Hello";
            var varChar = 'a';
            var varFloat = 3.2f;
            var varDouble = 3.51231;
            var varDecimal = 3.5123123m;
            #endregion

            Console.WriteLine();
        }
    }
}
