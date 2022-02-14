class Program
{
    static Mutex mutex = new Mutex();

    static int counter = 1; 

    public static void Count()
    {
        mutex.WaitOne();
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"{Thread.CurrentThread.Name}: {counter}");
            counter++;
            Thread.Sleep(100);
        }
        mutex.ReleaseMutex();
    }

    static void Main()
    {
        for (int i = 0; i < 5; i++)
        {
            Thread thread = new Thread(Count);
            thread.Name = $"Trhead {i}";
            thread.Start();
        }
        Console.ReadKey();
    }
}