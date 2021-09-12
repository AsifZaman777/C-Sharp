using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeCasting
{
    class Program
    {
        static void Main(string[] args)
        {
            // Implicit TC (char-> int -> float -> long -> double)

            int number1 = 12;
            double number2 = number1;

            Console.WriteLine(number2);

            // Explicit TC  (Move Left of Implict TC)

            double dblNumber = 7.89;
            int conv_dbl = (int)dblNumber;  //Conventional way

            Console.WriteLine(conv_dbl);

            // Explicit TC using Covert.To 

            double number4 = 45.90;
            int conv_number4 = Convert.ToInt32(number4);

            Console.WriteLine(conv_number4); //Converted into Integer

            



            /*
             Convert.ToInt() --> TC in Int
             Convert.ToDouble() --> TC in Double
             Convert.ToString() --> TC in String

             */

        }
    }
}
