namespace VarDynamic
{
    class Program
    {
        static void Main(string[] args)
        {
            //VAR is early binded - checked during compiling
            //Dynamic is late binded

            //early binding
            var x = "string1"; // the datatype is guessed as a string
            int len = x.Length; // intellisense popped up becuase it guessed it above

            //dynamiuc uses Reflection at runtime

            dynamic y = "string1";
            int leny = y.Length; // no intellisewnae - it wokds out the type at run time

        }
    }
}
