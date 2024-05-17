using System;
using System.Collections.Generic;
using System.Text;

namespace Learn01._12.TwoDArray
{
    public static class TwoDimArrayExample
    {
        public static void TwoDArray()
        {
            int[,] numbers = { { 1, 2, 3 }, { 6, 9, 7 } };
            numbers[0, 1] = 8;
            Console.WriteLine(numbers[0,1]);
           

            //for (int i = 0; i < numbers.GetLength(0); i++)
            //{
            //    for (int j = 0; j < numbers.GetLength(1); j++)
            //    {
            //        Console.WriteLine(numbers[i,j] );
            //    }
            //}


        }

        public static void Test()
        {
            // Q1
            string[] strArray = new string[] { "sun", "mon", "tue","wed","thu","fri", "sat" };

            // find  sat or sun. print Happy Weekend!

            for(int i=0; i<strArray.Length;i++)
            {
                if (strArray[i]== "sun" || strArray[i] == "sat")
                {
                    Console.WriteLine("happy Weekend");
                }

               

            }
            

            Console.WriteLine("---------------");
            Console.WriteLine("Question 2 :");
            Console.WriteLine("---------------");


            // Q2
            // create new string[] using strArray to show only week days

            //string[] tempArray = new string[6];
            //int k = 0;


            //for (int i = 0; i < strArray.Length; i++)
            //{
            //    if (strArray[i] != "sat" && strArray[i] !="sun" )
            //    {

            //        tempArray[k] = strArray[i];
            //        k++;
            //    }
            //}  

            string[] strArray2 = new string[] { "sun", "mon", "tue", "wed", "thu", "fri", "sat" };

            List<string> tempArray = new List<string>(); // Using List instead of an array for dynamic resizing

            for (int i = 0; i < strArray2.Length; i++)
            {
                if (strArray2[i] != "sat" && strArray2[i] != "sun")
                {

                    tempArray.Add(strArray2[i]);
                }
                //if (strArray2[i] == "mon")
                //{
                //    tempArray.Remove(strArray2[i]);
                //}
            }
            for (int i = 0; i < tempArray.Count; i++)
            {
                Console.WriteLine(tempArray[i]);
            }
        
        }




    }
}
