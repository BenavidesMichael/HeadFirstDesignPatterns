namespace DesignPattern.Decorator.Models;

internal class SoyDecorator : CondimentDecorator
{
    public SoyDecorator(Beverage beverage)
        : base(beverage)
    {}


    public override string GetDescription() => $"{beverage.GetDescription()} + Soy";

    public override double Cost() => .30 + beverage.Cost();

}