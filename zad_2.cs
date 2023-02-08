using System;
using System.Collections.Generic;
using System.Linq;

namespace zad_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string [] arr = Console.ReadLine().Split();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string [] cmd = Console.ReadLine().Split();
                if (cmd[0]== "Reverse")
                {
                   arr =  arr.Reverse().ToArray();
                }
                else if (cmd[0]== "Distinct")
                {
                    arr = arr.Distinct().ToArray();
                }
                else if (cmd[0] == "Replace")
                {
                    arr[int.Parse(cmd[1])] = cmd[2];

                }
                else if (cmd[0] == "Print")
                {
                    Console.WriteLine(string.Join(" ",arr.Where(x=>x.StartsWith(cmd[1]))));
                }
            }
            Console.WriteLine(string.Join(", ",arr));

        }
    }
}
