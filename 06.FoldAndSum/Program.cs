using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.FoldAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int oneFouth = array.Length / 4;


            int[] leftSide = array.Take(oneFouth).Reverse().ToArray();
            int[] rightSide = array.Reverse().Take(oneFouth).ToArray();
            int[] top = leftSide.Concat(rightSide).ToArray();
            int[] bottom = array.Skip(oneFouth).Take(oneFouth * 2).ToArray();

            var sum = top.Select((x, index) => x + bottom[index]);
            Console.WriteLine(String.Join(" ", sum));
            
        }
    }
}
