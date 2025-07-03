namespace AbstractFactory_Pattern.FurnitureShop
{
	// Abstract Factory
	public interface IFurnitureFactory
	{
		IChair CreateChair();
		ISofa CreateSofa();
	}
}
