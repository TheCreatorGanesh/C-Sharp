namespace Composite_Pattern.HousingExample
{
    public class Housing : IStructure
    {
        private List<IStructure> structures { get; set; }
        private string address { get; set; }

        public Housing(string address)
        {
            structures = new List<IStructure>();
            this.address = address;
        }

        public string getName()
        {
            return address;
        }

        public int addStructure(IStructure component)
        {
            structures.Add(component);
            return structures.Count() - 1;
        }

        public void location()
        {
            Console.WriteLine($"You are currently in {getName()}. It has ");
            foreach (var structure in structures)
            {
                Console.WriteLine(structure.getName());
            }
        }

        public IStructure getStructure(int componentNumber)
        {
            return structures[componentNumber];
        }

        public void enter()
        {
            Console.WriteLine($"Entering the House {address} !!");
        }

        public void exit()
        {
            Console.WriteLine($"Exited the House {address} !!");
        }
    }
}