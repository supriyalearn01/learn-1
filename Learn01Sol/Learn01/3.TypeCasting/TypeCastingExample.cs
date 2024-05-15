using Microsoft.VisualBasic;
using System;

namespace Learn01._3.TypeCasting
{
    public static class TypeCastingExample
    {
        public static void ExplicitCasting()
        {
            double myDouble = 9.78;
            int myInt = (int)myDouble;  // Manual casting: double to int

            Console.WriteLine($"Double Value : {myDouble}");
            Console.WriteLine($"Int Value {myInt}");
        }
        public static void TypeConversionMethods()
        {
            int myInt = 10;
            double myDouble = 5.25;
            bool myBool = true;

            Console.WriteLine($"Int to String {Convert.ToString(myInt)}");    // Convert int to string "10"
            Console.WriteLine($"Int to Double {Convert.ToDouble(myInt)}");    // Convert int to double 10
            Console.WriteLine($"Double to Int {Convert.ToInt32(myDouble)}");  // Convert double to int 5
            Console.WriteLine($"Bool to String {Convert.ToString(myBool)}");   // Convert bool to string "true"
        }
    }
}
