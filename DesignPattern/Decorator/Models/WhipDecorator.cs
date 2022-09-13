namespace DesignPattern.Decorator.Models;

internal class WhipDecorator : CondimentDecorator
{
    public WhipDecorator(Beverage beverage)
        : base(beverage)
    {}


    public override string GetDescription() => $"{beverage.GetDescription()} + Whip";

    public override double Cost() => .50 + beverage.Cost();

}