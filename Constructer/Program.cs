namespace Constructer
{
    class Program
    {
        static void Main(string[] args)
        {
            //private contructor cannot be inherited
            //PrivateConstructer test = PrivateConstructer;
            //helper classes
            //common classes - no instationaing
            //similar to extension methods
            PrivateConstructer.RunSomethingWithNoNew(); // can call a static function direct
            var result = PrivateConstructer.RunSomethingWithNoNewString(); // return a string
            //standard constructor
        }
    }
}
