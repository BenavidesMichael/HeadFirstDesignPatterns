namespace DesignPattern.Decorator.Models;

internal class Espresso : Beverage
{
    public override void Cost()
    {
        Console.WriteLine("Espresso cost 40");
    }
}
