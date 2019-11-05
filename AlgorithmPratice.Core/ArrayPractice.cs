using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPratice.Core
{
    public class ArrayPractice
    {
        public static int RemoveDuplicates(int[] nums)
        {
            int j = 0;
            for (int i = 1; i <= nums.Length; i++)
            {
                if (nums[i] != nums[j])
                {
                    j++;
                    nums[j] = nums[i];
                }
            }
            return j;
        }
        public static int RemoveDuplicatesV2(int[] nums)
        {
            int j = 0;
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] != nums[j])
                {
                    j++;
                    if (i - j > 0)
                    {
                        nums[j] = nums[i];
                    }
                }   
            }
            return j;
        }
    }
}
