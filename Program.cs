using System;

namespace ConsoleApp17_HourGlassProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[][] arr = new int[6][];

            //for (int i = 0; i < 6; i++)
            //{
            //    arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            //}


            //matrix 5 x 5
            int[,] mat = {
                       {1, 2, 3, 0, 0},
                       {0, 0, 0, 0, 0},
                       {2, 1, 4, 0, 0},
                       {0, 0, 0, 0, 0},
                       {1, 1, 0, 1, 0}
            };

            //o/p: 13
            //1, 2, 3
            //   0, 
            //2, 1, 4

            //matrix 6 x 6
            int[,] mat1 = {
            { 1, 1, 1, 0, 0, 0},
            { 0, 1, 0, 0, 0, 0},
            { 1, 1, 1, 0, 0, 0},
            { 0, 0, 2, 4, 4, 0},
            { 0, 0, 0, 2, 0, 0},
            { 0, 0, 1, 2, 4, 0}
            };

            //o/p: 19
            //2, 4, 4
            //   2, 
            //1, 2, 4

            int res = findMaxSum(mat1);
            if (res == -1)
                Console.WriteLine("Not possible");
            else
                Console.WriteLine("Maximum sum of hour glass = "
                                   + res);

            //https://www.geeksforgeeks.org/maximum-sum-hour-glass-matrix/
        }

        private static int findMaxSum(int[,] mat)
        {
            int R = mat.GetLength(0);
            int C = mat.GetLength(1);

            if (R < 3 || C < 3)
                return -1;

            int max_sum = 0;

            for (int i = 0; i < R - 2; i++)
            {
                for (int j = 0; j < C - 2; j++)
                {
                    int sum = (mat[i, j] + mat[i, j + 1] + mat[i, j + 2]) +
                        (mat[i + 1, j + 1]) +
                        (mat[i + 2, j] + mat[i + 2, j + 1] + mat[i + 2, j + 2]);

                    max_sum = Math.Max(max_sum, sum);
                }
            }

            return max_sum;
        }


        static int hourglassSum(int[][] arr)
        {
            int R = 6;//arr.GetLength(0); // hacker Rank throws indexoutofrange exception so hard coded here
            int C = 6;//arr.GetLength(1);  // hacker Rank throws indexoutofrange exception so hard coded here
            if (R < 3 || C < 3)
                return -1;
            int max_sum = 0;

            for (int i = 0; i < R - 2; i++)
            {
                for (int j = 0; j < C - 2; j++)
                {
                    int sum = (arr[i][j] + arr[i][j + 1] + arr[i][j + 2]) +
                        (arr[i + 1][j + 1]) +
                        (arr[i + 2][j] + arr[i + 2][j + 1] + arr[i + 2][j + 2]);

                    max_sum = Math.Max(max_sum, sum);
                }
            }

            return max_sum;
        }
    }
}
