namespace Threads
{
    public class ThreadSample
    {
        public void Threadtask()
        {
            lock (this)
            {
                for (int i = 0; i < 20; i++)
                {
                    if (Thread.CurrentThread.Name == "First Thread")
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(Thread.CurrentThread.Name + ":" + i);
                        Console.ResetColor();
                    }

                    if (Thread.CurrentThread.Name == "Second Thread")
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine(Thread.CurrentThread.Name + ":" + i);
                        Console.ResetColor();
                    }

                    if (Thread.CurrentThread.Name == "Third Thread")
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine(Thread.CurrentThread.Name + ":" + i);
                        Console.ResetColor();
                    }

                }

            }
        }
    }
    internal class ThreadSynchronization
    {
        static void Main(string[] args)
        {
            ThreadSample Ts = new ThreadSample();
            Thread t1 = new Thread(new ThreadStart(Ts.Threadtask));
            Thread t2 = new Thread(new ThreadStart(Ts.Threadtask));
            Thread t3 = new Thread(new ThreadStart(Ts.Threadtask));



            t1.Name = "First Thread";
            t2.Name = "Second Thread";
            t3.Name = "Third Thread";

            t1.Priority = ThreadPriority.Lowest;
            t2.Priority = ThreadPriority.Highest;
            t3.Priority = ThreadPriority.Normal;

            t1.Start();
            t2.Start();
            t3.Start();



        }
    }
}
