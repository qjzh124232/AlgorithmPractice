using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPractice.Core
{
    /// <summary>
    /// 给定一个数组，将数组中的元素向右移动 k 个位置，其中 k 是非负数
    /// 输入: [1,2,3,4,5,6,7] 和 k = 3
    /// 输出: [5,6,7,1,2,3,4]
    /// 向右旋转 1 步: [7,1,2,3,4,5,6]
    /// 向右旋转 2 步: [6,7,1,2,3,4,5]
    /// 向右旋转 3 步: [5,6,7,1,2,3,4]
    /// 尽可能想出更多的解决方案，至少有三种不同的方法可以解决这个问题。
    /// 要求使用空间复杂度为 O(1) 的 原地 算法。
    /// https://leetcode-cn.com/problems/rotate-array/solution/xuan-zhuan-shu-zu-by-leetcode/
    /// </summary>
    public class RotateArray
    {
        /// <summary>
        /// 时间复杂度 O(n * k)  nums.Length 和K 很大时，运行时间会非常长。
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="k"></param>
        public static void Rotate(int[] nums, int k)
        {
            for (int i = 0; i < k; i++)
            {
                int lastValue = nums[nums.Length - 1];
                for (int j = nums.Length - 1; j > 0; j--)
                {
                    nums[j] = nums[j - 1];
                }
                nums[0] = lastValue;
            }
        }


        /// <summary>
        /// 原始数组                  : 1 2 3 4 5 6 7
        /// 反转所有数字后             : 7 6 5 4 3 2 1
        /// 反转前 k 个数字后          : 5 6 7 4 3 2 1
        /// 反转后 n-k 个数字后        : 5 6 7 1 2 3 4 --> 结果
        /// 时间复杂度：O(n)O(n) 。 nn 个元素被反转了总共 3 次。
        /// 空间复杂度：O(1)O(1) 。 没有使用额外的空间。
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="k"></param>
        public static void RotateV2(int[] nums, int k)
        {
            k %= nums.Length;
            Reverse(nums, 0, nums.Length - 1); //数组全体翻转
            Reverse(nums, 0, k - 1); //前K个数据翻转
            Reverse(nums, k, nums.Length - 1); //后K个数据翻转
        }

        protected static void Reverse(int[] nums,int begin,int end)
        {
            while (begin < end)
            {
                int temp = nums[begin];
                nums[begin] = nums[end];
                nums[end] = temp;
                begin++;
                end--;
            }
        }
    }
}
