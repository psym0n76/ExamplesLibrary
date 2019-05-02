using System;

namespace Delegates
{
    public class LongRunningCodeTask
    {
        public delegate void CallBackToCaller(int i);
        //long runnig task

        public void LongRunningTask(CallBackToCaller obj)
        {
            for (int i = 0; i < 10000; i++)
            {
                //does someting - send updates back from lkong method
                obj(i);
            }
        }
    }
}