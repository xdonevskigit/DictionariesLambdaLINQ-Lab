using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.OddOccurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine().ToLower().Split();

            var countDic = new Dictionary<string, int>();

            foreach (var item in words)
            {
                if (countDic.ContainsKey(item))
                {
                    countDic[item]++;
                }
                else
                {
                    countDic[item] = 1;
                }
            }

            List<string> result = new List<string>();

            foreach (var item in countDic)
            {
                if (item.Value % 2 != 0)
                {
                    result.Add(item.Key);
                }
            }
            Console.WriteLine(String.Join(", ", result));
        }
    }
}
