using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution_8_lesson
{
    internal class Program
    {
        static bool Compare(string a, string b)
        {

            if ((object)a == null || (object)b == null)
                return false;

            else if (a.Length != b.Length)
                return false;

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] != b[i])
                    return false;
            }
            return true;

        }

        public static (int letter, int numeric, int spec) Analyze(string input)
        {
            int letter = 0;
            int numeric = 0;
            int spec = 0;

            foreach (char c in input)
            {
                if (char.IsLetter(c))
                {
                    letter++;
                }
                else if (char.IsDigit(c))
                {
                    numeric++;
                }
                else
                {
                    spec++;
                }
            }

            return (letter, numeric, spec);

        }

        static string Sort(string c)
        {
            char[] arr = c.ToCharArray();
            for (int i = 0; i < arr.Length; i++)
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        char temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            return new string(arr);

        }

        static void Main(string[] args)
        {        
            string a = "real";
            string b = "Real";
            string c = "zhytomyr";
            string input = "dynamo100%";

            Console.WriteLine(Sort(c));
            Console.WriteLine(Compare(a, b));
            Console.WriteLine(Analyze(input));

            Console.ReadLine();
        }
    }
}
