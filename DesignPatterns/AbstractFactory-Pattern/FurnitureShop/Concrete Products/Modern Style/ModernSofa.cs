namespace AbstractFactory_Pattern.FurnitureShop
{
	public class ModernSofa : ISofa
	{
		public ModernSofa()
		{
			Console.WriteLine("Modern Sofa Manufactured");
		}
		public void LayOn() => Console.WriteLine("Laying on a modern sofa.");

	}
}
