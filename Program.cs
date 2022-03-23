using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //WavePatternForMatrix();
            //SnakePatternForMatrix();
            //LengthOflongestSubstring();

        }
        public static void LengthOflongestSubstring()
        {
            string s = "testLongggsubbbbstr";
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

        static void SnakePatternForMatrix()
        {
            int[,] mat = {
                            { 10, 20, 30, 40 },
                            { 15, 25, 35, 45 },
                            { 27, 29, 37, 48 },
                            { 32, 33, 39, 50 }
                          };

            // to get number of rows in matrix use  mat.GetLength(0)
            // Traverse through all rows
            for (int i = 0; i < mat.GetLength(0); i++)
            {

                // If current row is even, print from left to right
                if (i % 2 == 0)
                {
                    for (int j = 0; j < mat.GetLength(1); j++)
                        Console.Write(mat[i, j] + " ");

                    // If current row is odd, print from right to left
                }
                else
                {
                    for (int j = mat.GetLength(1) - 1; j >= 0; j--)
                        Console.Write(mat[i, j] + " ");
                }
            }
            Console.ReadLine();
        }
        static void WavePatternForMatrix()
        {
            int[,] mat = {
                            { 1, 8, 9, 16},
                            { 2, 7, 10, 15 },
                            { 3, 6, 11, 14 },
                            { 4, 5, 12, 13 }
            };

            // to get number of rows in matrix use  mat.GetLength(0)
            // Traverse through all rows
            for (int i = 0; i < mat.GetLength(0); i++)
            {

                // If current row is even, print from top to bottom
                if (i % 2 == 0)
                {
                    for (int j = 0; j < mat.GetLength(1); j++)
                        Console.Write(mat[j, i] + " ");

                    // If current row is odd, print from bottom to top
                }
                else
                {
                    for (int j = mat.GetLength(1) - 1; j >= 0; j--)
                        Console.Write(mat[j, i] + " ");
                }
            }
            Console.ReadLine();
        }
    }
}
