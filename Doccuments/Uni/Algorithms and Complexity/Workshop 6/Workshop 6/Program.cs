using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray_1 = { -45, -91, -81, 65, 39, -37, 90, -94};
            int[] myArray_2 = {-12, -24, 53, 59, -63, -2, -11, 29, 42, 51, -45, 36, 31, -68, -77, 0, 92, -32, 17, -56, 51, -49, 1, 40, 79, 92, 9, -73, -70, -49, 68, -9};
            double[] myArray_3 = {25.1573, 5.1437, 8.1421, 3.1625, 12.3187, 2.8465, 78.0454, -32.6666, -51.9204, -31.9391, -30.6136, -12.1411, -4.7172, -6.1189, 15.1574, 10.8995, 21.0344, 49.7912};
            double[] myArray_4 = {-56.6149, -27.4997, 17.1503, -1.5368, -31.3245, -17.5386, 6.9865, -27.8045, 27.2986, -17.9399, 50.6482, -30.2363, 5.5773, -42.5887, -20.2617, -16.6110, 11.2374, 26.3797, 8.4136, -10.4460, 22.8337, 22.3688, 3.3657, 15.9949, 11.5583, -27.6349, 21.2679, -18.4016, -16.9097, 4.9545, -8.6101, -3.6910};

            //printArray(myArray_1);
            //QuickSort(myArray_1);
            //printArray(myArray_1);
            //Console.WriteLine();
            //printArray(myArray_2);
            //QuickSort(myArray_2);
            //printArray(myArray_2);
            //Console.WriteLine();
            //printArray(myArray_3);
            //QuickSort(myArray_3);
            //printArray(myArray_3);
            //Console.WriteLine();
            //printArray(myArray_4);
            //QuickSort(myArray_4);
            //printArray(myArray_4);

            printArray(myArray_1);
            HeapSort(myArray_1);
            printArray(myArray_1);
            Console.WriteLine();
            printArray(myArray_2);
            HeapSort(myArray_2);
            printArray(myArray_2);
            Console.WriteLine();
            printArray(myArray_3);
            HeapSort(myArray_3);
            printArray(myArray_3);
            Console.WriteLine();
            printArray(myArray_4);
            HeapSort(myArray_4);
            printArray(myArray_4);
            Console.WriteLine();

            Console.ReadLine();
        }

        public static void printArray(int[] data)
        {
            for (int i = 0; i<data.Length-2; i++)
            {
                Console.Write("{0}, ", data[i]);
            }
            Console.Write(data[data.Length-1]);
            Console.WriteLine();
        }

        public static void printArray(double[] data)
        {
            for (int i = 0; i < data.Length - 2; i++)
            {
                Console.Write("{0}, ", data[i]);
            }
            Console.Write(data[data.Length - 1]);
            Console.WriteLine();
        }

        //quick sort for int[]
        public static void QuickSort(int[] data)
        {
            // pre: 0 <= n <= data.length
            // post: values in data[0 … n-1] are in ascending order
            Quick_Sort(data, 0, data.Length - 1);
        }

        public static void Quick_Sort(int[] data, int left, int right)
        {
            int i, j;
            int pivot, temp;
            i = left;
            j = right;
            pivot = data[(left + right) / 2];
            do
            {
                //for ascending
                while ((data[i] < pivot) && (i < right)) i++;
                while ((pivot < data[j]) && (j > left)) j--;
                //for descending
                //while ((data[i] > pivot) && (i < right)) i++;
                //while ((pivot > data[j]) && (j > left)) j--;
                if (i <= j)
                {
                    
                    temp = data[i];
                    data[i] = data[j];
                    data[j] = temp;
                    i++;
                    j--;
                }
            } while (i <= j);
            if (left < j) Quick_Sort(data, left, j);
            if (i < right) Quick_Sort(data, i, right);
        }        //quick sort for double[]
        public static void QuickSort(double[] data)
        {
            // pre: 0 <= n <= data.length
            // post: values in data[0 … n-1] are in ascending order
            Quick_Sort(data, 0, data.Length - 1);
        }

        public static void Quick_Sort(double[] data, int left, int right)
        {
            int i, j;
            double pivot, temp;
            i = left;
            j = right;
            pivot = data[(left + right) / 2];
            do
            {
                while ((data[i] < pivot) && (i < right)) i++;
                while ((pivot < data[j]) && (j > left)) j--;
                if (i <= j)
                {
                    temp = data[i];
                    data[i] = data[j];
                    data[j] = temp;
                    i++;
                    j--;
                }
            } while (i <= j);
            if (left < j) Quick_Sort(data, left, j);
            if (i < right) Quick_Sort(data, i, right);
        }        //for int[]        public static void HeapSort(int[] Heap)
        {
            // pre: 0 <= n <= Heap.length
            // post: values in Heap[0 … n-1] are in ascending order
            int HeapSize = Heap.Length;
            int i;
            for (i = (HeapSize - 1) / 2; i >= 0; i--)
            {
                Max_Heapify(Heap, HeapSize, i);
            }
            for (i = Heap.Length - 1; i > 0; i--)
            {
                int temp = Heap[i];
                Heap[i] = Heap[0];
                Heap[0] = temp;
                HeapSize--;
                Max_Heapify(Heap, HeapSize, 0);
            }
        }

        private static void Max_Heapify(int[] Heap, int HeapSize, int Index)
        {
            int Left = (Index + 1) * 2 - 1;
            int Right = (Index + 1) * 2;
            int largest = 0;
            if (Left < HeapSize && Heap[Left] > Heap[Index])
            {
                largest = Left;
            }
            else
            {
                largest = Index;
            }
            if (Right < HeapSize && Heap[Right] > Heap[largest])
            {
                largest = Right;
            }
            if (largest != Index)
            {
                int temp = Heap[Index];
                Heap[Index] = Heap[largest];
                Heap[largest] = temp;
                Max_Heapify(Heap, HeapSize, largest);
            }
            printArray(Heap);
        }

        //for double[]
        public static void HeapSort(double[] Heap)
        {
            // pre: 0 <= n <= Heap.length
            // post: values in Heap[0 … n-1] are in ascending order
            int HeapSize = Heap.Length;
            int i;
            for (i = (HeapSize - 1) / 2; i >= 0; i--)
            {
                Max_Heapify(Heap, HeapSize, i);
            }
            for (i = Heap.Length - 1; i > 0; i--)
            {
                double temp = Heap[i];
                Heap[i] = Heap[0];
                Heap[0] = temp;
                HeapSize--;
                Max_Heapify(Heap, HeapSize, 0);
            }
        }

        private static void Max_Heapify(double[] Heap, int HeapSize, int Index)
        {
            int Left = (Index + 1) * 2 - 1;
            int Right = (Index + 1) * 2;
            int largest = 0;
            if (Left < HeapSize && Heap[Left] > Heap[Index])
            {
                largest = Left;
            }
            else
            {
                largest = Index;
            }
            if (Right < HeapSize && Heap[Right] > Heap[largest])
            {
                largest = Right;
            }
            if (largest != Index)
            {
                double temp = Heap[Index];
                Heap[Index] = Heap[largest];
                Heap[largest] = temp;
                Max_Heapify(Heap, HeapSize, largest);
            }
            printArray(Heap);
        }


    }
}
