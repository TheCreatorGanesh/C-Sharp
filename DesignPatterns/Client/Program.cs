using Composite_Pattern.HousingExample;

namespace Client
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            compositePattern();
        }

        static void whenObjectVariablesAreInitialised()
        {
            Class3 class3 = null;
            if ((class3) is object)
            {

            }
        }

        static void compositePattern()
        {
            Housing building = new Housing("123 street");
            Housing floor1 = new Housing("123 street - 1st floor");

            int firstFloor = building.addStructure(floor1);

            Room washroomMen = new Room("1F Male washroom");
            Room washroomWomen = new Room("1F Fe-Male washroom");
            Room common1 = new Room("1F Common Area");

            int firstMens = floor1.addStructure(washroomMen);
            int firstWoMens = floor1.addStructure(washroomWomen);
            int firstCommon = floor1.addStructure(common1);

            building.enter();   //Enter the building
            Housing currentFloor = (Housing)building.getStructure(firstFloor);
            currentFloor.enter();   //Walk into the First Floor
            Room currentRoom = (Room)currentFloor.getStructure(firstMens);
            currentRoom.enter();    //Walk into Men's Room (washroom)
            currentRoom.exit();    //Exiting Men's Room (washroom)
            currentRoom = (Room)currentFloor.getStructure(firstCommon);
            currentRoom.enter();//Walk into common area

        }
    }
}