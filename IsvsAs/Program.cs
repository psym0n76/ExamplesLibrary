using System;

namespace IsvsAs
{
    class Program
    {

        // IS vs AS Keyword

        static void Main(string[] args)
        {

            // IS str variable type of String - typecast from one type to another type
            // CHECK if the object is of a particualr type

            object str = "shive";
            if (str is string)
            {
                Console.WriteLine("This is of the same type");
            }

            object str1 = "1234";
            if (str is string)
            {
                //doesnt call
                Console.WriteLine("This is of the same type");
            }

            //convert an object from one type to another type
            // Can we CONVERT str string AS a object
            object strO = "shive";
            string x = strO as string;

            //object strO = "123";
            //string x = strO as string; // cant complile

        }
    }
}
