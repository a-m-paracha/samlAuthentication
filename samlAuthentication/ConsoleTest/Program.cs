using System;
using System.IO;
using System.Diagnostics;

namespace ConsoleTest
{
    class Program
    {
        static string ProcessInput(string s)
        {
            // TODO Verify and validate the input 
            // string as appropriate for your application.
            return s;
        }
        static void Main(string[] args)
        {
            //https://github.com/googlesamples/oauth-apps-for-windows/tree/master/OAuthConsoleApp
            //Console.WriteLine("Hello World!");
            //Console.WriteLine("Alert.exe invoked with the following parameters.\r\n");
            //Console.WriteLine("Raw command-line: \n\t" + Environment.CommandLine);

            //Console.WriteLine("\n\nArguments:\n");
            //foreach (string s in args)
            //{
            //    Console.WriteLine("\t" + ProcessInput(s));
            //}
            //Console.WriteLine("\nPress any key to continue...");
            //Console.ReadKey();


            //Pass the filepath and filename to the StreamWriter Constructor
            //StreamWriter sw = new StreamWriter("C:\\data\\test\\Test.txt");
            ////Write a line of text
            //sw.WriteLine("Hello World!!");
            ////Write a second line of text
            //sw.WriteLine("From the StreamWriter class");
            //sw.WriteLine("Alert.exe invoked with the following parameters.\r\n");
            //sw.WriteLine("Raw command-line: \n\t" + Environment.CommandLine);
            //string CommandLine = Environment.CommandLine;
            //string access_token = CommandLine.Split("#")[1].Split("=")[1].Split("&")[0];
            //sw.WriteLine("Access Token: \n\t" + access_token);
            ////Close the file
            //sw.Close();

            Console.WriteLine("Hello World!");
            //using System.Diagnostics.Process cmd = new();
            //Process cmd = new Process();
            //cmd.Start();
            //cmd.StartInfo.FileName = "explorer.exe";

            Process cmd = new Process();
            cmd.StartInfo.FileName = "cmd.exe";
            cmd.StartInfo.RedirectStandardInput = true;
            cmd.StartInfo.RedirectStandardOutput = true;
            cmd.StartInfo.CreateNoWindow = true;
            cmd.StartInfo.UseShellExecute = false;
            cmd.Start();


            cmd.StandardInput.WriteLine("start https://google.com");
            cmd.StandardInput.Flush();
            cmd.StandardInput.Close();
            cmd.WaitForExit();
            

            //cmd.Start("explorer.exe", "http://google.com");
            //System.Diagnostics.Process.Start("explorer.exe", "http://google.com");
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();

        }
    }
}
