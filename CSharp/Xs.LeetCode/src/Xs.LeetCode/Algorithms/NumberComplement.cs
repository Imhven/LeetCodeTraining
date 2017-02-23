using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Xs.LeetCode.Algorithms
{
    //Given a positive integer, output its complement number.The complement strategy is to flip the bits of its binary representation.

    //Note:
    //The given integer is guaranteed to fit within the range of a 32-bit signed integer.
    //You could assume no leading zero bit in the integer’s binary representation.
    //Example 1:
    //Input: 5
    //Output: 2
    //Explanation: The binary representation of 5 is 101 (no leading zero bits), and its complement is 010. So you need to output 2.
    //Example 2:
    //Input: 1
    //Output: 0
    //Explanation: The binary representation of 1 is 1 (no leading zero bits), and its complement is 0. So you need to output 0.
    public class NumberComplement
    {

        public static int Start(int x)
        {
            var result = int.MaxValue;
            var index = 1 << 30;
            while (true)
            { 
                if ((x & index) == 0)
                {

                    result = result >> 1;
                }
                else
                {
                    break;
                }
                index = index >> 1;
            } 
            return x ^ result; 
        }
        /// <summary>
        /// 测试用例
        /// </summary>
        public static void Test()
        {
            Console.WriteLine(Start(1));
            Console.WriteLine(Start(3));
            Console.WriteLine(Start(5));
            Console.WriteLine(Start(7));
        }
    }
}
