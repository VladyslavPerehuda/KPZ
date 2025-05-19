public class Armor : HeroDecorator
{
    public Armor(IHero hero) : base(hero) { }

    public override string GetDescription() => _hero.GetDescription() + ", wearing Armor";
    public override int GetPower() => _hero.GetPower() + 3;
}