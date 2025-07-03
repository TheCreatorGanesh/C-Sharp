namespace AbstractFactory_Pattern.FurnitureShop
{
	public class ModernChair : IChair
	{
		public ModernChair()
		{
			Console.WriteLine("Modern chair Manufactured");
		}
		public void SitOn() => Console.WriteLine("Sitting on a modern chair.");
	}
}
