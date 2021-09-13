using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Switch_Case
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = Convert.ToInt32(Console.ReadLine());
            
            switch(number)
            {
                case 1:
                    Console.WriteLine("4 is excellent");
                    break;
                case 2:
                    Console.WriteLine("3.90 is very good");
                    break;
                case 3:
                    Console.WriteLine("3.85 is pretty much good");
                    break;
                case 4:
                    Console.WriteLine("Above 3.80 is quite good");
                    break;
                case 5:
                    Console.WriteLine("Above 3.75 is good");
                    break;
                case 6:
                    Console.WriteLine("Above 3.70 is average");
                    break;
                case 7:
                    Console.WriteLine("Above 3.60 is below average");
                    break;
                case 8:
                    Console.WriteLine("Above 3.50 is  try more");
                    break;
                case 9:
                    Console.WriteLine("Above 3.40 is not good");
                    break;
            }
        }
    }
}
