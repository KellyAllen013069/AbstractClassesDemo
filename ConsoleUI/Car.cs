using System;

namespace ConsoleUI;

public class Car : Vehicle
{
    // Add a distinct property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
    //     * Provide the implementations for the abstract methods

    public bool HasTrunk { get; set; }

    public override void DriveAbstract()
    {
        Console.WriteLine("Car is moving!");
    }    
}