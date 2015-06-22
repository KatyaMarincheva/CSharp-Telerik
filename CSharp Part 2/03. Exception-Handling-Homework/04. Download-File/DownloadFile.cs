// Problem 4. Download file

/*  Write a program that downloads a file from Internet (e.g. Ninja image) and stores it the current directory.
    Find in Google how to download files in C#.
    Be sure to catch all exceptions and to free any used resources in the finally block.
 */

using System;
using System.IO;
using System.Net;

class DownloadFile
{
    static void Main()
    {
        // input
        string sourceResource = "http://cdn.screenrant.com/wp-content/uploads/jungle-book-movie-ron-howard.jpg";
        string localFileName = Path.GetFileName(sourceResource);

        // please check for downloaded image in
        // C:\..........\Exception-Handling-Homework\04. Download-File\bin\Debug

        // try to download
        using (WebClient myWebClient = new WebClient())
        {
            try
            {
                Console.WriteLine("Start downloading {0}", sourceResource);
                myWebClient.DownloadFile(sourceResource, localFileName);
                Console.WriteLine("Download succesfull.");
            }
                // display exceptions if any
            catch (WebException ex)
            {
                Console.Write(ex.Message);
                if (ex.InnerException != null)
                    Console.WriteLine(" " + ex.InnerException.Message);
                else
                    Console.WriteLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error. Details: " + ex.Message);
            }
        }
    }
}

