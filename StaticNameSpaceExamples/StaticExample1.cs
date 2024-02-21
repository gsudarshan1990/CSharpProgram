namespace StaticNameSpaceExamples
{
    class StaticExample1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calling the static ");
            Console.WriteLine(staticClass.value);

            Console.WriteLine("Calling the Instance ");
            NonStaticClass instance1 = new NonStaticClass(20);
            NonStaticClass instance2 = new NonStaticClass(40);

            instance1.InstanceMethod();
            instance2.InstanceMethod();

        }
    }

    class staticClass
    {
        public static int value { get; set; } = 42;

        public static void staticFunction()
        {
            Console.WriteLine("This is a static function");
        }
    }

    class NonStaticClass
    {
        public int value { get; set; }

        public NonStaticClass(int value1)
        {
            value = value1;
        }

        public void InstanceMethod()
        {
            Console.WriteLine("This is a instance method");
        }
    }
}
