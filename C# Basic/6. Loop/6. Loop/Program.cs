using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            //while
            int i = 0;
            while (i < 5)
            {
                Console.Write(i + " ");
                i++;
            }
            Console.WriteLine();
            ///For loop

            for (int j = 0; j < 5; j++)
            {
                Console.Write(j + " ");
            }
        }
    }
}
