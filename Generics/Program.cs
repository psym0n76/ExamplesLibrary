using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        //help us to decople the logic from the type

        //array / list / hash tables / specialised collection
        //array strong types - weak is fixed length (no boxing / unboxing)
        // hash tables take objects, so unboxing an  boxing
        //gneric collection bridghes boxed and unboxed with resizeable arrays
        static void Main(string[] args)
        {
            Check obj = new Check();
            bool b1 = obj.Compare(1, 2);

            //add datatype at initilation
            GenericCheck<int> objGen = new GenericCheck<int>();
            bool b11 = objGen.Compare(1, 2);

            //add datatype at initilation
            GenericCheck<string> objGenString = new GenericCheck<string>();
            bool b111 = objGenString.Compare("Simon", "Simon");


            Console.WriteLine(b1); // should return false
            Console.WriteLine(b11); // should return false
            Console.WriteLine(b111); // should return false
            Console.ReadKey();

        }

    }


    class Check
    {
        public bool Compare(int i, int y)
        {
            if (i == y)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    // use generics to detetrmien the inout paramters at runtime
    class GenericCheck<UNKOWNDATATYPE>
    {
        public bool Compare(UNKOWNDATATYPE i, UNKOWNDATATYPE y)
        {
            if (i.Equals(y))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
