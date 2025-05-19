using System;

public class Runway
{
    private CommandCentre commandCentre;

    public Runway(CommandCentre commandCentre)
    {
        this.commandCentre = commandCentre;
    }

    public void ReadyForLanding()
    {
        commandCentre.Notify("Вільна смуга для посадки.");
    }
}
