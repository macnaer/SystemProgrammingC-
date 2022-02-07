using System.Diagnostics;

internal class Program
{
    static void Main(string[] args)
    {
        //================Example1========================//
        //var processes = Process.GetProcesses();

        //Console.WriteLine($"Total processes: {processes.Length}");
        //Console.WriteLine($"Id\t\tName\t\t\t\tMemory");
        //foreach (var process in processes)
        //{
        //    Console.WriteLine($"{process.Id}\t\t{process.ProcessName}\t\t{process.PrivateMemorySize / 1024 / 1024}");
        //}
        //================Example1========================//
        //================Example2========================//
        //var chromeProcess = Process.GetProcessesByName("chrome");
        //Console.WriteLine($"Total processes: {chromeProcess.Length}");
        //Console.WriteLine($"PID\t\tName\t\tMemory");
        //foreach (var process in chromeProcess)
        //{
        //    Console.WriteLine($"{process.Id}\t\t{process.ProcessName}\t\t{process.PrivateMemorySize /1024 /1024}");
        //}
        //================Example2========================//
        //================Example3========================//

        var processInfo = new ProcessStartInfo
        {
            FileName = "C://Program Files//Mozilla Firefox//firefox.exe",
            Arguments = "ukr.net",
            WindowStyle = ProcessWindowStyle.Maximized,

        };


        using (var process = Process.Start(processInfo))
        {
            Thread.Sleep(15000);
            process?.Kill(true);
        }

        //var cmdProcessInfo = new ProcessStartInfo
        //{
        //    FileName= "C://Windows//System32//cmd.exe",
        //    Arguments = "ping -t 8.8.8.8",
        //    UseShellExecute = false,

        //};

        //using (var process = Process.Start(cmdProcessInfo))
        //{
        //    Thread.Sleep(15000);
        //    process?.Kill();
        //}



        //================Example3========================//


    }
}