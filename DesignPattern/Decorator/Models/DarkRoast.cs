namespace DesignPattern.Decorator.Models;

internal class DarkRoast : Beverage
{
    public DarkRoast()
    {
        _description = "Most Excellent Dark Roast";
    }


    public override double Cost() => 2.80;

}
