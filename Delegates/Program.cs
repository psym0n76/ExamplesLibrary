using System;

namespace Delegates
{
    public class Program
    {
        //delegates //pointer to a function

        // create delegate / defintion is a representative / a communicator
        // whats the benefit of calling the method indirectly

        public static void Main(string[] args)
        {
            LongRunningCodeTask obj = new LongRunningCodeTask();
            //run task passing thgrough the method to communicate back on
            obj.LongRunningTask(CallBackMethod);
        }

        static void CallBackMethod(int i)
        {
            Console.WriteLine(i);
        }
    }
}