using System;
using System.Linq;

namespace TheMissingNumber
{
    class Program
    {
        static void Main()
        {
            int[] arr = { 3, 5, 8, 1, 2, 9, 6, 4, 7 };
            int n = arr.Length+1;
            Console.WriteLine("The Missing Number is :  "+ MissingNumber(arr,n));
            
        }

        public static int MissingNumber(int[] arr, int n )
        {
            int CurrentSum = 0;
            int ExpectedSum = 1;
            int Missing = 0;

            for (int i =2; i <(n+1); i++)
            {
                ExpectedSum += i;
                CurrentSum += arr[i-2];
                
            }
          
            Missing = ExpectedSum - CurrentSum;
            return Missing;
        }
    }


}
