using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace  Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = 12;
            Console.WriteLine(num);
            num = 13;
            Console.WriteLine(num); //changed


            //Const,Var-----> Same as JS (Const doesnt change)

            /* const num1= 24;
             Console.WriteLine(num1);
             const num1= 25; 
             Console.WriteLine(num1);

             This will show the error in the code 
            */

            char character = 'E';
            Console.WriteLine(character + " Is the first letter of my name"); //String concat

            string name = "Asif Zaman";
            Console.WriteLine(name);


            //calculation (int,float,double,long)

            int num1 = 12;
            float num2 = 12.78F;   //F after the float
            double num3 = 12.5656565D; // D after the double 
            long num4 = 21214124213433L; // L after the Long 

            double result = num1 + num2 + num3 + num4;

            Console.WriteLine("Sum : "+result);


            // Boolean
            var number1 = 4;
            var number2 = 5;
            bool set_bool = false;

            if(number1<number2)
            {
                set_bool = true;
            }
            else
            {
                set_bool = false;
            }
            Console.WriteLine(set_bool);  // return true in console







            


  
        }
    }
}
