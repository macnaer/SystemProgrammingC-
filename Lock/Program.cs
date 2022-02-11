using Lock;

public class Program
{
    public static void Main()
    {
        Database db = new Database();

        Monitor.Enter(db);
        for (int i = 0; i < 3; i++)
        {
            new Thread(db.Incert).Start();
        }
        Monitor.Exit(db);

        Thread.Sleep(1000);

        Console.ReadKey();

    }
}