using System;
using ThirdPartyMathsClosed;
using ThirdPartyMathsWrapper;

namespace ExtensionMethods
{
    public class Program
    {
        static void Main(string[] args)
        {
            //allow to add new methods to existing types without modifying existing code

            // this source code cannot be amended therefore we have to create another class that wraps this class
            var result = new ThirdPartyMath();
            Console.WriteLine(result.Add(4, 4));


            //crteate a wrapper class to extended functionality
            //ThirdPartyMathExtended result1;
            //result1.obj.Add(2, 2); // a way of extedning the thirdparty DLL // using inheritiance / aggrgation - adding class to an existing class
            //result1.Subtract(7, 4);            

            Console.WriteLine(result.Subtract(10, 5)); // after added extension to wrapper class i can include subtract 

            Console.ReadLine();
            string testString = "Simon";
            Console.WriteLine(testString.GetFirstLettter());
        }
    }
}
