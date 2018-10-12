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
            object[] myary = {"nantikan",4.00d,13, "April",2542  };
            testparas(myary);
            Console.ReadKey();
        }
        static void testparas(params object[] detail)
        {
            foreach(object t in detail)
                Console.Write(t + " ");
            Console.ReadKey();
        }
    }
}

