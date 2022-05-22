using System;
using System.Collections.Generic;

namespace SpiralOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = {{1, 2,   3,   4},
                          {5,  6,   7,   8},
                          {9,  10,  11,  12},
                          {13,  14,  15,  16 }
                         };
            PrintSpiralOrder(arr, arr.GetLength(0), arr.GetLength(1));
        }
        public static void PrintSpiralOrder(int[,] arr, int x, int y )
        {
            //x is the legnth of the array ( first dimension ) 
            //y is the length of the array ( second dimension)

            int rows_start = 0;// rows start pointer
            int rows_end = x-1; // rows end pointer start 
            int cols_start = 0; // columns start pointer
            int cols_end = y-1; // columns end pointer
            int flag = 0; // refers to the direction of iterating the matrix 
                          // 0 = iterating the columns  forward from left to right ( the upper side of the matrix)
                          // 1= iterating the rows downward from top to buttom ( the right side of the matrix)
                          // 2 = iterating the columns backward from right to left ( the bottom side fof the matrix)
                          // 3= iterating the rows up from bottom to up  ( the most left side of the matrix )


            while (rows_start <= rows_end && cols_start<=cols_end)
            {
                if (flag == 0)
                {
                    for (int i = rows_start; i <=  cols_end; i++)
                        Console.Write(arr[rows_start, i]+" ");
                    rows_start++;
                    flag++;

                }
                if (flag == 1)
                {
                    for (int i = rows_start; i <= cols_end; i++)
                        Console.Write(arr[i, cols_end] + " ");
                    cols_end--;
                    flag++;

                }
                if (flag == 2)
                {
                    for (int i = cols_end; i >= cols_start; i--)
                        Console.Write(arr[rows_end, i]+" ");
                    rows_end--;
                    flag++;
                }
                if (flag == 3)
                {
                    for (int i = rows_end; i >= rows_start; i--)
                        Console.Write(arr[i, cols_start] + " ");
                    cols_start++;
                    flag = 0;
                }


            }
        

        }

       


    }
}
