using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop_4
{
    class Program
    {
        public static int count = 0;
        static void Main(string[] args)
        {
            //task 1
            //Console.WriteLine("Enter base: ");
            //int numBase = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter exponent: ");
            //int exp = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(Raise_1(numBase, exp));
            //count = 0;
            //Console.WriteLine(Raise_2(numBase, exp));
            //count = 0;
            //Console.WriteLine(Raise_3(numBase, exp));

            //task 2
            //int[] input = { -5, 6, 7, 8, 9, 10, 12, 13, 14, 23, 25, 26, 27, 44, 66, 78 };
            //Console.WriteLine("Enter a value to find");
            //int key = Convert.ToInt32(Console.ReadLine());
            //count = 0;
            //Console.WriteLine(BinarySearch(key, input, 0, input.Length));
            //count = 0;
            //Console.WriteLine(BinarySearch_R(key, input, 0, input.Length));

            //task 3
            Console.WriteLine("Enter n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(DigitSum(n));
            Console.WriteLine(DigitSum_R(n));

            Console.ReadLine();
        }

        static int Raise_1(int abase, int exp)
        {
            count = 0;
            int result = 1;
            int i;
            for (i = 1; i <= exp; i++)
            {
                result *= abase;
                count += 1;
            }
            Console.WriteLine("R1 count: {0}",count);
            return result;
        }

        static int Raise_2(int abase, int exp)
        {
            if (exp == 0)
            {
                Console.WriteLine("R2 count: {0}", count);
                return 1;
            }
            else
            {
                count += 1;
                return abase * Raise_2(abase, exp - 1);                
            }
        }

        static int Raise_3(int abase, int exp)
        {
            if (exp == 0)
            {
                Console.WriteLine("R3 count: {0}", count);
                return 1;
            }
            else
            {
                count += 1;
                int half = Raise_3(abase, exp / 2);
                if (exp % 2 == 0)
                {
                    return half * half;
                }
                else
                {
                    return abase * half * half;
                }
            }

        }        static int BinarySearch_R(int key, int[] array, int low, int high)
        {
            if (low > high) return -1;
            int mid = (low + high) / 2;
            if (key == array[mid])
            {
                Console.WriteLine("RCount: {0}", count);
                return mid;
            }
            if (key < array[mid])
            {
                count += 1;
                return BinarySearch_R(key, array, low, mid - 1);
            }
            else
            {
                count += 1;
                return BinarySearch_R(key, array, mid + 1, high);
            }
        }        static int BinarySearch(int K, int[] A, int L, int R)
        {
            int midpoint;
            while (L <= R)
            {
                count += 1;
                midpoint = (L + R) / 2;
                if (K == A[midpoint])
                {
                    Console.WriteLine("Count: {0}", count);
                    return midpoint;
                }
                else if (K > A[midpoint])
                {
                    L = midpoint + 1;
                }
                else
                {
                    R = midpoint - 1;
                }
            }
            return -1;
        }        static int DigitSum_R(int n)
        {
            
            if (n < 0)
            {
                return 0;
            }
            else
            {
                return (n%10) + DigitSum(n / 10);
            }
            
        }        static int DigitSum(int n)
        {
            int sum = 0;
            while (n > 0)
            {
                sum += n % 10;
                n = n / 10;
            }
            return sum;
        }
    }
}
