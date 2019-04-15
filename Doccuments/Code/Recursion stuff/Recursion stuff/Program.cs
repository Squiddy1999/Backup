using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion_stuff
{
    class Program
    {
        static void Main(string[] args)
        {
            int cheese = 1;
            int count = 4;
            Poo(cheese, count);
            Console.ReadLine();
        }

        static int Poo(int cheese, int count)
        {
            if (count == cheese)
                return 1;
            else
                Console.WriteLine("{0}, {1}", cheese, count);
                cheese = cheese * count;
                return(Poo(cheese+1, count));
        }
        
    }
}
