using System;
using System.Collections.Generic;
using System.Linq;

namespace zad_4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            var result = new List<int>();
            for (int i = 0; i < nums.Count; i++)
            {
                if (nums[i]==Math.Pow(Math.Sqrt(nums[i]),2))
                {
                    result.Add(nums[i]);
                }
            }
            var output = result.OrderByDescending(x => x).ToList();
            Console.WriteLine(string.Join(" ",output));
        }
    }
}
