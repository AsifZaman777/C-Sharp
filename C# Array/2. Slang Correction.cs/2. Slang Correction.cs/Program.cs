using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Slang_Correction.cs
{
    class Program

    {
        static public string slang(string s)
        {
            //collection of slangs
            string[] slang_collection = { "bitch","fuck","sex","vixen","imbecile"};
            string safe_string="";
            for (int i=0;i<slang_collection.Length;i++)
            {
                //search the slangs in the sentence.

                if(s.Contains(slang_collection[i]))
                {
                    safe_string = s.Replace((slang_collection[i]), "*");
                    return safe_string;
                }
               
                else
                {
                    safe_string = s;
                }
               
            }
            return safe_string;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Please insert your String hear : ");
            string input_string = Console.ReadLine();

            Console.WriteLine(slang(input_string.ToLower()));
        }
    }
}
