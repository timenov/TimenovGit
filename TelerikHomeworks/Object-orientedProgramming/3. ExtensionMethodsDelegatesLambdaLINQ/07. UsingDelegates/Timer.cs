using System;
using System.Diagnostics;

namespace _07.UsingDelegates
{
    public delegate void SimpleDelegate();

    public static class Timer
    {
        public static void ExecuteDelegate(int interval, SimpleDelegate someDelegate)
        {
            Stopwatch sw = new Stopwatch();
            interval *= 1000;
            
            while (true)
            {
                sw.Start();
                if (sw.ElapsedMilliseconds == interval)
                {
                    someDelegate();
                    sw.Reset();
                }
            }
        }
    }
}
