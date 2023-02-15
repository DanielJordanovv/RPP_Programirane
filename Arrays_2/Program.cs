using System;
using System.Collections.Generic;
using System.Linq;

namespace zad_2
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] arr = Console.ReadLine().Split();
            string[] cmd = Console.ReadLine().Split();
            while (cmd[0] != "END")
            {
                if (cmd[0] == "Reverse")
                {
                    arr = arr.Reverse().ToArray();
                }
                else if (cmd[0] == "Distinct")
                {
                    arr = arr.Distinct().ToArray();
                }
                else if (cmd[0] == "Replace")
                {

                    if (arr.Length - 1 < int.Parse(cmd[1]) || int.Parse(cmd[1]) < 0)
                    {
                        Console.WriteLine("Invalid input!");
                    }
                    else
                    {
                        arr[int.Parse(cmd[1])] = cmd[2];
                    }

                }
                else if (cmd[0] == "Print")
                {
                    Console.WriteLine(string.Join(" ", arr.Where(x => x.StartsWith(cmd[1]))));
                }
                else
                {
                    Console.WriteLine("Invalid command!");
                }
                cmd = Console.ReadLine().Split();
            }
            Console.WriteLine(string.Join(", ", arr));
        }
    }
}
