namespace AbstractFactory_Pattern.FurnitureShop.Concrete_Factories
{
	public class ModernFurnitureFactory : IFurnitureFactory
	{
		public ModernFurnitureFactory()
		{
			Console.WriteLine("Modern Furniture factory Started");
		}
		public IChair CreateChair() => new ModernChair();
		public ISofa CreateSofa() => new ModernSofa();
	}
}
