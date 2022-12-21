using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter first number");
            int first = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the last number");
            int last = int.Parse(Console.ReadLine());

            for (int i = first; i <= last; i++)
            {
                int flag = 1;

                for (int j = 2; j < i; ++j)
                {
                    if (i % j == 0)
                        flag = 0;
                    if (flag == 1)
                        Console.WriteLine(i);
                }




            }
            Console.ReadLine();
        }
    }
}