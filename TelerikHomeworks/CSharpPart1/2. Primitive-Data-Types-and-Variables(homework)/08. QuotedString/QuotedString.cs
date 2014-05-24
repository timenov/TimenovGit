//Declare two string variables and assign them with following value:
// The "use" of quotations causes difficulties.

using System;

    class QuotedString
    {
        static void Main()
        {
            string isQuoted = @"The ""use"" of quotations causes difficulties.";

            string notQuoted = "The \"use\" of quotations causes difficulties.";

            Console.WriteLine("Quoted:\n{0}\n\nNot quoted:\n{1}", isQuoted, notQuoted);
        }
    }