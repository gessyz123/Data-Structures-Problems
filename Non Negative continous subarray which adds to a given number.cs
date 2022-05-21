using System;

namespace SubArrayAndSum
{
    class Program
    {
        static void Main()
        {
            int[] arr = { 1,2,3,4};
            int sum = 10;
            SubarraySum(arr, sum);

        }
        public static int SubarraySum(int[] arr, int sum)
        {
          
            int curr_sum = arr[0];
           // define a start pointer that will keep the index of the first element in the subarray that maked the sum the same as the target sum 
           // define an end pointer that will take the last index that makes up the target sum
            int start = 0;
            int end = 0;

            for (int i = 1; i <= arr.Length; i++)
            {
              
                while (curr_sum > sum && start < i - 1)
                {
                    curr_sum = curr_sum - arr[start];
                    start++;
                }

               
                if (curr_sum == sum)
                {
                    end = i - 1;
                    Console.WriteLine("Sum found between "
                                      + "indexes " + start + " and " + end);
                    return 1;
                }

                    curr_sum = curr_sum + arr[i];
            }
            Console.WriteLine("No subarray found");
            return 0;
        }
    }
}
