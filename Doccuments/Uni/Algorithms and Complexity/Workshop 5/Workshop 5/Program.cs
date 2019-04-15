using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sortArray = { 123, 34, 189, 56, 150, 12, 9, 240 };
            //bubbleSort(sortArray, 8);
            //InsertionSort(sortArray);
            MergeSort(sortArray);
            int[] sortArray2 = { 92, 471, -49, 340, 286, 406, 127, 352, 407, 78, 225, 499, 224, 83, 269, -103, 356, 137, -187, 317, 495, 82, 409, 345, 483, -108, 100, 296, 52, 19, 327, 272 };
            //bubbleSort(sortArray2, 32);
            //InsertionSort(sortArray2);
            MergeSort(sortArray2);

            Console.ReadLine();

        }

        static void bubbleSort(int[] a, int n)
        {
            int count = 0;
            int pass = 0;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - 1 - i; j++)
                {
                    if (a[j + 1] < a[j])
                    {
                        int temp = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = temp;
                    }
                    count++;
                }
                pass++;
                Console.WriteLine("Pass {0}:", pass);
                for (int k = 0; k < a.Length - 1; k++)
                {
                    Console.Write("{0}  ", a[k]);
                }
                Console.WriteLine();
            }
            for (int k = 0; k < a.Length-1; k++)
            {
                Console.Write("{0}  ",a[k]);
            }
            Console.WriteLine();
            Console.WriteLine("Number of operations: {0}",count);
            
        }

        static void InsertionSort(int[] data)
        // pre: 0 <= n <= data.length
        // post: values in data[0 … n-1] are in ascending order
        {
            int numSorted = 1; // number of values in place
            int index; // general index
            int n = data.Length-1;
            int count = 0;
            while (numSorted < n)
            {
                // take the first unsorted value
                int temp = data[numSorted];
                // … and insert it among the sorted
                // … and insert it among the sorted
                for (index = numSorted; index > 0; index--)
                {
                    if (temp < data[index - 1])
                    {
                        data[index] = data[index - 1];
                    }
                    else
                    {
                        break;
                    }
                    count++;
                }
                // reinsert value
                data[index] = temp;
                numSorted++;
            }
            for (int k = 0; k < data.Length - 1; k++)
            {
                Console.Write("{0}  ", data[k]);
            }
            Console.WriteLine();
            Console.WriteLine("Number of operations: {0}", count);
        }        static void Merge(int[] data, int[] temp, int low, int middle, int high)
        // pre: data[middle … high] are ascending
        // temp[low … middle-1] are ascending
        // post: data[low … high] contains all the values
        // in ascending order
        {
            int ri = low; // result index
            int ti = low; // temp index
            int di = middle; // destination index
                             // while two lists are not empty merge smaller //value
            while (ti < middle && di <= high)
            {
                if (data[di] < temp[ti])
                {
                    data[ri++] = data[di++];
                    // smaller is in high data
                }
                else
                {
                    data[ri++] = temp[ti++];// smaller is in temp
                }
            }
            //possibly some values left in temp array
            while (ti < middle)
            {
                data[ri++] = temp[ti++];
            }
            //… or some values left (in correct place) in data array
            
        }

        static void MergeSortRecursive(int[] data, int[] temp, int low, int high)
        // pre: 0 <= low <= high < data.length
        // post: values in data[low … high] are in ascending order
        {
            int n = high - low + 1;
            int middle = low + n / 2;
            int i;

            if (n < 2) return;
            // move lower half of data into temporary storage
            for (i = low; i < middle; i++)
            {
                temp[i] = data[i];
            }
            // sort lower half array
            MergeSortRecursive(temp, data, low, middle - 1);
            // sort upper half array
            MergeSortRecursive(data, temp, middle, high);
            // merge halves together
            Merge(data, temp, low, middle, high);
        }

        static void MergeSort(int[] data)
        // pre: 0 <= n <= data.length
        // post: values in data[0 … n-1] are in ascending order
        {
            int n = data.Length;
            int[] temp = new int[n];
            MergeSortRecursive(data, temp, 0, n - 1);
            for (int k = 0; k < data.Length - 1; k++)
            {
                Console.Write("{0}  ", data[k]);
            }
        }
    }
}
