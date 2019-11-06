using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPractice.Core
{
    // 给出 n 个数对。 在每一个数对中，第一个数字总是比第二个数字小。
    //现在，我们定义一种跟随关系，当且仅当 b<c 时，数对(c, d)才可以跟在(a, b)后面。我们用这种形式来构造一个数对链。
    //给定一个对数集合，找出能够形成的最长数对链的长度。你不需要用到所有的数对，你可以以任何顺序选择其中的一些数对来构造。
    //来源：力扣（LeetCode）
    //链接：https://leetcode-cn.com/problems/maximum-length-of-pair-chain
    //著作权归领扣网络所有。商业转载请联系官方授权，非商业转载请注明出处。

    public class MaximumLengthofPairChain
    {
        /// <summary>
        /// 输入: [[1,2], [2,3], [3,4]]
        /// 输出: 2
        /// 解释: 最长的数对链是 [1,2] -> [3,4]
        /// </summary>
        /// <param name="pairs"></param>
        /// <returns></returns>
        public static int FindLongestChain(int[][] pairs)
        {
            for (int i = 0; i < pairs.Length; i++)
            {
                int[] temp;
                for (int j = i + 1; j < pairs.Length; j++)
                {
                    if (pairs[i][1] > pairs[j][1]) //为何用每个数对的后一个值进行排序？？？
                    {
                        temp = pairs[i];
                        pairs[i] = pairs[j];
                        pairs[j] = temp;
                    }
                }
            }

            int maxLength = 1;
            for (int i = 0; i < pairs.Length; i++)
            {
                int step = i;
                int currentLength = 1;

                for (int j = 0; j < pairs.Length; j++)
                {
                    if (pairs[j][0] > pairs[step][1])
                    {
                        currentLength++;
                        if (maxLength < currentLength) maxLength = currentLength;
                        step = j;
                    }
                }

            }
            return maxLength;
        }
    }
}
