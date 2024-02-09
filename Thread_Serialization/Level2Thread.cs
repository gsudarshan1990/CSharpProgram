using System;
using System.Threading;


namespace Level2Thread
{
    class Program2
    {
        static int sharedCounter = 0;
        static Object lockObject = new object();

        static void Main(string[] args)
        {
            Thread t1 = new Thread(IncrementCounter);
            Thread t2 = new Thread(IncrementCounter);

            //Starting the Thread

            t1.Start();
            t2.Start();

            //Joining the Thread
            t1.Join();
            t2.Join();

            Console.WriteLine($"Shared Counter value {sharedCounter}");
        }


        static void IncrementCounter()
        {
            for(int i=0;i<5000;i++)
            {
                lock(lockObject) 
                {
                    sharedCounter++;
                }
            }
        }

    }

  
}
