using System;
using System.Collections.Generic;
using System.Linq;

namespace NumbersFrequency
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 2, 5, 5, 8, 5, 6, 8, 8 };
            int n = arr.Length;
            List<int> finalList = PrintNumbersFrequency(arr, n);
            Console.Write("Final List is : ");
            foreach(var item in finalList)
                Console.Write(item+" ");
        }

        public static List<int> PrintNumbersFrequency(int[] arr, int n)
        {
            Dictionary<int, int> CountFrequency = new Dictionary<int, int>();
            Dictionary<int, int> Index = new Dictionary<int, int>();
            List<int> finalList = new List<int>();

            

            for (int i = 0; i < n; i++)
            {
                if (CountFrequency.ContainsKey(arr[i]))
                    CountFrequency[arr[i]]++;
                else
                {
                    CountFrequency.Add(arr[i], 1);
                    Index.Add(arr[i], i);
                }
            }

            var sortedList = from item in CountFrequency orderby item.Value descending select item;
            int count = 0;
            foreach (var item in sortedList)
            {
                while (count < CountFrequency[item.Key])
                {
                    finalList.Add(item.Key);
                    count++;
                }
                count = 0;
            }
            return finalList;

        }
    }
}
