using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ocjenskaVjezba
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite rečenicu:");
            string input = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(input))
            {
                string[] words = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                if (words.Length > 0)
                {
                    string firstWord = words[0];
                    string lastWord = words[words.Length - 1];

                    Console.WriteLine($"Prva riječ: {firstWord}");
                    Console.WriteLine($"Zadnja riječ: {lastWord}");
                }
            }
            Console.ReadKey();
        }
    }
}
