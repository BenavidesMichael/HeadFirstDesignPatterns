namespace DesignPattern.Decorator.Models;

internal class MochaDecorator : CondimentDecorator
{
    public MochaDecorator(Beverage beverage)
        : base(beverage)
    {}


    public override string GetDescription() => $"{beverage.GetDescription()} + Mocha";

    public override double Cost() => .20 + beverage.Cost();

}