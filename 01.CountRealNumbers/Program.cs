using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.CountRealNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> realNumbers = Console.ReadLine()
                .Split().Select(double.Parse).ToList();

            var result = new Dictionary<double, int>();

            foreach (var item in realNumbers)
            {
                if (result.ContainsKey(item))
                {
                    result[item]++;
                }
                else
                {
                    result[item] = 1;
                }                     
            }
            
            foreach (var item in result.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
