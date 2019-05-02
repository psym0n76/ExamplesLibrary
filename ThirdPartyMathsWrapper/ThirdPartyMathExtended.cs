using ThirdPartyMathsClosed;

namespace ThirdPartyMathsWrapper
{

    //switch from aggrgatino to extension method - p ass a ref of the class to the static method
    public static  class ThirdPartyMathExtended // make class static
    {
        //public ThirdPartyMath obj = new ThirdPartyMath(); remove aggregation

        public static int Subtract( this ThirdPartyMath obj, int num1, int num2)
        {
            return num1 - num2;
        }
    }
}
