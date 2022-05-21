using System;

namespace Equilibrium
{
    class Program
    {
        static void Main(string[] args)


        {
            int[] arr = { -7, 1, 5, 2, -4, 3, 0 };
            int n = arr.Length;
            int result = BinarySearchEquilibrium(arr, n);
            if (result != -1)
                Console.WriteLine("The equilibrium is at index : " + result);
            else
                Console.WriteLine("No Equilibrium Found!");
     
        }

        public static int Equilibrium(int[] arr, int n)
        {
            int leftSum = 0;
            int rightsum = 0;
            int total = 0;


            for (int i = 0; i < n; i++)
                total += arr[i];


            for (int i = 1; i < n; i++)
            {

                leftSum += arr[i - 1];
                rightsum = total - arr[i] - leftSum;

                if (leftSum == rightsum)
              
                    return i;
               
            }

            return -1;

        }

        // Solve with binary search 

        public static int BinarySearchEquilibrium(int[] arr, int n)
        {
            int leftSum = 0;
            int rightsum = 0;
            int mid = n / 2;

            for (int i = 0; i < mid; i++)
            {
                leftSum += arr[i];
            }

            for (int i = n-1; i>mid; i--)
            {
                rightsum += arr[i];
            }

            if (rightsum > leftSum)
            {
                //we keep moving right until rightSum become equal or less than leftSum
                while (rightsum > leftSum && mid < n - 1)
                {
                    rightsum -= arr[mid + 1];
                    leftSum += arr[mid];
                    mid++;
                }
            }
            else
            {
                //we keep moving right until leftSum become equal or less than RightSum
                while (leftSum > rightsum && mid > 0)
                {
                    rightsum += arr[mid];
                    leftSum -= arr[mid - 1];
                    mid--;
                }
            }

            //check if both sum become equal
            if (rightsum == leftSum)
            {
      
                return mid;
            }

            return -1;

        }
    }
}
