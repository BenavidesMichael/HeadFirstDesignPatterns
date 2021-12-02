using DesignPattern.Observer.Contracts;
using DesignPattern.Observer.Models;

namespace DesignPattern.Observer.Behavior
{
    public class CurrentWeather : IObserver<Weather>, IWeatherOserver<Weather>
    {
        IDisposable? _unsubscriber;
        string _nameObserver;

        public CurrentWeather(string nameObserver)
        {
            _nameObserver = nameObserver;
        }

        public virtual void Subscribe(IObservable<Weather> provider)
        {
            if (provider != null)
            {
                Console.WriteLine($"{_nameObserver} Subscribe");
                _unsubscriber = provider.Subscribe(this);
            }
        }


        // Permet à l'observateur d'arrêter de recevoir des notifications
        public virtual void Unsubscribe()
        {
            Console.WriteLine($"{_nameObserver} Unsubscribe");
            Console.WriteLine();

            _unsubscriber?.Dispose();
        }


        public void OnCompleted()
        {
            Console.WriteLine($"{nameof(CurrentWeather)} complete");
            Console.WriteLine("Additional temperature data will not be transmitted.");
            Console.WriteLine();

            this.Unsubscribe();
        }

        public void OnError(Exception error)
        {
            Console.WriteLine($"{nameof(CurrentWeather)} error");
        }

        public void OnNext(Weather value)
        {
            Console.WriteLine($"{_nameObserver} ({nameof(StatisticsWeather)}) - The temperature is {value.Temperature}°C and humidity {value.Humidity}");
        }
    }
}
