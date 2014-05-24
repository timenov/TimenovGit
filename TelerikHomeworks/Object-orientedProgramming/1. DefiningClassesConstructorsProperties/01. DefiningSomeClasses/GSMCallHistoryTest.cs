using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.DefiningSomeClasses
{
    class GSMCallHistoryTest
    {
        public static void CallHistoryTest()
        {
            GSM testCall = new GSM("3310", "Nokia");
            testCall.AddCall("0884343536", 123);
            testCall.AddCall("0886334659", 345);
            testCall.AddCall("0885344556", 234);

            int indexOfLongest = 0;
            for (int i = 0; i < testCall.CallHistory.Count; i++)
            {
                if (testCall.CallHistory[indexOfLongest].Duration < testCall.CallHistory[i].Duration)
                {
                    indexOfLongest = i;
                }
                Console.WriteLine(testCall.CallHistory[i].ToString());
            }
            Console.WriteLine("total price: {0}", testCall.CalculateCalls());
            Console.WriteLine("\nRemove longest!");
            testCall.DeleteCall(indexOfLongest);
            Console.WriteLine("total price: {0}", testCall.CalculateCalls());
            Console.WriteLine("\nClear log!");
            testCall.ClearCalls();
            Console.WriteLine("number of calls in log: {0}", testCall.CallHistory.Count);
        }
    }
}
