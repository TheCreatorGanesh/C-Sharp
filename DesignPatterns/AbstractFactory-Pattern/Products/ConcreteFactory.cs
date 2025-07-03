namespace AbstractFactory_Pattern.Products
{
	// Concrete Factories produce a family of products that belong to a single
	// variant. The factory guarantees that resulting products are compatible.
	// Note that signatures of the Concrete Factory's methods return an abstract
	// product, while inside the method a concrete product is instantiated.
	public class ConcreteFactory1 : IAbstractFactory
	{
		public IAbstractProductA CreateProductA()
		{
			Console.WriteLine("ConcreteFactory1:CreateProductA: Creating product A1.");
			return new ConcreteProductA1();
		}

		public IAbstractProductB CreateProductB()
		{
			Console.WriteLine("ConcreteFactory1:CreateProductB: Creating product B1.");
			return new ConcreteProductB1();
		}
	}

	// Each Concrete Factory has a corresponding product variant.
	public class ConcreteFactory2 : IAbstractFactory
	{
		public IAbstractProductA CreateProductA()
		{
			Console.WriteLine("ConcreteFactory2:CreateProductA: Creating product A2.");
			return new ConcreteProductA2();
		}

		public IAbstractProductB CreateProductB()
		{
			Console.WriteLine("ConcreteFactory2:CreateProductB: Creating product B2.");
			return new ConcreteProductB2();
		}
	}
}
