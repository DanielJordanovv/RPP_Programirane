using System;
using System.Collections.Generic;
using System.Linq;

namespace zad_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(OptionsManager.CountLess100(arr));
            Console.WriteLine(OptionsManager.MaxNum(arr));
            OptionsManager.PrintEvensNumbers(arr);
            Console.WriteLine(OptionsManager.EvenSum(arr));
            Console.WriteLine(OptionsManager.EvenCount(arr));
            arr = OptionsManager.ReverseArr(arr);
            OptionsManager.PrintAll(arr);


        }
    }
}
