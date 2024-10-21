using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeBootcamp_1
{
    internal class Collection
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Collection Section");
            Console.WriteLine();

            #region Array
            int[] arrayNumbers = new int[30];
            arrayNumbers[0] = 1;
            arrayNumbers[1] = 2;
            arrayNumbers[2] = 3;

            Console.WriteLine("Array 1 = " + arrayNumbers[0]);
            Console.WriteLine("Array 2 = " + arrayNumbers[1]);
            Console.WriteLine("Array 3 = " + arrayNumbers[2]);
            Console.WriteLine("Array 4 = " + arrayNumbers[3]);
            Console.WriteLine();

            bool[] arrayBools = new bool[2];
            arrayBools[0] = true;
            arrayBools[1] = false;

            Console.WriteLine("Array 1 = " + arrayBools[0]);
            Console.WriteLine("Array 2 = " + arrayBools[1]);
            #endregion

            Console.WriteLine();

            #region List
            List<string> listString = new List<string>();
            listString.Add("Hello");
            listString.Add("World");

            Console.WriteLine("List 1 = " + listString[0]);
            Console.WriteLine("List 2 = " + listString[1]);
            #endregion

            Console.WriteLine();

            #region Dictionary
            Dictionary<int, string> dictionarys = new Dictionary<int, string>();
            dictionarys.Add(1, "Harry Potter");
            dictionarys.Add(2, "Hermione Granger");
            dictionarys.Add(3, "Ron Weasley");

            Console.WriteLine("Dictionary 1 = " + dictionarys[1]);
            Console.WriteLine("Dictionary 2 = " + dictionarys[2]);
            Console.WriteLine("Dictionary 3 = " + dictionarys[3]);
            #endregion

            Console.WriteLine();

            #region Sets
            HashSet<int> numberSets = new HashSet<int>();
            numberSets.Add(1);
            numberSets.Add(2);
            numberSets.Add(2);

            Console.WriteLine("Sets 1 = " + numberSets.ElementAt(0));
            Console.WriteLine("Sets 2 = " + numberSets.ElementAt(1));

            Console.WriteLine();

            HashSet<string> stringSets = new HashSet<string>();
            stringSets.Add("Hello");
            stringSets.Add("World");

            Console.WriteLine("Sets 1 = " + stringSets.ElementAt(0));
            Console.WriteLine("Sets 1 = " + stringSets.ElementAt(1));
            #endregion

            Console.WriteLine();
        }
    }
}
