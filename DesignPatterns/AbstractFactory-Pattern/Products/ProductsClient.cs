namespace AbstractFactory_Pattern.Products
{
	// The client code works with factories and products only through abstract
	// types: AbstractFactory and AbstractProduct. This lets you pass any
	// factory or product subclass to the client code without breaking it.
	public class ProductsClient
	{
		public readonly IAbstractFactory _factory;
		public ProductsClient(IAbstractFactory factory)
		{
			_factory = factory;
		}

		public void ClientMethod()
		{
			var productA = _factory.CreateProductA();
			var productB = _factory.CreateProductB();
			Console.WriteLine(productB.UsefulFunctionB() + "\n");
			Console.WriteLine(productB.AnotherUsefulFunctionB(productA) + "\n");
		}
	}
}
