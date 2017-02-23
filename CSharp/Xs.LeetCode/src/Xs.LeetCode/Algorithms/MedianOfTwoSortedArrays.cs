using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Xs.LeetCode.Algorithms
{
    //There are two sorted arrays nums1 and nums2 of size m and n respectively.

    //Find the median of the two sorted arrays.The overall run time complexity should be O(log (m+n)).

    //Example 1:
    //    nums1 = [1, 3]
    //    nums2 = [2]

    //    The median is 2.0
    //Example 2:
    //    nums1 = [1, 2]
    //    nums2 = [3, 4]

    //The median is (2 + 3)/2 = 2.5
    public class MedianOfTwoSortedArrays
    {

        // find kth number of two sorted array
        public static int findKth(int[] A, int A_start,
                                  int[] B, int B_start,
                                  int k)
        {
            if (A_start >= A.Length)
            {
                return B[B_start + k - 1];
            }
            if (B_start >= B.Length)
            {
                return A[A_start + k - 1];
            }

            if (k == 1)
            {
                return Math.Min(A[A_start], B[B_start]);
            }

            int A_key = A_start + k / 2 - 1 < A.Length
                        ? A[A_start + k / 2 - 1]
                        : int.MaxValue;
            int B_key = B_start + k / 2 - 1 < B.Length
                        ? B[B_start + k / 2 - 1]
                        : int.MaxValue;

            if (A_key < B_key)
            {
                return findKth(A, A_start + k / 2, B, B_start, k - k / 2);
            }
            else
            {
                return findKth(A, A_start, B, B_start + k / 2, k - k / 2);
            }
        }
        /// <summary>
        /// 使用二分查找实现
        /// </summary>
        /// <param name="nums1"></param>
        /// <param name="nums2"></param>
        /// <returns></returns>
        public static double Start(int[] nums1, int[] nums2)
        {
            var A = nums1;
            var B = nums2;
            int len = A.Length + B.Length;
            if (len % 2 == 1)
            {
                return findKth(A, 0, B, 0, len / 2 + 1);
            }
            return (
                findKth(A, 0, B, 0, len / 2) + findKth(A, 0, B, 0, len / 2 + 1)
            ) / 2.0;
        }
        /// <summary>
        /// 测试用例
        /// </summary>
        public void Test()
        {
            var test1 = new int[]
            {
                72, 387, 418, 434, 815,
            }.OrderBy(m => m).ToArray();
            var test2 = new int[]
            {
                47, 116, 153, 542, 806, 940, 985
            }.OrderBy(m => m).ToArray();
            var test3 = new int[]
            {
                72, 815, 387,
                575, 988, 44,
                404, 463, 285,
                994, 823, 219,
                337, 903, 712,
            }.OrderBy(m => m).ToArray();
            var test4 = new int[]
            {
                254, 956, 971,
                714, 234, 567,
                293, 946, 678,
                91, 250, 413,
            }.OrderBy(m => m).ToArray();
            var test5 = new int[]
            {
                227, 131, 85, 51, 361, 343, 641, 568, 922, 145, 256, 177, 329, 959, 991, 293, 850, 858, 76, 291, 134
            }.OrderBy(m => m).ToArray();
             
            Console.WriteLine(Start(test1, test2));
            Console.WriteLine(Start(test1, test3));
            Console.WriteLine(Start(test1, test4));
            Console.WriteLine(Start(test1, test5));
        }
    }
}
