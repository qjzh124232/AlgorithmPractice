using AlgorithmPractice.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPractice.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4, 5, 5, 6, 8, 8, 9 };
            int arrayLength = ArrayPractice.RemoveDuplicatesV2(nums);
            System.Console.WriteLine(arrayLength);

            foreach (int item in nums)
            {
                System.Console.WriteLine(item);
            }
        }
    }
}
