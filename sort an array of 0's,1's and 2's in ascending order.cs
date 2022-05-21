using System;

namespace sort0s1s2s
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] arr = { 0, 1, 2, 0, 1,2};
            int[] sorted = sort(arr);
            Console.WriteLine("Your sorted array is : !");
            for (int i = 0; i < arr.Length; i++)
                Console.WriteLine(arr[i]);

        }

        public static int [] sort(int[] arr)
        {
            int count0z = 0;
            int count1z = 0;
            int count2z = 0;
            int legnth = arr.Length;

            for (int i = 0; i < legnth; i++)
            {
                if (arr[i] == 0)
                    count0z++;
                else if (arr[i] == 1)
                    count1z++;
                if (arr[i] == 2)
                    count2z++;
            }

            //fill the array 

            for (int i = 0; i < legnth; i++)
            {
                if (count0z != 0)
                {

                    arr[i] = 0;
                    count0z--;
                }

                else
                {
                    if (count1z != 0)
                    {
                        arr[i] = 1;
                        count1z--;
                    }
                    else
                    {
                        arr[i] = 2;
                        count2z--;
                    }

                }

            }

            return arr;

        }
    }
}
