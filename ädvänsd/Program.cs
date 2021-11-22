using System;
using System.Threading;

namespace ädvänsd
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread mainThread = new Thread(DoMainThreadStuff);
            Thread wait4Close = new Thread(ExitStuff);
            mainThread.Start();
            wait4Close.Start();

            while (true)
            {
                Console.WriteLine("This is in main program");
            }
        }

        static void DoMainThreadStuff()
        {
            while (true)
            {
                Console.WriteLine("Hello from se sred");
            }
        }
        static void ExitStuff()
        {
            Console.ReadLine();
            Environment.Exit(0);
        }
    }
}