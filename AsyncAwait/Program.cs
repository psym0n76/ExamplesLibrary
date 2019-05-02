using System;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncAwait
{
    class Program
    {
        static void Main(string[] args)
        {
            //Async and Await are new to >net 4.5
            // Async and Await are markers as to where the control shoulds resume after a long running task

            DoSomething();
            Console.WriteLine("Main thread");
            Console.ReadLine();

        }

        //private static void DoSomething()
        private static async void DoSomething()
        {
            //Task.Run(new Action(LongRunningTask)); //this will not stop and continue with console
            await Task.Run(new Action(LongRunningTask)); //this will stop adn wait
            Console.WriteLine("New Thread");
        }

        private static void LongRunningTask()
        {
            Thread.Sleep(20000); // wait for 20 seconds
        }
    }
}
