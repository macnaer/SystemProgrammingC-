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
        //for (int i = 0; i < 5; i++)
        //{
        //    Thread thread = new Thread(Count);
        //    thread.Name = $"Trhead {i}";
        //    thread.Start();
        //}
      

        for (int i = 1; i <= 3; i++)
        {
            Thread thread = new Thread(Start);
            thread.Name = $"{i}";
            thread.Start();
            Thread.Sleep(50);
        }
        Console.ReadKey();
    }


    public static void Start()
    {
        mutex.WaitOne();
        //Thread.Sleep(500);
        //Console.WriteLine($"Thread number: {Thread.CurrentThread.Name}");
        //switch (Thread.CurrentThread.Name)
        //{
        //    case "1":   Console.WriteLine("Part1"); break;
        //    case "2": Console.WriteLine("Part2"); break;
        //    case "3": Console.WriteLine("Part3"); break;
        //    default:
        //        break;
        //}

        if (Thread.CurrentThread.Name == "1")
        {
            Console.WriteLine("Part1");
        }
        else if (Thread.CurrentThread.Name == "2")
        {
            Console.WriteLine("Part2");
        }
        else if (Thread.CurrentThread.Name == "3")
        {
            Console.WriteLine("Part3");
        }

        mutex.ReleaseMutex();
    }
}