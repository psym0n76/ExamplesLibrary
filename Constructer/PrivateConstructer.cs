using System;

namespace Constructer
{
    public class PrivateConstructer
    {
        private PrivateConstructer()
        {
        }

        public static void RunSomethingWithNoNew()
        {
            Console.WriteLine("Do Something");
        }

        public static string  RunSomethingWithNoNewString()
        {
            return "Do Something";
        }
    }
}
