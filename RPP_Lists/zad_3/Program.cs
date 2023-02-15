using System;
using System.Collections.Generic;
using System.Linq;

namespace zad_3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> nums = Console.ReadLine().Split('|').ToList();
            nums.Reverse();
            List<string> final = new List<string>();

            for (int i = 0; i < nums.Count; i++)
            {
                List<string> arr = nums[i].Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();
                foreach (string num in arr)
                {
                    final.Add(num);
                }
            }
            Console.WriteLine(string.Join(" ", final));
        }
    }
}
