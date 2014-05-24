using System;

namespace _07.UsingDelegates
{
    class MainClass
    {
        static void Main()
        {
            Console.Write("enter interval in seconds: ");
            int interval = int.Parse(Console.ReadLine());
            Timer.ExecuteDelegate(interval, SomeMethod);
        }

        public static void SomeMethod()
        {
            Console.WriteLine("I'm delegate and I was calling.");
        }
    }
}
