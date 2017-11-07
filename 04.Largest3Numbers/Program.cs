using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Largest3Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> list = Console.ReadLine().Split().Select(double.Parse).ToList();

            
            foreach (var item in list.OrderByDescending(x => x).Take(3))
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
