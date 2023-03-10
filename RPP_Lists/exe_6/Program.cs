using System;
using System.Collections.Generic;
using System.Linq;

namespace exe_6
{
    class Program
    {
        static void Main(string[] args)
        {
            //input : Learn programming at CodeCamp: Java, PHP, JS, HTML 5, CSS, Web, C#, SQL, databases, AJAX, etc.
            // if(char.IsDigit(char.Parse(words[i])) || words[i].Contains(separators[i])|| words[i] == words[i])
            string[] separators = new string[] { ",", ";", ":", ".", "!", "(", ")", "\"", "\'", "\\", "/", "[", "]", " " };
            List<string> words = Console.ReadLine().Split(separators, StringSplitOptions.RemoveEmptyEntries).ToList();
            List<string> lc = new List<string>();
            List<string> uc = new List<string>();
            List<string> mix = new List<string>();
            for (int i = 0; i < words.Count; i++)
            {
                if (words[i].First() == words[i].ToLower().First() && words[i].All(x=>char.IsLetter(x)))
                {
                    lc.Add(words[i]);
                }
                else if (words[i] == words[i].ToUpper() && words[i].All(x => char.IsLetter(x)))
                {
                    uc.Add(words[i]);
                }
                else 
                {
                    mix.Add(words[i]);
                }
            }
            Console.WriteLine("Lower-case: " + string.Join(", ", lc));
            Console.WriteLine("Mixed-case: " + string.Join(", ", mix));
            Console.WriteLine("Upper-case: " + string.Join(", ", uc));

        }
    }
}
