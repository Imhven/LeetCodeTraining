using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Xs.LeetCode.Algorithms
{
    //You are given two non-empty linked lists representing two non-negative integers.The digits are stored in reverse order and each of their nodes contain a single digit.Add the two numbers and return it as a linked list.

    //You may assume the two numbers do not contain any leading zero, except the number 0 itself.

    //Input: (2 -> 4 -> 3) + (5 -> 6 -> 4)
    //Output: 7 -> 0 -> 8
    public class AddTwoNumbers
    {
        public ListNode Start(ListNode l1, ListNode l2)
        {
            var left = l1;
            var right = l2;
            var listNode = new ListNode(0);
            ListNode listNode1;
            var resultNode = listNode;
            do
            {
                if (left != null)
                {
                    listNode.val += left.val;
                    left = left.next;
                }
                if (right != null)
                {
                    listNode.val += right.val;
                    right = right.next;
                }
                if (listNode.val >= 10)
                {
                    listNode.next = listNode.next ?? new ListNode(0);
                    listNode.next.val += listNode.val / 10;
                    listNode.val = listNode.val % 10;
                }
                listNode.next = listNode.next ?? new ListNode(0);
                listNode1 = listNode;
                listNode = listNode.next;
            } while (left != null || right != null);
            if (listNode1.next != null && listNode1.next.val == 0)
            {
                listNode1.next = null;
            }
            return resultNode;
        }

        /// <summary>
        /// 测试用例
        /// </summary>
        public void Test()
        {
            //var l1 = new ListNode(2);
            //l1.next = new ListNode(4);
            //l1.next.next = new ListNode(3);

            //var l2 = new ListNode(5);
            //l2.next = new ListNode(6);
            //l2.next.next = new ListNode(4);
            var l1 = InitData(new int[] { 2, 4, 3 });
            var l2 = InitData(new int[] { 5, 6, 4 });
            Start(l1, l2); 
        }

        private static ListNode InitData(int[] array)
        {
            if (array == null || array.Length == 0)
            {
                return null;
            }
            var listNode = new ListNode(array[0]);
            var listPoint = listNode;
            for (var i = 1; i < array.Length; i++)
            {
                listPoint.next = new ListNode(array[i]);
                listPoint = listPoint.next;
            }
            return listNode;
        }
    }


    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }

}
