namespace DesignPattern.Decorator.Models;

internal class Decaf : Beverage
{
    public override void Cost()
    {
        Console.WriteLine("Decaf cost 30");
    }
}
