using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User_Input
{
    class Program
    {
        static void Main(string[] args)

        {

            //readLine returns only the string so we need to TypeCast to Use it in another format

            //String Format //

            Console.WriteLine("Name : ");
            var name = Console.ReadLine();
            Console.WriteLine("ID : ");
            var Id = Console.ReadLine();

            var def_name = "asif";
            var def_id = "20-42212-1";

            if (name == def_name && Id == def_id)
            {

                //ReadLine Use for Operation (TypeCasting needed)

                Console.WriteLine("First Number :  ");
                int number1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Second Number : ");
                int number2 = Convert.ToInt32(Console.ReadLine());

                if (number1 > number2)
                {
                    Console.WriteLine(number1 + " is bigger than " + number2);
                }
                else
                {
                    Console.WriteLine(number2 + " is bigger than " + number1);
                }
            }
            else
            {
                Console.WriteLine("Unothorised person detected ");
            }

        }
    }
}
