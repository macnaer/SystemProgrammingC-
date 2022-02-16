class Program
{
    static void SimpleTask()
    {
        int threadId = Thread.CurrentThread.ManagedThreadId;
        Console.WriteLine($"\nTask running in parralel thread # {threadId}");

        for (int i = 0; i < 10; i++)
        {
            Thread.Sleep(200);
            Console.Write("P ");
        }
        Console.WriteLine($"\nParralel thread finished in tread # {threadId}");
    }

    static void Main()
    {
        int threadId = Thread.CurrentThread.ManagedThreadId;
        Console.WriteLine($"\nTask running in main thread # {threadId}");
        Action action = new Action(SimpleTask);

        Task task = new Task(action);
        Console.WriteLine($"1. {task.Status}");
        task.Start();
        Console.WriteLine($"2. {task.Status}");

     
       for (int i = 0; i < 10; i++)
       {
            Console.Write("M ");
            Thread.Sleep(200);
            Console.WriteLine($"3. {task.Status}");

        }
        Console.WriteLine($"\nMain thread finished in tread # {threadId}");
        Console.WriteLine($"4. {task.Status}");

        Console.ReadKey();
    }
}