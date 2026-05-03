using System;
using System.Diagnostics;
using System.IO;

namespace MetadataStripper
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            string exifToolPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "exiftool.exe");
            if (!File.Exists(exifToolPath))
            {
                Console.WriteLine("ERROR: exiftool.exe not found!");
                Console.WriteLine("Please place exiftool.exe in the same folder as this program.");
                return;
            }

            if (args.Length == 0)
            {
                Console.WriteLine("Drag and drop files onto this executable to strip metadata.");
                return;
            }

            int successCount = 0;
            int failCount = 0;

            foreach (string filePath in args)
            {
                if (!File.Exists(filePath))
                    continue;

                Console.WriteLine($"Processing: {Path.GetFileName(filePath)}");

                ProcessStartInfo startInfo = new ProcessStartInfo
                {
                    FileName = exifToolPath,
                    Arguments = $"-all= -overwrite_original \"{filePath}\"",
                    UseShellExecute = false,
                    CreateNoWindow = true,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true
                };

                using (Process process = Process.Start(startInfo))
                {
                    process.WaitForExit();
                    if (process.ExitCode == 0)
                    {
                        successCount++;
                        Console.WriteLine($"  SUCCESS: Stripped metadata");
                    }
                    else
                    {
                        failCount++;
                        string error = process.StandardError.ReadToEnd();
                        Console.WriteLine($"  FAILED: {error}");
                    }
                }
            }

            Console.WriteLine($"\n=== COMPLETE ===");
            Console.WriteLine($"Success: {successCount}");
            Console.WriteLine($"Failed: {failCount}");
                   Environment.Exit(0);
        }
    }
}