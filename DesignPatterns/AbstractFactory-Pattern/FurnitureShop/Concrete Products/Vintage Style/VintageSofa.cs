namespace AbstractFactory_Pattern.FurnitureShop
{
	public class VintageSofa : ISofa
	{
		public VintageSofa()
		{
			Console.WriteLine("Vintage Sofa Manufactured");
		}
		public void LayOn() => Console.WriteLine("Laying on a vintage sofa.");
	}
}
