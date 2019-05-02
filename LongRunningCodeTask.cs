using System;

public class LongRunningCodeTask
{
    public delegate void CallBack(int i);
    //long runnig task

    public void LongRunningTask(CallBack obj)
    {
        for (int i = 0; i < 10000; i++)
        {
            //does someting - send updates back from lkong method
            obj(i);
        }
    }
}
