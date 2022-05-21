using System;

namespace PrintLeaders
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 16, 17, 4, 3, 5, 2 };
            int n = arr.Length;

            PrintLeaders(arr, n);
        }

        public static void PrintLeaders(int[] arr, int n)
        {
            int max = arr[n - 1];
            if (n < 1)
                Console.WriteLine("Invalid Array!");
            else 
            {

                Console.WriteLine("Leaders are : " + max);
                for (int i = n - 2; i >= 0; i--)
                    if (max < arr[i])
                    {
                        max = arr[i];
                        Console.WriteLine("Leaders are : " + max);
                    }
            }
        }
    }
}
