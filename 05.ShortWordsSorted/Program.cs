using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.ShortWordsSorted
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] separators = {'.', ',', ':', ';', '(', ')',
                '[', ']', '"', '\'', '\\', '/', '!', '?', ' '};

            List<string> text = Console.ReadLine()
                .ToLower()
                .Split(separators,StringSplitOptions.RemoveEmptyEntries)
                .ToList();

           text = text.Distinct().Where(x => x.Length < 5)
                .OrderBy(x => x).ToList();
            if (text[0] == " ")
            {
                text.RemoveAt(0);
            }
            Console.WriteLine(String.Join(", ", text));
        }
    }
}
