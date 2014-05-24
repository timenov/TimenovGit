using System;
using System.Text;

namespace _01.SubstringMethod
{
    public static class SubstringMethod
    {
        public static StringBuilder Substring(this StringBuilder text, int index)
        {
            return text.Substring(index, text.Length - index);
        }

        public static StringBuilder Substring(this StringBuilder text, int index, int length)
        {
            if (index < 0 || index >= text.Length)
            {
                throw new ArgumentOutOfRangeException("Index can not be larger than sting lenght.");
            }
            else if (index + length < 0 || index + length > text.Length)
            {
                throw new ArgumentOutOfRangeException("Index and length can not larger than string length.");
            }
            else
            {
                return new StringBuilder(text.ToString().Substring(index, length));
            }
        }
    }
}
