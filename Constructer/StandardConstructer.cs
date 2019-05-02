using System;

namespace Constructer
{
    public class StandardConstructer
    {
        private readonly string _LocalVariableSetViaConstructor; // this can set within the contrucot
        private const string LocalConstantSetInClass = "test"; // this can only be set within the class

        public StandardConstructer(string localVariableSetViaConstructor)
        {
            _LocalVariableSetViaConstructor = localVariableSetViaConstructor;
        }

        public void DoSoemthing()
        {
            Console.WriteLine("Print injected variable " + _LocalVariableSetViaConstructor);
        }
    }
}
