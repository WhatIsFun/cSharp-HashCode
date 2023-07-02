using System;
using System.Globalization;
using System.Text;

namespace cSharp_HashCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Hash Code example
            Console.WriteLine("Hash Code Example");
            string str1 = "Hello World";
            string str2 = "Hello World";

            Console.WriteLine("Hash code for str1: " + str1.GetHashCode());
            Console.WriteLine("Hash code for str2: " + str2.GetHashCode());
            Console.WriteLine("Is Hash Code equal: " + IsHashEqual("Hello World", "Hello"));

            static bool IsHashEqual(string str1, string str2)
            {
                if (str1 == str2)
                {
                    return true;
                }
                else
                {
                    Console.WriteLine(str1 + " Not Equal with " + str2);
                    return false;
                }
            }


            // StringBuilder Example
            Console.WriteLine("StringBuilder Example");
            StringBuilder sb = new StringBuilder();

            sb.Append("Hello");
            sb.Append(" World");

            Console.WriteLine(sb.ToString());

            //Searching

            int[] a = { 1, 2, 6, 9, 12 };

            Console.WriteLine(AscendingSort(a, 6));



        }

        //Write a program to search a number in an array , consider  that the is sorted number are from in ascending order
        public static int AscendingSort(int[]a , int num)
        {
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == num)
                {    
                    return i;
                }
            }
            return -1;




        }

    }
}