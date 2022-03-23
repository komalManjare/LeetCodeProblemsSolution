using System;

namespace ConsoleApp1
{
    public class SnakePatternForMatrix
    {
        public static void Get()
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
    }
}
