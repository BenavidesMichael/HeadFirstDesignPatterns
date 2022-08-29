namespace DesignPattern.Decorator.Models;

internal class DarkRoast : Beverage
{
    public DarkRoast()
    {
        Description = "Most Excellent Dark Roast";
    }


    public override void Cost()
    {
        Console.WriteLine("DarkRoast cost 20");
    }
}
