using System;
using System.Collections.Generic;
using System.Linq;

namespace exe_7
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            string[] cmd = Console.ReadLine().Split();
            List<int> newList = new List<int>();
            while (cmd[0] != "end")
            {
                if (cmd[0] == "Contains")
                {
                    if (nums.Contains(int.Parse(cmd[1])))
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                    {
                        Console.WriteLine("No such number.");
                    }
                }
                else if (cmd[0] == "PrintEven")
                {
                    List<int> even = new List<int>();
                    for (int i = 0; i < nums.Count; i++)
                    {
                        if (nums[i] % 2 == 0)
                        {
                            even.Add(nums[i]);
                        }
                    }
                    Console.WriteLine(string.Join(" ",even));
                }
                else if (cmd[0] == "PrintOdd")
                {
                    List<int> odd = new List<int>();
                    for (int i = 0; i < nums.Count; i++)
                    {
                        if (nums[i] % 2 == 1)
                        {
                            odd.Add(nums[i]);
                        }
                    }
                    Console.WriteLine(string.Join(" ",odd));
                }
                else if (cmd[0] == "GetSum")
                {
                    Console.WriteLine(nums.Sum());
                }
                else
                {
                    List<int> n = new List<int>();
                    if (cmd[1] == "<")
                    {
                        for (int i = 0; i < nums.Count; i++)
                        {
                            if (nums[i] < int.Parse(cmd[2]))
                            {
                                n.Add(nums[i]);
                            }
                        }
                        Console.WriteLine(string.Join(" ", n));
                    }
                    else if (cmd[1] == ">")
                    {
                        for (int i = 0; i < nums.Count; i++)
                        {
                            if (nums[i] > int.Parse(cmd[2]))
                            {
                                n.Add(nums[i]);
                            }
                        }
                        Console.WriteLine(string.Join(" ", n));
                    }
                    else if (cmd[1] == ">=")
                    {
                        for (int i = 0; i < nums.Count; i++)
                        {
                            if (nums[i] >= int.Parse(cmd[2]))
                            {
                                n.Add(nums[i]);
                            }
                        }
                        Console.WriteLine(string.Join(" ", n));
                    }
                    else if (cmd[1] == "<=")
                    {
                        for (int i = 0; i < nums.Count; i++)
                        {
                            if (nums[i] <= int.Parse(cmd[2]))
                            {
                                n.Add(nums[i]);
                            }
                        }
                        Console.WriteLine(string.Join(" ", n));
                    }
                }
                    cmd = Console.ReadLine().Split();
            }
        }
    }
}
