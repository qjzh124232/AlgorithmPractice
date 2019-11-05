﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPractice.Core
{
    public class RemoveDuplicatesFromSortedArray
    {
        /********************************************
         * 给定一个排序数组，你需要在原地删除重复出现的元素，使得每个元素只出现一次，返回移除后数组的新长度。
         *不要使用额外的数组空间，你必须在原地修改输入数组并在使用 O(1) 额外空间的条件下完成。

         *来源：力扣（LeetCode）
         *链接：https://leetcode-cn.com/problems/remove-duplicates-from-sorted-array
         *著作权归领扣网络所有。商业转载请联系官方授权，非商业转载请注明出处。
         * 
         * 示例 1：
         * 给定数组 nums = [1,1,2], 
         * 函数应该返回新的长度 2, 并且原数组 nums 的前两个元素被修改为 1, 2。 
         * 你不需要考虑数组中超出新长度后面的元素。。
         * 
         * 示例 2：
         * 给定 nums = [0,0,1,1,1,2,2,3,3,4],
         * 函数应该返回新的长度 5, 并且原数组 nums 的前五个元素被修改为 0, 1, 2, 3, 4。
         * 你不需要考虑数组中超出新长度后面的元素。
         * ********************************************/
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

        /**************************************
         * 数组完成排序后，我们可以放置两个指针 i 和 j，其中 i 是慢指针，而 j 是快指针。只要 nums[i] = nums[j],我们就增加 j以跳过重复项。
         *  当我们遇到 nums[j] != nums[i]时，跳过重复项的运行已经结束，因此我们必须把它（nums[j]）的值复制到 nums[i + 1]。然后递增 i，接着我们将再次重复相同的过程，直到 j 到达数组的末尾为止。
         *   作者：LeetCode
         *  链接：https://leetcode-cn.com/problems/remove-duplicates-from-sorted-array/solution/shan-chu-pai-xu-shu-zu-zhong-de-zhong-fu-xiang-by-/
         *   来源：力扣（LeetCode）
         *  著作权归作者所有。商业转载请联系作者获得授权，非商业转载请注明出处。
         * ****************************************************/
    }
}
