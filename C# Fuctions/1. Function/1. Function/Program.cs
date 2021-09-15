using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Function
{
    class Program
    {
        static void  def(string s)
        {
            Console.WriteLine(s);
        }

        static void def_parameter(string s="default")
        {
            Console.WriteLine(s);
        }

        // key:value pair argument

        static void keyVal_arg(string arg1, string arg2, string arg3)
        {
            Console.WriteLine(arg1+" and "+arg2+" are friennds "); //Angela rayed are friends
        }

        static void KeyValArg(string arg1="Asif",string arg2="Prottoy",string arg3="Ovy")
        {
            Console.WriteLine(arg1 + " kikced " + arg2 + " Ass ");
        }

        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            def(s); // return string 

            def_parameter("Asif"); //return Asif
            def_parameter("Prottoy"); // return Prottoy
            def_parameter(); // return default

            keyVal_arg(arg1: "Angela", arg2: "Rayed", arg3: "Alif");
            KeyValArg();

        }
    }
}
