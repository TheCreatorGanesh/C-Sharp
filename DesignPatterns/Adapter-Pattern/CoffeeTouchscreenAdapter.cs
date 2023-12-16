namespace Adapter_Pattern
{

    public class CoffeeTouchscreenAdapter : ICoffeeMachine
    {

        OldCoffeeMachine theMachine;

        public CoffeeTouchscreenAdapter(OldCoffeeMachine newMachine)
        {
            theMachine = newMachine;
        }

        public void chooseFirstSelection()
        {
            theMachine.selectA();
        }

        public void chooseSecondSelection()
        {
            theMachine.selectB();
        }
    }
}