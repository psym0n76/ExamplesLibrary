using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    static class ExtensionString
    {
        public static string GetFirstLettter( this string result)
        {
            return result.Substring(1);
        }

    }
}
