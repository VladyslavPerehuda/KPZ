using System;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        CommandCentre commandCentre = new CommandCentre();
        Aircraft aircraft = new Aircraft(commandCentre);
        Runway runway = new Runway(commandCentre);

        aircraft.RequestLanding();
        runway.ReadyForLanding();

        Console.ReadKey();
    }
}
