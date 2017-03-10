using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Xs.LeetCode.Algorithms
{
    /// <summary>
    /// Note: This is a companion problem to the System Design problem: Design TinyURL.
    /// TinyURL is a URL shortening service where you enter a URL 
    /// such as https://leetcode.com/problems/design-tinyurl and it returns a short URL such as http://tinyurl.com/4e9iAk.
    /// Design the encode and decode methods for the TinyURL service.
    /// There is no restriction on how your encode/decode algorithm should work.
    /// You just need to ensure that a URL can be encoded to a tiny URL and the tiny URL can be decoded to the original URL.
    /// Subscribe to see which companies asked this question.
    /// </summary>
    // ReSharper disable once InconsistentNaming
    public class EncodeAndDecodeTinyURL
    {
        private readonly List<string> _urls = new List<string>();
        // Encodes a URL to a shortened URL.
        // Encodes a URL to a shortened URL
        public string encode(string longUrl)
        {
            _urls.Add(longUrl);
            return (_urls.Count - 1).ToString();
        }

        // Decodes a shortened URL to its original URL.
        public string decode(string shortUrl)
        {
            int index = int.Parse(shortUrl);
            return (_urls.Count > index ? _urls[index] : "");
        }
    }
}
