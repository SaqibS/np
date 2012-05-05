namespace NP
{
    using System;
    using System.Diagnostics;
    using System.IO;

    internal static class Program
    {
        internal static void Main(string[] args)
        {
            try
            {
                string[] filesToOpen;
                if (args.Length == 0)
                {
                    string text = Console.In.ReadToEnd();
                    string tempFilename = Path.GetTempFileName();
                    File.WriteAllText(tempFilename, text);
                    filesToOpen = new string[] { tempFilename };
                }
                else
                {
                    filesToOpen = args;
                }

                string notepadPath = Path.Combine(Environment.SystemDirectory, "notepad.exe");
                foreach (string filename in filesToOpen)
                {
                    Process.Start(notepadPath, filename);
                }
            }
            catch (Exception x)
            {
                Console.Error.WriteLine("Error: {0}", x.Message);
            }
        }
    }
}
