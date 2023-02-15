using System;
using System.Collections.Generic;
using System.Linq;

namespace zad_1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            int last = nums.Last();
            for (int i = 0; i < nums.Count; i++)
            {
                if (last == nums[i])
                {
                    nums.Remove(nums[i]);
                }
            }
            Console.WriteLine(string.Join(" ",nums));

        }
    }
}
