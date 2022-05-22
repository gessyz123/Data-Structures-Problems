using System;

namespace TheKthElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 12, 3, 5,7, 19 };
            int k = 3;
            Console.Write("K'th smallest element"
                          + " is " + FindKthElement(arr, k));
        }

        public static int FindKthElement(int []arr, int k )
        {
            Array.Sort(arr);

            return (arr[k - 1]);

        }
    }
}
