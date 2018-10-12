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
            bool a = true; // กำหนดให้ a มีค่าเป็น true
            bool b = false;  // กำหนดให้ a มีค่าเป็น false
            Console.WriteLine(a && b); // เปรียบเทียบทางตรรกะศาสตร์ a และ b ผลลัพธ์ false
            Console.WriteLine(a || b); // เปรียบเทียบทางตรรกะศาสตร์ a หรือ b ผลลัพธ์ true
            Console.WriteLine(!b);  // นิเสธ b ผลลัพธ์ true
            Console.WriteLine(b || true); // เปรียบเทียบทางตรรกะศาสตร์ b หรือ true ผลลัพธ์ true
            Console.WriteLine((9 > 7) ^ (a == b)); // 9 มากกว่า 7 จริงได้ true XOR a มีค่าเท่ากับ b เท็จได้ false นำค่า true XOR false ผลลัพธ์ true
            Console.WriteLine((b != a) || (a == b)); // b ไม่เท่ากับ a จริงได้ true OR a มีค่าเท่ากับ b เท็จได้ false นำค่า true OR false ผลลัพธ์ true
            Console.WriteLine((b != a) && (a == b)); // b ไม่เท่ากับ a จริงได้ true AND a มีค่าเท่ากับ b เท็จได้ false นำค่า true AND false ผลลัพธ์ false
            Console.WriteLine((!a) && (!b)); // นิเสธ a AND นิเสธ b // false AND true ผลลัพธ์ false
            Console.WriteLine((!a) || (!b)); // นิเสธ a OR นิเสธ b // false OR true ผลลัพธ์ true

        }
    }
}

