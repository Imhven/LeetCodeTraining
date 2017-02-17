using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Xs.LeetCode.Algorithms
{
    //Given a string, find the length of the longest substring without repeating characters.

    //Examples:

    //Given "abcabcbb", the answer is "abc", which the length is 3.

    //Given "bbbbb", the answer is "b", with the length of 1.

    //Given "pwwkew", the answer is "wke", with the length of 3. Note that the answer must be a substring, "pwke" is a subsequence and not a substring.

    //Subscribe to see which companies asked this question.
    public class LongestSubstringWithoutRepeatingCharacters
    {
        public int LengthOfLongestSubstring(String s)
        {
            int n = s.Length, ans = 0;
            int[] index = new int[128]; // current index of character
                                        // try to extend the range [i, j]
            for (int j = 0, i = 0; j < n; j++)
            {
                i = Math.Max(index[s[j]], i);
                ans = Math.Max(ans, j - i + 1);
                index[s[j]] = j + 1;
            }
            return ans;
        }
        /// <summary>
        /// 使用Dictionary实现
        /// </summary>
        /// <param name="s"></param> 
        /// <returns></returns>
        public int Start(string s)
        {
            if (s.Length == 1)
            {
                return 1;
            }
            var dic = new Dictionary<int, int>();
            var max = 0;
            var start = 0;
            int i;
            for (i = 0; i < s.Length; i++)
            {
                if (dic.ContainsKey(s[i]))
                {
                    if (dic[s[i]] >= start)
                    {
                        start = dic[s[i]] + 1;
                    }
                    dic.Remove(s[i]);
                }
                max = Math.Max(i + 1 - start, max);
                dic.Add(s[i], i);
            }
            return max;
        }

        /// <summary>
        /// 测试用例
        /// </summary>
        public void Test()
        {
            Console.WriteLine(Start("abcabcbb"));
            Console.WriteLine(Start("bbbbb"));
            Console.WriteLine(Start("pwwkew"));
            Console.WriteLine(Start("au"));
        }
    }
}
