using ParamatrizedThreads;

public class Program
{
    static void LaunchRocket(object obj)
    {
        Parts parts = obj as Parts;
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"Rocker {parts.Name} starts...\nEngine: {parts.Engine}\nFuel System: {parts.FuelSystem}" +
                $"\nNavigation system: {parts.Navigation}");
            Console.WriteLine("=======================");
            Thread.Sleep(parts.Timer);
        }
    }

    static void Main()
    {
        Parts parts = new Parts();
        parts.Name = "DOS4GW";
        parts.Engine = "2GZGTE";
        parts.FuelSystem = "Bosh";
        parts.Navigation = "Wize";
        parts.Timer = 1000;

        ParameterizedThreadStart launchRocket = new ParameterizedThreadStart(LaunchRocket);
        Thread thread = new Thread(launchRocket);
        thread.Start(parts);

        Console.ReadKey();


    }
}