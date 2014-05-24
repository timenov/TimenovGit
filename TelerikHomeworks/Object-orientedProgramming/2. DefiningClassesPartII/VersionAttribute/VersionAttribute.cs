using System;
using System.Text.RegularExpressions;
using System.Runtime.InteropServices;

namespace VersionAttributeProject
{
    [AttributeUsage(AttributeTargets.Struct | AttributeTargets.Class |
        AttributeTargets.Interface | AttributeTargets.Enum | AttributeTargets.Method,
        AllowMultiple = false)]
    class VersionAttribute : System.Attribute
    {
        public string Version { get; private set; }
        public int Minor { get; private set; }
        public int Major { get; private set; }

        public VersionAttribute(string ver)
        {
            if (Regex.IsMatch(ver, @"\d+\.\d+"))
            {
                this.Version = ver;
                string[] parts = this.Version.Split(new char[] { '.' }, StringSplitOptions.RemoveEmptyEntries);
                this.Major = int.Parse(parts[0]);
                this.Minor = int.Parse(parts[1]);
            }
            else
            {
                throw new FormatException("The VersionAttribute string is not in a correct format!");
            }
        }
    }
}
