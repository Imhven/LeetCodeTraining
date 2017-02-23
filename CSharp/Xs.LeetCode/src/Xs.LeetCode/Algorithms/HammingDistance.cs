using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Xs.LeetCode.Algorithms
{
    //The Hamming distance between two integers is the number of positions at which the corresponding bits are different.

    //Given two integers x and y, calculate the Hamming distance.

    //Note:
    //0 ≤ x, y< 231.

    //Example:

    //Input: x = 1, y = 4

    //Output: 2

    //Explanation:
    //1   (0 0 0 1)
    //4   (0 1 0 0)
    //       ↑  ↑

    //The above arrows point to positions where the corresponding bits are different.
    public class HammingDistance
    {
        public static int Start(int x, int y)
        {
            var result = 1;
            var index = 0;
            var count = 0; 
            while (index < 32)
            {
                if ((y & result) != (x & result))
                {
                    count++;
                } 
                result = result << 1;
                index++;
            }
            return count;
        }
        /// <summary>
        /// 测试用例
        /// </summary>
        public static void Test()
        {
            Console.WriteLine(1 ^ 4);
            Console.WriteLine(Start(1, 4));
            Console.WriteLine(Start(3, 4));
            Console.WriteLine(Start(5, 6));
            Console.WriteLine(Start(7, 8));
        }
    }
}
