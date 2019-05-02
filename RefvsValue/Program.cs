using System;

namespace RefvsValue
{
    class Program
    {
        static void Main(string[] args)
        {

            //ref vs value Comparing object

            object o = ".Net Questions";
            object o1 = o;

            Console.WriteLine(o == o1);
            Console.WriteLine(o.Equals(o1));

            object ot = ".Net Questions";
            object ot1 = new string(".Net Questions".ToCharArray());

            // the o is the reference
            //this are true
            Console.WriteLine(ot == ot1); // different object references
            Console.WriteLine(ot.Equals(ot1)); // value of the object ios the samne
            Console.ReadLine();



        }
    }
}
