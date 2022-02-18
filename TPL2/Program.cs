class Program
{
    static void SimpleTask()
    {
        Console.WriteLine($"SimpleTask: CurrentID {Task.CurrentId} is running.");
        Thread.Sleep(3000);
        Console.WriteLine($"SimpleTask: CurrentID {Task.CurrentId} is finished.");

    }
    static void Main()
    {
        Console.WriteLine($"Main tread starts.");
        Task task1 = new Task(SimpleTask);
        Task task2 = new Task(SimpleTask);
        task1.Start();
        task2.Start();
        Console.WriteLine($"Id task1 {task1.Id}");
        Console.WriteLine($"Id task2 {task2.Id}");
        Task.WaitAll(task1, task2);
        //Task.WaitAny(task1);

        Console.WriteLine($"Main tread finished.");
    }
}