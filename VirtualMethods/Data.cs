namespace VirtualMethods
{
	public class BaseClass
	{
		public virtual void Print()
		{
			Console.WriteLine("BASE: Print() - virtual method");
		}

		public void Printing()
		{
			Console.WriteLine("BASE: Printing()");
		}

	}

	public class DerivedClass : BaseClass
	{
		public override void Print()
		{
			Console.WriteLine("DERIVED: Print() - override method");
		}

		public void Printing()
		{
			Console.WriteLine("DERIVED: Printing()");
		}

	}
}
