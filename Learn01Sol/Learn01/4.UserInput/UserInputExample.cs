using System;
using System.Collections.Generic;
using System.Text;

namespace Learn01._4.UserInput
{
    public static class UserInputExample
    {
        public static void Build()
        {
            Console.Write("Enter PI Value : ");
            string PI=Console.ReadLine();
            Console.WriteLine($"PI Value is {PI}");
        }

        public static void Age()
        {
            Console.Write("Enter your age:");
            string readValue = Console.ReadLine();
            int age = Convert.ToInt32(readValue);
            Console.WriteLine("Your age is: " + age);
        }
    }
}
