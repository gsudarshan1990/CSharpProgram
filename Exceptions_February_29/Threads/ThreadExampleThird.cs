namespace Threads
{
    public class MyThreads
    {
        public void task()
        {
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine(Thread.CurrentThread.Name + ":" + i);
                Thread.Sleep(100);

            }

        }
    }
    internal class ThreadExampleThird
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start Main");
            MyThreads threads = new MyThreads();
            Thread t1 = new Thread(new ThreadStart(threads.task));
            Thread t2 = new Thread(new ThreadStart(threads.task));

            t1.Name = "First Thread";
            t2.Name = "Second Thread";
            t1.Start();
            t2.Start();

            try
            {
                t1.Join();
                t2.Join();
            }
            catch (ThreadAbortException tae)
            {
                Console.WriteLine(tae.ToString());
            }

            Console.WriteLine("End Main");
        }
    }
}
