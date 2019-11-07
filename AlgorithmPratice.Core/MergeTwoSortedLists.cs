using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPractice.Core
{
    public class MergeTwoSortedLists
    {
        public class ListNode
        {
            public int val;
            public ListNode next;

            public ListNode(int value)
            {
                val = value;
            }
        }

        /// <summary>
        /// 将两个有序链表合并为一个新的有序链表并返回。新链表是通过拼接给定的两个链表的所有节点组成的。
        /// 示例：
        /// 输入：1->2->4, 1->3->4
        /// 输出：1->1->2->3->4->4
        /// </summary>
        /// <param name="l1"></param>
        /// <param name="l2"></param>
        /// <returns></returns>
        public ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            if (l1 == null) return l2;
            if (l2 == null) return l1;

            if (l1.val > l2.val)
            {
                l2.next = MergeTwoLists(l1, l2.next);
                return l2;
            }
            else
            {
                l1.next = MergeTwoLists(l1.next, l2);
                return l1;
            }
        }
    }
}
