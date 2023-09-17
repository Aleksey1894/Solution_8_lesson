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

            for(int i = 0; i <a.Length; i++)
            {
                if (a[i] != b[i])
                    return false;
            }
            return (true);
                      
        }

        static void Main(string[] args)
        {
            string a = "real";
            string b = "Real";

            bool result = Compare(a, b);

            Console.WriteLine(result);

            Console.ReadLine();
        }
    }
}
