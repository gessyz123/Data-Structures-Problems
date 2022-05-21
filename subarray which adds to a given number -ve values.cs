
using System;
using System.Collections.Generic;



public class GFG
{

    public static void subArraySum(int[] arr, int n, int sum)
    {
        
        int cur_sum = 0;
        int start = 0;
        int end = -1;
        Dictionary<int, int> dict = new Dictionary<int, int>();
        if(n <=1)
            Console.WriteLine("No subarray with given sum exists");

        for (int i = 0; i < n; i++)
        {
            cur_sum = cur_sum + arr[i];
            
            if (cur_sum - sum == 0)
            {
                start = 0;
                end = i;
                break;
            }
          
            if (dict.ContainsKey(cur_sum - sum))
            {
                start = dict[cur_sum - sum] + 1;
                end = i;
                break;
            }
            
            dict[cur_sum] = i;

        }
       
        if (end == -1)
        {
            Console.WriteLine("No subarray with given sum exists");
        }
        else
        {
            Console.WriteLine("Sum found between indexes " + start + " to " + end);
        }

    }

    public static void Main(string[] args)
    {
        int[] arr = new int[] { 1, 4, 0, 0, 3, 10, 5 };
        int n = arr.Length;
        int sum = 7;
        subArraySum(arr, n, sum);
    }

    }


 
