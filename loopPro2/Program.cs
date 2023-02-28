using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Write a C# Sharp program to find the sum of first 10 natural numbers. 

namespace loopPro2
{
    internal class Program
    {
        static void Main(string[] args)
        {


            int i, sum = 0;

            for ( i = 1; i <=10; i++)
            {

                sum = sum + i;
                Console.WriteLine("{0}",i);


     
            }
            Console.WriteLine("\n The Sum is : {0}\n", sum);

            Console.ReadLine();
        }

    }
}
