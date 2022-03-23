using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    public class MajorityElementInArray
    {
        public static void Get()
        {
            int[] arr = { 2, 1, 1, 2, 1, 2, 1, 3, 4, 5, 6, 1 };
            Dictionary<int, int> dictElement = new Dictionary<int, int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (dictElement.ContainsKey(arr[i]))
                {
                    int count = dictElement[arr[i]] + 1;
                    if (count > arr.Length / 2)
                    {
                        Console.WriteLine($"Majority found :- { arr[i]}");
                        return;
                    }
                    else
                    {
                        dictElement[arr[i]] = count;
                    }
                }
                else
                    dictElement.Add(arr[i], 1);
            }
            var keyOfMaxValue = dictElement.Aggregate((x, y) => x.Value > y.Value ? x : y).Key; // "a"
            Console.WriteLine($"Majority found :- {keyOfMaxValue}");
            return;
        }
    }
}
