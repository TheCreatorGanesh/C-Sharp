
namespace ConsoleApp
{
    using VirtualMethods;

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            VirtualMethods();
        }

        static void VirtualMethods()
        {
            BaseClass baseClass = new BaseClass();
            baseClass.Print();
            baseClass.Printing();
            Console.WriteLine("");

            BaseClass derived = new DerivedClass();
            derived.Print();
            derived.Printing();
            Console.WriteLine("");

            BaseClass derived1 = (BaseClass)new DerivedClass();
            (derived1).Print();
            (derived1).Printing();

            /* OUTPUT *
             

            BASE: Print()
            BASE: Printing()

            DERIVED: Print()
            BASE: Printing()

            DERIVED: Print()
            BASE: Printing()


            /* OUTPUT */
        }
    }
}