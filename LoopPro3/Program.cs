using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program in C# Sharp to display n terms of natural number and their sum

namespace LoopPro3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int sum = 0;

            Console.WriteLine("Please enter your prefered number");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("your number is {0}", n);


            for (int i=0; i<=n; i++)
            {

                Console.WriteLine("First n numbers are {0}", i);

                sum+= i;

             
            }

            Console.WriteLine("sum of n number upto {0} terms : = {1}", n, sum);

            Console.ReadLine();
        }
    }
}
