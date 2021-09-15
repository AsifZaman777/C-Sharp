using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Array_cs
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = {"Tamim","Protty","Ovy","Rayed","Angela"};
            //for loop//
            for(int i=0;i<arr.Length;i++)
            {
                Console.WriteLine(arr[i]); 
            }

            //for each loop


            /* foreach (type variableName in arrayName)
             {
                 // code block to be executed
             } */


            Console.WriteLine("");

            foreach (string i in arr)
            {
                display(i);
            }

            void display(string s)
            {
                Console.WriteLine("First Letter is : "+s[0]);  // work individually 
            }
            
            //but it can be done with for loop by two dim array...
   
        }
    }
}
