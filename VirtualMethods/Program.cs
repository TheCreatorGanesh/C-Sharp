// See https://aka.ms/new-console-template for more information
using VirtualMethods;


VirtualMethods();

static void VirtualMethods()
{
	Console.WriteLine("BaseClass reference with BaseClass object");
	BaseClass baseClass = new BaseClass();
	baseClass.Print();
	baseClass.Printing();
	Console.WriteLine("");

	Console.WriteLine("BaseClass reference with DerivedClass object");
	BaseClass derived = new DerivedClass();
	derived.Print();
	derived.Printing();
	Console.WriteLine("");

	Console.WriteLine("BaseClass reference with DerivedClass object casted to BaseClass type");
	BaseClass derived1 = (BaseClass)new DerivedClass();
	derived1.Print();
	derived1.Printing();
	Console.WriteLine("");

	/* OUTPUT *
	  
	  
		BaseClass reference with BaseClass object
		BASE: Print() - virtual method
		BASE: Printing()

		BaseClass reference with DerivedClass object
		DERIVED: Print() - override method
		BASE: Printing()

		BaseClass reference with DerivedClass object casted to BaseClass type
		DERIVED: Print() - override method
		BASE: Printing()


	/* OUTPUT */
}