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

        /// <summary>
        /// 我们可以用一个额外的数组来将每个元素放到正确的位置上，也就是原本数组里下标为 i 的我们把它放到 (i+k)%数组长度的位置。然后把新的数组拷贝到原数组中。。
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="k"></param>
        public static void ReverseV4(int[] nums,int k)
        {
            int[] tempArray = new int[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                tempArray[(i + k) % nums.Length] = nums[i];
            }

            for(int i=0;i<nums.Length;i++)
            {
                nums[i] = tempArray[i];
            }
        }
        /// <summary>
        /// 如果我们直接把每一个数字放到它最后的位置，但这样的后果是遗失原来的元素。因此，我们需要把被替换的数字保存在变量 temp 里面。
        /// 然后，我们将被替换数字（temptemp）放到它正确的位置，并继续这个过程 n 次， n 是数组的长度。这是因为我们需要将数组里所有的元素都移动。
        /// 但是，这种方法可能会有个问题，如果 n%k==0，其中 k=k%n （因为如果 k 大于 n ，移动 k 次实际上相当于移动 k%n 次）。
        /// 这种情况下，我们会发现在没有遍历所有数字的情况下回到出发数字。此时，我们应该从下一个数字开始再重复相同的过程。
        ///现在，我们看看上面方法的证明。假设，数组里我们有 n 个元素并且 k 是要求移动的次数。
        ///更进一步，假设 n%k=0 。第一轮中，所有移动数字的下标 i 满足 i%k==0 。这是因为我们每跳 k 步，我们只会到达相距为 k 个位置下标的数。
        ///每一轮，我们都会移动 n/k个元素。下一轮中，我们会移动满足 i%k==1 的位置的数。
        ///这样的轮次会一直持续到我们再次遇到 i%k==0 的地方为止，此时 i = k 。此时在正确位置上的数字共有 k×n/k个。因此所有数字都在正确位置上。
        ///让我们看一下接下来的例子，以更好地说明这个过程：
        ///作者：LeetCode
        ///链接：https://leetcode-cn.com/problems/rotate-array/solution/xuan-zhuan-shu-zu-by-leetcode/
        ///来源：力扣（LeetCode）
        ///著作权归作者所有。商业转载请联系作者获得授权，非商业转载请注明出处。
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="k"></param>
        public static void RotateV3(int[] nums, int k)
        {
            int Count = 0;
            k = k % nums.Length;
            for (int start = 0; Count < nums.Length; start++)
            {
                int current = start;
                int prev = nums[start];
                do
                {
                    int next = (current + k) % nums.Length;
                    int temp = nums[next];
                    nums[next] = prev;
                    prev = temp;
                    current = next;
                    Count++;
                } while (start != current);
            }
        }
    }
}
