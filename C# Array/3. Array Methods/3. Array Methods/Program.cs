using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Array_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = { "tamim", "prottoy", "jubayer", "mim", "ovy", "angela", "rayed" };
            int []number_arr = { 2, 4, 5, 67, 4, 0 };

            //sorting method//

            Array.Sort(array);
            foreach(string s in array)
            {
                Console.WriteLine(s);
            }

            //Some Useful Methods//
             
            Console.WriteLine("Max : " + array.Max()); //tamim returned
            Console.WriteLine("Min : " + array.Min()); //angela returned
            Console.WriteLine("Sum : " + number_arr.Sum()); //sum returned
            
        }
    }
}
