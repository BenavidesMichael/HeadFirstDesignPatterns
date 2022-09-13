namespace DesignPattern.Decorator.Models;

internal abstract class Beverage
{
    public string _description = "Unknown Beverage";

    public virtual string GetDescription() => _description;

    public abstract double Cost();
}

