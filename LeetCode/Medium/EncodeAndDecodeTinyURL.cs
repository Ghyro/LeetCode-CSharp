using System;
using System.Collections.Generic;
using System.Text;

namespace Medium
{
    // Issue: 535

    // TinyURL is a URL shortening service where you enter a URL such as https://leetcode.com/problems/design-tinyurl and
    // it returns a short URL such as http://tinyurl.com/4e9iAk. Design a class to encode a URL and decode a tiny URL.
    // There is no restriction on how your encode/decode algorithm should work.You just need to ensure that a URL can be
    // encoded to a tiny URL and the tiny URL can be decoded to the original URL.

    class EncodeAndDecodeTinyURL
    {
        public class Codec
        {
            Dictionary<string, string> encodedDct = new Dictionary<string, string>();
            Dictionary<string, string> decodedDct = new Dictionary<string, string>();
            const string SYMBOLS = "qwertyuiopasdfghjklzxcvbnmQWERTYUIOPASDFGHJKLZXCVBNM1234567890";
            const string TINY_URL = "http://tinyurl.com/";
            public string encode(string longUrl)
            {
                if (longUrl == null || longUrl.Length == 0)
                {
                    return string.Empty;
                }

                var strBuilder = new StringBuilder();
                var random = new Random();

                if (encodedDct.ContainsKey(longUrl))
                {
                    return encodedDct[longUrl];
                }

                for (int i = 0; i < 5; i++)
                {
                    strBuilder.Append(SYMBOLS[random.Next(0, 61)]);
                }

                encodedDct.Add(longUrl, string.Concat(TINY_URL, strBuilder));
                decodedDct.Add(string.Concat(TINY_URL, strBuilder), longUrl);

                return encodedDct[longUrl];
            }

            public string decode(string shortUrl)
            {
                return decodedDct[shortUrl];
            }
        }
    }
}
