namespace StaticNameSpaceExamples
{
    internal class GarbageCollectionExample
    {
        List<Employee> employees = new List<Employee>();
        static void Main(string[] args)
        {
            GarbageCollectionExample garbageCollection = new GarbageCollectionExample();
            for (int i = 0; i < 1000000; i++)
            {
                Employee e1 = new Employee(Guid.NewGuid().ToString(), Guid.NewGuid().GetHashCode(), Guid.NewGuid().GetHashCode());
                garbageCollection.employees.Add(e1);
            }

            garbageCollection.employees.Clear();
            garbageCollection.employees = null;
            GC.Collect();

            Console.ReadLine();
        }
    }
}
