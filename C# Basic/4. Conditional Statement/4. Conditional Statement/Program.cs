using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Conditional_Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            var angela_cg = 4.00;
            var rayed_cg = 2.00;
            var asif_cg = 2.00;
            var alif_cg = 2.00;

            if(asif_cg+rayed_cg>angela_cg)
            {
                Console.WriteLine("Angela Noob");
            }
            else if(asif_cg+alif_cg+rayed_cg>angela_cg)
            {
                Console.WriteLine("We 3 are Noobs. Angela Pro");
            }
            else
            {
                Console.WriteLine("All cindition fails");
            }


            /*
            Using ternary Operator--> 

            variable = (condition) ? expressionTrue :  expressionFalse;

            num1=12;
            num2=32;

            String decition= (num1>num2) ? "num2 is bigger": "num1 is bigger";
            
             */



        }
    }
}
