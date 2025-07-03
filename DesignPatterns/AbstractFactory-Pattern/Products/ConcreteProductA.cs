namespace AbstractFactory_Pattern.Products
{
	// Concrete Products are created by corresponding Concrete Factories.
	class ConcreteProductA1 : IAbstractProductA
	{
		public string UsefulFunctionA()
		{
			Console.WriteLine("ConcreteProductA1:UsefulFunctionA: called");
			return "The result of the product A1.";
		}
	}

	// Concrete Products are created by corresponding Concrete Factories.
	public class ConcreteProductA2 : IAbstractProductA
	{
		public string UsefulFunctionA()
		{
			Console.WriteLine("ConcreteProductA2:UsefulFunctionA: called");
			return "The result of the product A2.";
		}
	}
}
