using System;

namespace ConsoleApp1
{
    public class WavePatternForMatrix
    {
        public static void Get()
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
