using System;
using System.Collections.Generic;

public class Character
{
    public int Height { get; set; }
    public string HairColor { get; set; }
    public List<string> Clothes { get; set; } = new List<string>();
    public List<string> Inventory { get; set; } = new List<string>();
    public List<string> Deeds { get; set; } = new List<string>();

    public override string ToString()
    {
        return "Height: " + Height + ", Hair: " + HairColor + ", Clothes: " + string.Join(", ", Clothes) + ", Inventory: " + string.Join(", ", Inventory) + ", Deeds: " + string.Join(", ", Deeds);
    }
}

public interface ICharacterBuilder
{
    ICharacterBuilder SetHeight(int height);
    ICharacterBuilder SetHairColor(string color);
    ICharacterBuilder AddClothes(string clothes);
    ICharacterBuilder AddInventory(string item);
    ICharacterBuilder AddDeed(string deed);
    Character Build();
}

public class HeroBuilder : ICharacterBuilder
{
    private Character _character = new Character();

    public ICharacterBuilder SetHeight(int height)
    {
        _character.Height = height;
        return this;
    }

    public ICharacterBuilder SetHairColor(string color)
    {
        _character.HairColor = color;
        return this;
    }

    public ICharacterBuilder AddClothes(string clothes)
    {
        _character.Clothes.Add(clothes);
        return this;
    }

    public ICharacterBuilder AddInventory(string item)
    {
        _character.Inventory.Add(item);
        return this;
    }

    public ICharacterBuilder AddDeed(string deed)
    {
        _character.Deeds.Add(deed);
        return this;
    }

    public Character Build()
    {
        return _character;
    }
}

public class EnemyBuilder : ICharacterBuilder
{
    private Character _character = new Character();

    public ICharacterBuilder SetHeight(int height)
    {
        _character.Height = height;
        return this;
    }

    public ICharacterBuilder SetHairColor(string color)
    {
        _character.HairColor = color;
        return this;
    }

    public ICharacterBuilder AddClothes(string clothes)
    {
        _character.Clothes.Add(clothes);
        return this;
    }

    public ICharacterBuilder AddInventory(string item)
    {
        _character.Inventory.Add(item);
        return this;
    }

    public ICharacterBuilder AddDeed(string deed)
    {
        _character.Deeds.Add(deed);
        return this;
    }

    public Character Build()
    {
        return _character;
    }
}

public class CharacterDirector
{
    public Character CreateHero(ICharacterBuilder builder)
    {
        return builder
            .SetHeight(180)
            .SetHairColor("Brown")
            .AddClothes("Cape")
            .AddInventory("Sword")
            .AddDeed("Saved the village")
            .Build();
    }

    public Character CreateEnemy(ICharacterBuilder builder)
    {
        return builder
            .SetHeight(190)
            .SetHairColor("Black")
            .AddClothes("Armor")
            .AddInventory("Axe")
            .AddDeed("Burned the village")
            .Build();
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Task 5");
        CharacterDirector director = new CharacterDirector();

        ICharacterBuilder heroBuilder = new HeroBuilder();
        Character hero = director.CreateHero(heroBuilder);
        Console.WriteLine("Hero:");
        Console.WriteLine(hero);

        ICharacterBuilder enemyBuilder = new EnemyBuilder();
        Character enemy = director.CreateEnemy(enemyBuilder);
        Console.WriteLine("Enemy:");
        Console.WriteLine(enemy);

        Console.WriteLine("Press Enter to exit...");
        Console.ReadLine();
    }
}