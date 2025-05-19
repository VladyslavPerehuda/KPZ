public class Sword : HeroDecorator
{
    public Sword(IHero hero) : base(hero) { }

    public override string GetDescription() => _hero.GetDescription() + ", wielding a Sword";
    public override int GetPower() => _hero.GetPower() + 5;
}