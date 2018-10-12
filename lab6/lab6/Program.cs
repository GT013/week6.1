using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 6;
            int y = 4;
            Console.WriteLine(y *= 2);
            int z = y = 3;
            int s;
            Console.WriteLine(z);
            s = x | 1;

            Console.WriteLine(s); // x = x | 1 = 1 // x = 6+1 = 7
            s = x + 3;
            Console.WriteLine(s); // ค่าจากบรรทัดบน 7 + 3 = 10

            Console.WriteLine(x /= 2);
        }
    }
}

