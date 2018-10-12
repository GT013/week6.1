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
            int x = 17;
            double y = x / 4.0;
            double z = y * y;
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.WriteLine("---------------------------------"); 
            int a = 5;
            int b = 4;
            Console.WriteLine(a + b); // 9

            Console.WriteLine(a + (b++)); // 5 + 4 = 9
            Console.WriteLine(a + b); // 5 + 5 = 10

            Console.WriteLine(a + (++b)); // 5 + 5 +1 =11
            Console.WriteLine(a + b); // 5 + 6 = 11

           Console.WriteLine(14 / a); // 2
            Console.WriteLine(14 % a); // 4

        }
    }
}

