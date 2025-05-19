using System;

public class Aircraft
{
    private CommandCentre commandCentre;

    public Aircraft(CommandCentre commandCentre)
    {
        this.commandCentre = commandCentre;
    }

    public void RequestLanding()
    {
        commandCentre.Notify("Літак запитує на посадку.");
    }
}
