namespace VirtualMethods
{
    public class BaseClass
    {
        public virtual void Print()
        {
            Console.WriteLine("BASE: Print()");
        }

        public void Printing()
        {
            Console.WriteLine("BASE: Printing()");
        }

    }

    public class DerivedClass : BaseClass
    {
        public override void Print()
        {
            Console.WriteLine("DERIVED: Print()");
        }

        public void Printing()
        {
            Console.WriteLine("DERIVED: Printing()");
        }

    }
}