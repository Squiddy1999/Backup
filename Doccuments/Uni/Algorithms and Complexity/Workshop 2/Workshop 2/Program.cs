using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop_2
{
    class Program
    {
        static void Main(string[] args)
        {

            //Task 1 - O(n)
            //Console.WriteLine("Enter a value for n");
            //int n = Convert.ToInt32(Console.ReadLine());
            //for(int i=0; i<=1.5*n; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //for (int i = n; i >= 1; i--)
            //{
            //    Console.WriteLine(i);
            //}


            //Task 2 - O(n)
            //Console.WriteLine("Enter a value for n");
            //int n = Convert.ToInt32(Console.ReadLine());
            //int count = 0;
            //for (int i = 2; i <= n; i++)
            //{
            //    int jLoop = 0;
            //    for(int j = 0; j <= n;)
            //    {
            //        Console.WriteLine(Convert.ToString(i) + ", " + Convert.ToString(j));
            //        j = j + (n / 4);
            //        count += 1;
            //        Console.WriteLine(count);
            //        jLoop += 1;
            //    }
            //    Console.WriteLine(Convert.ToString(jLoop) + "....!");
            //}

            //Console.WriteLine("Algorithm ran for {0} iterations", count);


            //Task 3 - O(n)
            //Console.WriteLine("Enter a value for n");
            //int number = Convert.ToInt32(Console.ReadLine());
            //int[] numbers = { 0, 2, 5, 3, 7, 8 };
            //int add_them(int n, int[] A)
            //{
            //    int count = 0;
            //    int j = 0;
            //    for(int i = 1; i<=n; i++)
            //    {
            //        j = j + A[i];
            //        count += 1;
            //    }
            //    Console.WriteLine("Count after loop 1: {0}", count);
            //    int k = 1;
            //    for(int i = 1; i <=n; i++)
            //    {
            //        k = k + k;
            //        Console.WriteLine(k);
            //        count += 1;
            //    }
            //    Console.WriteLine("Count after loop 2: {0}", count);
            //    return j+k;
            //}
            //Console.WriteLine(add_them(number, numbers));


            //Task 3 - Simplified
            Console.WriteLine("Enter a value for n");
            int number = Convert.ToInt32(Console.ReadLine());
            int[] numbers = { 0, 2, 5, 3, 7, 8 };
            int add_them(int n, int[] A)
            {
                int count = 0;
                int j = 0;
                for (int i = 1; i <= n; i++)
                {
                    j = j + A[i];
                    count += 1;
                }
                Console.WriteLine("Count after loop 1: {0}", count);
                
                return j + Convert.ToInt32(Math.Pow(2,Convert.ToDouble(n)));
            }
            Console.WriteLine(add_them(number, numbers));
            Console.ReadLine();


        }
    }
}
