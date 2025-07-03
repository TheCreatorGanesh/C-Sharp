namespace AbstractFactory_Pattern.FurnitureShop
{
	// Concrete Products for Vintage Style
	public class VintageChair : IChair
	{
		public VintageChair()
		{
			Console.WriteLine("Vintage Sofa Manufactured");
		}
		public void SitOn() => Console.WriteLine("Sitting on a vintage chair.");
	}
}
