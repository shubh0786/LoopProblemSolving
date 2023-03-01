using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program in C# Sharp to read 10 numbers from keyboard and find their sum and average

namespace LoopPro4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int i, n, sum = 0;
            double avg;


            Console.Write("Please write ten numbers one by one");

            Console.WriteLine("Please enter ten numbers");

            for ( i = 1; i <=10; i++)
            {

                Console.Write("Number-{0} :", i);

                n= int.Parse(Console.ReadLine());

                sum += n;   

            }

            avg=sum/10.0;
            Console.Write("Following are the number sum : {0} and its average is {1}",sum,avg);

            Console.ReadLine();
        }
    }
}
