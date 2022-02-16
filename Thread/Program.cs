internal class Program
{
    //=====================Example1=====================//
    /*static void SecondTread()
    {
        while (true)
        {
            Console.WriteLine(new string(' ', 15) + "SecondTread Tread");
            Thread.Sleep(1000);
        }
    }*/
    //=====================Example1=====================//
    //=====================Example2=====================//
    //static void SecondTread()
    //{
    //    uint counter = 0;

    //    while (counter < 1000)
    //    {
    //        Console.WriteLine($"Id {Thread.CurrentThread.GetHashCode()}, counter = {counter}");
    //        counter++;
    //    }
    //}
    //=====================Example2=====================//
    //=====================Example3=====================//
    static void SecondTread()
    {
        Thread secondThread = Thread.CurrentThread;
        secondThread.Name = "Second Thread";

        Console.WriteLine($"Name: {secondThread.Name} : Id {secondThread.GetHashCode()}");
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(new string(' ', 15) + secondThread.Name + i);
            Thread.Sleep(3000);
        }
    }
    //=====================Example3=====================//
    //=====================Example4=====================//
    static void Method(object str)
    {
        string text = (string)str;
        for (int i = 0; i < 10000; i++)
        {
            Console.WriteLine($"{text} : {i}");
        }
    }
    //=====================Example4=====================//

    static void Main(string[] args)
    {
        //=====================Example1=====================//
        //ThreadStart secondThread = new ThreadStart(SecondTread);
        //Thread thread = new Thread(SecondTread);
        //thread.Start();

        //while (true)
        //{
        //    Console.WriteLine("Main Thread");
        //    Thread.Sleep(1000);
        //}
        //=====================Example1=====================//
        //=====================Example2=====================//
        //for (int i = 0; i < 1000; i++)
        //{
        //    Thread thread = new Thread(SecondTread);
        //    thread.Start();
        //}
       

        //SecondTread();
        //=====================Example2=====================//
        //=====================Example3=====================//
        /*Thread mainThread = Thread.CurrentThread;

        mainThread.Name = "Main Thread";

        Console.WriteLine($"Name: {mainThread.Name} : Id {mainThread.GetHashCode()}");
        Thread thread = new Thread(SecondTread);
        thread.Start();

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(new string(' ', 15) + mainThread.Name + i);
            Thread.Sleep(1000);
        }*/
        //=====================Example3=====================//
        //=====================Example4=====================//

        ParameterizedThreadStart ts = new ParameterizedThreadStart(Method);
        Thread thread1 = new Thread(ts);
        Thread thread2 = new Thread(ts);
        thread1.Priority = ThreadPriority.Highest;
        thread2.Priority = ThreadPriority.Lowest;
        thread1.Start("First => ");
        thread2.Start("Second => ");

        //=====================Example4=====================//



        Console.ReadKey();
    }
}