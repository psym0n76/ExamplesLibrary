using System;
using System.Collections.Generic;

namespace LambdaExpressions
{

    //three types of Lambda (crated to simplyfy delegate code)
    //1. Action <input> - run a method
    //2. Func <input,output> - run a method with a inout and output parameter
    //3. Predicate <input> - run a method and return a boolean
    class Program
    {
        delegate double CallBackAreaPointer(int r);
        static CallBackAreaPointer pointer = CalculateArea; //remove 


        static void Main(string[] args)
        {

            //with delegate 
            double area = pointer.Invoke(20);


            //with anomymous method
            CallBackAreaPointer pointerAnon = new CallBackAreaPointer(
                delegate (int r)
                {
                    return 3.14 * r * r;
                });

            double areaAnon = pointerAnon.Invoke(20);


            //lambda
            CallBackAreaPointer pointerLambda = r => 3.14 * r * r; // input parameters (left) => function (right)
            double areaLambda = pointerLambda.Invoke(20);

            //generic delegates (FUNC / ACTION / PREDICATE)
            //lambda + FUNC acept inout and out (both anything)

            Func<Double, Double> pointerFunc = r => 3.14 * r * r;
            double areaFunc = pointerFunc(20);

            //lambda + ACTION - void return - no output
            Action<string> myAction = y => Console.WriteLine(y);
            myAction("Hello");

            //lambda + PREDICATE - ext to the FUNC - checking purpose return true or false
            Predicate<string> checkGreaterThanFive = x => x.Length > 5;
            checkGreaterThanFive("Simon123");

            //example of a predicate

            List<string> predicateStrings = new List<string>()
            {
                new String("Shiv".ToCharArray()),
                new String("Shiv123".ToCharArray()),
                new String("Shiv12345".ToCharArray()),
            };

            
            string result = predicateStrings.Find(checkGreaterThanFive);

            Console.WriteLine(result);

            Console.WriteLine(area);
            Console.WriteLine(areaAnon);
            Console.WriteLine(areaLambda);
            Console.WriteLine(areaFunc);
            Console.ReadKey();

        }

        //convert to anomymous method
        static double CalculateArea(int r)
        {
            return 3.14 * r * r;
        }
    }
}
