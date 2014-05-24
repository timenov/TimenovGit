//Write a program that downloads a file from Internet and stores it the current directory.
//Be sure to catch all exceptions and to free any used resources in the finally block.
using System;
using System.Net;

class Download
{
    static void Main()
    {
        using (WebClient wc = new WebClient())
        {
            try
            {
                wc.DownloadFile("http://www.devbg.org/img/Logo-BASD.jpg", "logo.jpg");
            }
            catch (SystemException se)
            {
                Console.WriteLine(se.Message);
            }
        }
    }
}