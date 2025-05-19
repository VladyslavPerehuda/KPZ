using System;

class Program
{
    static void Main(string[] args)
    {
        
        IHero warrior = new Warrior();
        Console.WriteLine(warrior.GetDescription() + " with power " + warrior.GetPower());

        
        IHero warriorWithSword = new Sword(warrior);
        Console.WriteLine(warriorWithSword.GetDescription() + " with power " + warriorWithSword.GetPower());

        
        IHero warriorWithSwordAndArmor = new Armor(warriorWithSword);
        Console.WriteLine(warriorWithSwordAndArmor.GetDescription() + " with power " + warriorWithSwordAndArmor.GetPower());

        
        IHero warriorFullyEquipped = new Artifact(warriorWithSwordAndArmor);
        Console.WriteLine(warriorFullyEquipped.GetDescription() + " with power " + warriorFullyEquipped.GetPower());

        
        IHero mage = new Mage();
        IHero mageWithArtifact = new Artifact(mage);
        Console.WriteLine(mageWithArtifact.GetDescription() + " with power " + mageWithArtifact.GetPower());
    }
}