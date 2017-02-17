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
        /// <summary>
        /// 使用二分查找实现
        /// </summary>
        /// <param name="nums1"></param>
        /// <param name="nums2"></param>
        /// <returns></returns>
        public static double Start(int[] nums1, int[] nums2)
        {
            int leftStart = 0,
                leftEnd = nums1.Length - 1,
                rightStart = 0,
                rightEnd = nums2.Length
                ;
            while (true)
            {
                var leftMid = nums1[(leftStart + leftEnd) / 2];
                var rightMid = nums2[(rightStart + rightEnd) / 2];
                if (leftMid < rightMid)
                {
                    leftStart = (leftStart + leftEnd) / 2;
                    rightEnd = (rightStart + rightEnd) / 2;
                }
                else if (leftMid == rightMid)
                {
                    break;
                }
                else
                {
                    leftEnd = (leftStart + leftEnd) / 2;
                    rightStart = (rightStart + rightEnd) / 2;
                }

                if (leftMid >= nums2[0] || rightMid <= nums1[nums1.Length - 1])
                {
                    break;
                }
                var t = 0;
            }
            return 0;
        }
        /// <summary>
        /// 测试用例
        /// </summary>
        public void Test()
        {
            var test1 = new int[]
            {
                72, 815, 387, 418, 434
            };
            var test2 = new int[]
            {
                 542, 985, 940, 116, 153, 47, 806
            };
            var test3 = new int[]
            {
                72, 815, 387,
                575, 988, 44,
                404, 463, 285,
                994, 823, 219,
                337, 903, 712,
            };
            var test4 = new int[]
            {
                254, 956, 971,
                714, 234, 567,
                293, 946, 678,
                91, 250, 413,
            };
            var test5 = new int[]
            {
                227, 131, 85, 51, 361, 343, 641, 568, 922, 145, 256, 177, 329, 959, 991, 293, 850, 858, 76, 291, 134
            };
            Start((from element in test1 orderby element ascending select element)
                   .ToArray(),
                   (from element in test2 orderby element ascending select element)
                   .ToArray());
            Start((from element in test1 orderby element ascending select element)
                   .ToArray(),
                   (from element in test3 orderby element ascending select element)
                   .ToArray());
            Start((from element in test1 orderby element ascending select element)
                   .ToArray(),
                   (from element in test4 orderby element ascending select element)
                   .ToArray());
            Start((from element in test1 orderby element ascending select element)
                   .ToArray(),
                   (from element in test5 orderby element ascending select element)
                   .ToArray()); 
        }
    }
}
