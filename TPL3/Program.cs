struct Calc
{
    public int a;
    public int b;
}

class Program
{
    static int Sum(object obj)
    {
        int a = ((Calc)obj).a;
        int b = ((Calc)obj).b;

        Thread.Sleep(3000);

        return a + b;
    }
    static void Main()
    {
        Console.WriteLine($"Main tread starts.");
        Calc calc;
        calc.a = 10;
        calc.b = 5;
        Task<int> task = new Task<int>(Sum, calc);

        task.Start();

        Console.WriteLine($"Sum => {task.Result}");

        Console.WriteLine($"Main tread finished.");
    }
}