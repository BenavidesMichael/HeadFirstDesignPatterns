namespace DesignPattern.Decorator.Models;

internal class Espresso : Beverage
{
    public Espresso()
    {
        _description = "Expresso";
    }    

    public override double Cost() => 1.99;
}
