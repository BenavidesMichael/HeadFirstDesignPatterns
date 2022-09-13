namespace DesignPattern.Decorator.Models;

internal abstract class CondimentDecorator : Beverage
{
    protected Beverage beverage;
    public CondimentDecorator(Beverage beverage)
    {
        this.beverage = beverage;
    }

    public override double Cost() => 0;

    public override string GetDescription() => base.GetDescription();
}
