namespace ClassExample_February_20
{

    class MyClass
    {
        public int Value { get; set; }

        public MyClass(int value)
        {
            Value = value;
        }

    }



    internal class ClassWithRefAndOut
    {

        public static void ModifyWithRef(ref MyClass myobject)
        {
            myobject.Value = 5;
        }

        public static void ModifyWithOut(out MyClass myclass)
        {
            myclass = new MyClass(10);
        }

        static void Main(string[] args)
        {
            MyClass object1 = new MyClass(8);
            Console.WriteLine("Value Before Any Operation" + object1.Value);


            ClassWithRefAndOut.ModifyWithRef(ref object1);
            Console.WriteLine("Value After Ref Operation" + object1.Value);

            ClassWithRefAndOut.ModifyWithOut(out object1);
            Console.WriteLine("Value After Out Operation" + object1.Value);

        }
    }
}
