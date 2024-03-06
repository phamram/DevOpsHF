using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string example = "This is an example sentence.";

            Console.WriteLine("Elso karakter levagva minden szobol: " + RemoveFistChar(example));
            Console.WriteLine("Utolso karakter levagva minden szobol: " + RemoveLastChar(example));
        }

        static string RemoveFistChar(string input)
        {
            string[] words = input.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                if (!string.IsNullOrEmpty(words[i]))
                {
                    words[i] = words[i].Substring(1);
                }
            }
            return string.Join(" ", words);
        }

        static string RemoveLastChar(string input)
        {
            string[] words = input.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                if (!string.IsNullOrEmpty(words[i]))
                {
                    words[i] = words[i].Substring(0, words[i].Length - 1);
                }
            }
            return string.Join(" ", words);
        }

    }
}
