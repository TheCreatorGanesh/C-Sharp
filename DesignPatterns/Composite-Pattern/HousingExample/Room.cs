namespace Composite_Pattern.HousingExample
{
    public class Room : IStructure
    {
        public string name { get; set; }

        public Room(string name)
        {
            this.name = name;
        }

        public void enter()
        {
            Console.WriteLine($"You have entered the {name}.");
        }

        public void exit()
        {
            Console.WriteLine($"You have left the {name}.");
        }

        public void location()
        {
            Console.WriteLine($"You are currently in {name}.");
        }

        public string getName()
        {
            return name;
        }
    }
}
