using System;
using System.Collections.Generic;

namespace IEnumerablevsIEnumerator
{
    class Program
    {

        //both move through collections
        //Ienumrable(does hold state but has more code) is a wrapper for Ienumrator (holds state / holds the record number)
        static void Main(string[] args)
        {
            List<int> years = new List<int>();
            years.Add(2001);
            years.Add(2002);
            years.Add(2003);
            years.Add(2004);
            years.Add(2005);
            years.Add(2006);
            years.Add(2007);
            years.Add(2008);
            years.Add(2009);
            years.Add(2010);
            years.Add(2011);


            IEnumerable<int> iEnum = (IEnumerable<int>) years;

            //short and sweet and contains IEnumerator
            foreach (var item in iEnum)
            {
                Console.WriteLine(item);
            }

            IEnumerator<int> IEnumt= years.GetEnumerator();

            //more code
            while (IEnumt.MoveNext())
            {
                Console.WriteLine(IEnumt.Current.ToString());
            }

            // this loo retains state
            Iterate2001to2005(IEnumt);

            //this loop looses state and resets
            Iterate2001to2005(iEnum);

            Console.ReadLine();
        }

        static void Iterate2001to2005(IEnumerator<int> o)
        {
            while (o.MoveNext())
            {
                Console.WriteLine(o.Current.ToString());
                if (Convert.ToInt16(o.Current) > 2005)
                {
                    Iterate2006AndAbove(o);
                }
            }
        }

        static void Iterate2006AndAbove(IEnumerator<int> o)
        {
            while (o.MoveNext())
            {
                Console.WriteLine(o.Current.ToString());
            }

        }

        //resets the loop
        static void Iterate2001to2005(IEnumerable<int> o)
        {

            foreach (int item in o)
            {
                Console.WriteLine(item);
                if (item > 2005)
                {
                    Iterate2006AndAbove(o);
                }
            }

        }

        static void Iterate2006AndAbove(IEnumerable<int> o)
        {
            foreach (int item in o)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
