using System;
using System.Collections.Generic;
using System.Text;

namespace Learn01._5.Operators
{
    public static class OperatorsExample
    {
        public static void ModulusForReminder()
        {
            int x = 5;
            int y = 2;
            int remainder = x % y;
            Console.WriteLine($"Remainder : {remainder}");
        }

        public static void Increment()
        {
            int x = 5;
            x++;
            Console.WriteLine(x); //6
        }
        public static void Decrement() {
            int x = 5;
            x--;
            Console.WriteLine(x); // 4
        }

        public static void OperationsEx()
        {
            int x = 5;
            int y = 2;
            x += y; // x=x+y
            Console.WriteLine(x);// 7
        }

        public static void Logical()
        {
            int x = 5;
            bool result = x > 3 || x < 10;
            Console.WriteLine(result); // true
        }
    }
}
