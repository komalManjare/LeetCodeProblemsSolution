using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    public class LongestSubStringWithoutDuplicate
    {
        public static void Get()
        {
            string s = "komalllaalli";
            int a_pointer = 0;
            int b_pointer = 0;
            int max = 0;
            HashSet<char> hash_set = new HashSet<char>();

            while (b_pointer < s.Length)
            {
                if (!hash_set.Contains(s[b_pointer]))
                {
                    hash_set.Add(s[b_pointer]);
                    b_pointer++;
                    max = Math.Max(hash_set.Count(), max);
                }
                else
                {
                    hash_set.Remove(s[a_pointer]);
                    a_pointer++;
                }
            }
            Console.WriteLine($"Length of longest substring {max}");
        }
    }
}
