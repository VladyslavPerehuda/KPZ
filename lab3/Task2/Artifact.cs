public class Artifact : HeroDecorator
{
    public Artifact(IHero hero) : base(hero) { }

    public override string GetDescription() => _hero.GetDescription() + ", holding an Artifact";
    public override int GetPower() => _hero.GetPower() + 7;
}