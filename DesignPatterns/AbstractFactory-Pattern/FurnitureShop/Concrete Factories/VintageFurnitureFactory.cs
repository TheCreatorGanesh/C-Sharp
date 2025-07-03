namespace AbstractFactory_Pattern.FurnitureShop.Concrete_Factories
{
	public class VintageFurnitureFactory : IFurnitureFactory
	{
		public VintageFurnitureFactory()
		{
			Console.WriteLine("Vintage Furniture factory Started");
		}
		public IChair CreateChair() => new VintageChair();
		public ISofa CreateSofa() => new VintageSofa();
	}
}
