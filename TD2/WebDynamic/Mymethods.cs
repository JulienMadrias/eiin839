using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace WebDynamic
{
    class Mymethods
    {
        public string MyMethod(string param1_value, string param2_value)
        {
            return "<HTML><BODY> Hello " + param1_value + " et " + param2_value + "</BODY></HTML>";
        }

        public string MyExec(string param1, string param2)
        {
            //
            // Set up the process with the ProcessStartInfo class.
            // https://www.dotnetperls.com/process
            //
            ProcessStartInfo start = new ProcessStartInfo();
            start.FileName = "C:/Users/user/source/repos/eiin839/TD2/MyExec/bin/Debug/netcoreapp3.1/MyExec.exe"; // Specify exe name.
            start.Arguments = param1 + " " + param2; // Specify arguments.
            start.UseShellExecute = false;
            start.RedirectStandardOutput = true;
            //
            // Start the process.
            //
            using (Process process = Process.Start(start))
            {
                //
                // Read in all the text from the process with the StreamReader.
                //
                using (StreamReader reader = process.StandardOutput)
                {
                    string result = reader.ReadToEnd();
                    Console.WriteLine(result);
                    return result;
                }
            }
        }
    }
}
