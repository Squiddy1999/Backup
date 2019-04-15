using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task 1 - O(n)
            //Console.WriteLine("Enter a value for n");
            //int n = Convert.ToInt32(Console.ReadLine());
            //int j = 1;
            //int count = 0;
            //while (j <= n)
            //{
            //    int i = 1;
            //    while (i <= j)
            //    {
            //        Console.WriteLine("J:{0}, I:{1}", j, i);
            //        i++;
            //        count++;
            //    }
            //    j++;
            //}
            //Console.WriteLine("Iterations: {0}",count);


            //Task 2 - O(n^2)
            Console.WriteLine("Enter a value for n");
            //int n = Convert.ToInt32(Console.ReadLine());
            for (int n = 2; n < 16; n +=2)
            {
                int count = 0;
                for (int i = 1; i <= n; i++)
                {
                    int j = n;
                    while (j >= 1)
                    {
                        Console.WriteLine("I:{0}, J:{1}", i, j);
                        j = j / 2;
                        count++;
                    }
                }
                Console.WriteLine("Iterations: {0}", count);
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
