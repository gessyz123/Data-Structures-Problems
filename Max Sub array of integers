using System;

namespace max_subarray
{
    class Program
    {
        static void Main()
        {

            int[] arr = { -2, - 3, 4, -1, -2, 1, 5, -3 };
            int total = MaxSubArray(arr);
            Console.WriteLine("The maximum sum is : "+ total);
        }


        public static int MaxSubArray(int[] nums)
        {
            int max = int.MinValue; // initialize the max to the most minimum value in case the array has negatives 
            int current_max = nums[0]; // set the current max to the first element 

            for (int i = 1; i < nums.Length; i++)
            {
                current_max += nums[i];
                if (current_max < nums[i])
                    current_max = nums[i];

                if (max < current_max)
                    max = current_max;
            }
            return max;
        }
    }

}
