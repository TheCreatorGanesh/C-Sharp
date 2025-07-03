namespace AbstractFactory_Pattern.Products
{
	// Concrete Products are created by corresponding Concrete Factories.
	public class ConcreteProductB1 : IAbstractProductB
	{
		public string UsefulFunctionB()
		{
			Console.WriteLine("ConcreteProductB1:UsefulFunctionB: called");
			return "The result of the product B1.";
		}

		// The variant, Product B1, is only able to work correctly with the
		// variant, Product A1. Nevertheless, it accepts any instance of
		// AbstractProductA as an argument.
		public string AnotherUsefulFunctionB(IAbstractProductA collaborator)
		{
			Console.WriteLine("ConcreteProductB1:AnotherUsefulFunctionB: called");
			return $"The result of the B1 collaborating with the ({collaborator.UsefulFunctionA()})";
		}
	}

	// Concrete Products are created by corresponding Concrete Factories.
	public class ConcreteProductB2 : IAbstractProductB
	{
		public string UsefulFunctionB()
		{
			Console.WriteLine("ConcreteProductB2:UsefulFunctionB: called");
			return "The result of the product B2.";
		}

		// The variant, Product B2, is only able to work correctly with the
		// variant, Product A2. Nevertheless, it accepts any instance of
		// AbstractProductA as an argument.
		public string AnotherUsefulFunctionB(IAbstractProductA collaborator)
		{
			Console.WriteLine("ConcreteProductB2:AnotherUsefulFunctionB: called");
			return $"The result of the B2 collaborating with the ({collaborator.UsefulFunctionA()})";
		}
	}
}
