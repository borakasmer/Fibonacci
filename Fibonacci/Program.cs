using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteCode();
            Console.ReadLine();
        }

        static int Total = 0;
        static int TotalPrev = 0;
        public static void WriteCode(int n = 1)
        {
            TotalPrev = Total;
            if (Total <= 100)
            {
                Console.WriteLine(Total);
                Total += n;                
                WriteCode(TotalPrev);
            }
        }
    }
}
