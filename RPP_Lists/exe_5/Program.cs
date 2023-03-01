using System;
using System.Collections.Generic;
using System.Linq;

namespace exe_5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> inputList = Console.ReadLine().Split().Select(int.Parse).ToList();
            string input = Console.ReadLine();
            while (true)
            {
                if (input == "print")
                {
                    break;
                }
                string[] commandsArr = input.Split();
                string command = commandsArr[0];
                if (command == "add")
                {
                    int index = int.Parse(commandsArr[1]);
                    int num = int.Parse(commandsArr[2]);
                    inputList.Insert(index, num);
                }
                else if (command == "addMany")
                {
                    List<int> elementsToAdd = new List<int>();
                    for (int i = 2; i < commandsArr.Length; i++)
                    {
                        elementsToAdd.Add(int.Parse(commandsArr[i]));
                    }
                    inputList.InsertRange(int.Parse(commandsArr[1]), elementsToAdd);
                }
                else if (command == "contains")
                {
                    int num = int.Parse(commandsArr[1]);

                    if (inputList.Contains(num))
                    {
                        for (int i = 0; i < inputList.Count; i++)
                        {
                            if (inputList[i] == num)
                            {
                                Console.WriteLine(i);
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine(-1);
                    }
                }
                else if (command == "remove")
                {
                    int index = int.Parse(commandsArr[1]);
                    inputList.RemoveAt(index);
                }
                else if (command == "shift")
                {
                    int rotations = int.Parse(commandsArr[1]);
                    for (int i = 0; i < rotations; i++)
                    {
                        ShiftElements(inputList);
                    }
                }
                else if (command == "sumPairs")
                {
                    for (int i = 0; i < inputList.Count - 1; i++)
                    {
                        inputList[i] += inputList[i + 1];
                        inputList.RemoveAt(i + 1);
                    }
                }
                input = Console.ReadLine();
            }
            Console.WriteLine("[" + string.Join(", ", inputList) + "]");
        }
        static void ShiftElements(List<int> inputList)
        {
            int[] array = new int[inputList.Count];
            array[array.Length - 1] = inputList[0];
            for (int i = array.Length - 2; i >= 0; i--)
            {
                array[i] = inputList[i + 1];
            }
            for (int i = 0; i < array.Length; i++)
            {
                inputList[i] = array[i];
            }
        }
    }
}
