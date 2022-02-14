class Program
{
    static Semaphore semaphore = new Semaphore(5, 5);
    static int counter = 0;

    private static void Count()
    {
        semaphore.WaitOne();
        Interlocked.Increment(ref counter);
        Console.WriteLine($"{Thread.CurrentThread.Name} Started... Semaphore tread count {counter}");
        Thread.Sleep(new Random().Next(500, 1200));

        Console.WriteLine($"{Thread.CurrentThread.Name} Finishing... Semaphore tread count {counter}");
        Interlocked.Decrement(ref counter);
        semaphore.Release();
    }

    static void Main()
    {
        for (int i = 0; i < 10; i++)
        {
            Thread thread = new Thread(Count);
            thread.Name = $"Tread name {i}";
            thread.Start();
        }
        Console.ReadKey();
    }
}