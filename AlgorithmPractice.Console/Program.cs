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
            // 原地删除重复出现的元素
            int[] nums = { 1, 1, 2, 2, 3, 4, 5, 6, 7, 7, 8, 8, 9 };
            int arrayLength = RemoveDuplicatesFromSortedArray.RemoveDuplicates(nums);
            System.Console.WriteLine(arrayLength);

            for (int i = 0; i < arrayLength; i++)
            {
                System.Console.Write(nums[i]);
                System.Console.Write(",");
            }
            System.Console.WriteLine();

            //最长数对链

            //int[][] nums2 = { new int[] { -10, 2 }, new int[] { 2, 3 }, new int[] { 3, 4 }, new int[] { 4, 5 }, new int[] { 5, 6 } };
            //[[7,9],[4,5],[7,9],[-7,-1],[0,10],[3,10],[3,6],[2,3]]
            //[[-7,-2],[0,8],[0,7],[-2,7],[5,9],[9,10]]
            int[][] nums2 =
                {
                new int[]{ -7,-2 },
                new int[]{ 0,8 },
                new int[]{0,7 },
                new int[]{ -2,7 },
                new int[]{ 5,9 },
                new int[]{ 9,10 }//,
                //new int[]{ 3,6},
                //new int[]{ 2, 3 }
            };
            int maxLength = MaximumLengthofPairChain.FindLongestChain(nums2);


            //旋转数组
            int[] Rotate = { 1, 2, 3, 4, 5, 6, 7 };
            RotateArray.RotateV3(Rotate, 3);

        }
    }
}
