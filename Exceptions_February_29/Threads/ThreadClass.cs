namespace Threads
{
    internal class ThreadClass
    {
        static void Main(string[] args)
        {
            Thread t = Thread.CurrentThread;
            t.Name = "Main Thread";
            Console.WriteLine(t.Name);
        }
    }
}
