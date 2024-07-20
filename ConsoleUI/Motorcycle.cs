using System;

namespace ConsoleUI;

public class Motorcycle : Vehicle
{
    // Add a distinct property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
    //     * Provide the implementations for the abstract methods
    //     * Only in the Motorcycle class will you override the virtual drive method
    public bool HasSideCart { get; set; }

    public override void DriveAbstract()
    {
        Console.WriteLine("Motorcycle is moving abstractly.");
    }

    public override void DriveVirtual()
    {
        Console.WriteLine("Motorcycle is moving virtually.");
    }
}