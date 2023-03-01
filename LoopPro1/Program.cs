using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program in C# Sharp to display the first 10 natural numbers.

namespace LoopPro1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i;
         
            

            Console.WriteLine("Following are the first natural");


            for(i=10; i <100; i++)
            {

                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
