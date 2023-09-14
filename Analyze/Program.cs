using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Analyze
{
    internal class Program
    {
        public static void Analyze(string str, out int letter, out int numeric, out int spec)
        {
            letter = str.Count(char.IsLetter);
            numeric = str.Count(char.IsDigit);
            spec = str.Length - letter - numeric;

        }
        static void Main(string[] args)
        {
            string str = "dynamo100%";
            int letter, numeric, spec;
            Analyze(str, out letter, out numeric, out spec);

            Console.WriteLine("Number of letters: " + letter);
            Console.WriteLine("Amount of numbers: " + numeric);
            Console.WriteLine("Number of special characters: " + spec);

            Console.ReadLine();
        }
    }
}
