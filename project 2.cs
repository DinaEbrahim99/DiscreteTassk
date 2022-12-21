using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, j, sum;
            Console.WriteLine("enter the first number");
            int first = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the last number");
            int last = int.Parse(Console.ReadLine());
            for (i = first; i<= last; i++)
            {
                  sum = 0;
                for (j = 1; j < i; j++)
                {
                    if (i % j == 0)
                        sum += j;
                }
                if (sum == i)
                    Console.WriteLine(i);

            }
            Console.ReadKey();
            
            
               
                   
            
            
            








        }
    }
}
