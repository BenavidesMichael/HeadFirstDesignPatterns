#region Strategie
//Canard colvert = new Colvert();
//Console.WriteLine(colvert.EffectuerCancan());
//Console.WriteLine(colvert.EffectuerVol());
//Console.ReadLine();
#endregion Strategie



#region Observable
// using DesignPattern.Observer.Behavior;
// using DesignPattern.Observer.Models;

// Console.WriteLine("--------- Observer ---------");
// var subject = new WeatherData();
// var observer = new CurrentWeather("Observer 1");
// var observer2 = new CurrentWeather("Observer 2");

// observer.Subscribe(subject);
// observer2.Subscribe(subject);

// subject.Notify();

// observer.Unsubscribe();

// subject.Notify();

// subject.End();
// Console.ReadLine();
#endregion Observable




#region Decorator
using DesignPattern.Decorator.Models;

Beverage beverage = new Espresso();
beverage = new MochaDecorator(beverage);
beverage = new MochaDecorator(beverage);

System.Console.WriteLine($"{beverage.GetDescription()} : { beverage.Cost() }") ;
#endregion Decorator
