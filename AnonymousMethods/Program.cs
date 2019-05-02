using System;
using System.Diagnostics;

namespace AnonymousMethods
{
    class Program
    {
        delegate int PointerAdd(int num1, int num2);
        static void Main(string[] args)
        {

            //1. connected to delegates
            //2. anon method help you avoid small functions by placing them in line
            //3. anon increases performance

            //assign the delegate to the function
            //PointerAdd obj = Add; / replace Add with a inline anon function
            Stopwatch watch = new Stopwatch();
            for (int y = 0; y < 10; y++)
            {
                watch.Reset();
                watch.Start();

                for (int i = 0; i < 1000; i++)
                {

                    //FASTER CODE
                    //PointerAdd obj = delegate (int num1, int num2) // reaplces the add function below
                    //{
                    //    return num1 + num2;
                    //};

                    //SLOWER CODE
                    PointerAdd obj = Add;


                    int z = obj.Invoke(2, 2);
                }
                watch.Stop();
                Console.WriteLine(watch.ElapsedTicks.ToString());
    
            }
            Console.ReadKey();
        }

        // one line function is waste of space  
        // anon methods are required as above
        static int Add(int num1, int num2)
        {
            return num1 + num2;
        }
    }
}
