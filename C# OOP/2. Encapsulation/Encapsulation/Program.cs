using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    //encapsulated class//
    class test
    {
        private string name = "Asif Zaman";
        public int age = 20;
        protected string institute = "AIUB";
    }

    //derived class//
    class derived:test
    {
        void display()
        {
            Console.WriteLine("Institute name : "+institute);// accessible from derived class //
            Console.WriteLine("CGPA : " + cgpa); 
        }
    }


    class Program
    { 
        static void Main(string[] args)
        {
            test t = new test();
            Console.WriteLine("Name : "+t.name);//non accessible//
            Console.WriteLine("Age : "+t.age); //accessible
        }
    }
}
