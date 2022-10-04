using System;
namespace SpinningDiscs
{
    public class CD : BaseDisc, IOpticalDisc
    {
        // TODO: Implement your custom interface.

        // TODO: Determine which fields, methods, and constructors can be extended from the base class and which ones
        //  need to be declared separately. 
        public CD(string name, int maxCapacity, string disktype, int someUsedCapacity) : base(name, maxCapacity, disktype, someUsedCapacity)
        {
        }

        public void ReadData()
        {
            Console.WriteLine("Would you like to play a game?");
        }

        public void SpinDisc()
        {
            Console.WriteLine("A CD spins at a rate of 200 - 500 rpm.");
        }
    }
}
