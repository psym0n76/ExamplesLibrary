using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutvsRef
{
    class Program
    {
        static void Main(string[] args)
        {

            //OUT and REF are c# keywords that helps to variables by reference

            int outsideVar = 20;
            SomeFunction(outsideVar); //value not changed
            SomeFunctionRef(ref outsideVar); //value changed
            SomeFunctionOut(out outsideVar); // this only passes a value back, cannot pass in, alwasy one way
            
            Console.WriteLine(outsideVar);

        }

        private static void SomeFunction(int insideVar)
        {
            //this variable is contained
            insideVar = insideVar + 10;
        }

        private static void SomeFunctionOut(out int insideVar)
        {
            //this variable is contained
            insideVar = 0;
            insideVar = insideVar + 10;
        }

        private static void SomeFunctionRef(ref int insideVar)
        {
            //this variable is contained
            insideVar = insideVar + 10;
        }
    }
}
