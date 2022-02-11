using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lock
{
    internal class Database
    {
        object locker = new object();
        public void Incert()
        {
           
            int hash = Thread.CurrentThread.GetHashCode();
            lock (locker)
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine($"Thread # {hash} : iterator {i}");
                    Thread.Sleep(1000);
                }
                Console.WriteLine(new String(' ', 20));
            }
           
        }
       


    }
}
