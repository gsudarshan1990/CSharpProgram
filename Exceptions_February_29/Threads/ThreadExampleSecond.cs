namespace Threads
{

    public class MyThread
    {
        public static void Thread1()
        {
            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine(Thread.CurrentThread.Name + ":" + i);
            }

        }
    }
    internal class ThreadExampleSecond
    {
        static void Main(string[] args)
        {
            Thread t1 = new Thread(new ThreadStart(MyThread.Thread1));
            Thread t2 = new Thread(new ThreadStart(MyThread.Thread1));
            t1.Name = "First Thread";
            t2.Name = "Second Thread";
            t1.Start();
            t2.Start();
        }
    }
}
