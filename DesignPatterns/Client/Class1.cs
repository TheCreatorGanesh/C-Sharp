namespace Client
{
    public class Class1
    {
        public Class1()
        {
            Console.WriteLine("Class1 const called");
        }
    }

    public class Class2
    {
        public Class2()
        {
            Console.WriteLine("Class2 const called");
        }
    }

    public class Class3
    {
        public Class1 class1 = new Class1();
        public Class2 class2 { get; set; }

        public Class3()
        {
            Console.WriteLine("Class3 const called");
            class2 = new Class2();
        }
    }
}
