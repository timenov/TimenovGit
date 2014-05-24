using System;
using System.Reflection;

namespace VersionAttributeProject
{
    [Version("2.11")]
    class SampleClass
    {
        static void Main()
        {
            Type type = typeof(SampleClass);
            object[] allAttributes = type.GetCustomAttributes(false);
            foreach (VersionAttribute att in allAttributes)
            {
                Console.WriteLine("Version is: {0}", att.Version);
            }
        }
    }
}
