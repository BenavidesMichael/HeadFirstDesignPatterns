namespace DesignPattern.Observer.Models
{
    // Subject
    public class WeatherData : IObservable<Weather>
    {
        List<IObserver<Weather>> _weatherOservers = new();

        public Weather GetMesures()
        {
            return new Weather() 
            {
                Temperature = new Random().Next(10, 30),
                Humidity = new Random().Next(40, 100),
                Pressure = new Random().Next(900, 1000)
            };
        }

        public IDisposable Subscribe(IObserver<Weather> observer)
        {

            if (!_weatherOservers.Contains(observer))
                _weatherOservers.Add(observer);

            return new Unsubscriber(_weatherOservers, observer);
        }

        public void Notify()
        {
            _weatherOservers.ForEach(x => x.OnNext(GetMesures()));
        }


        public void End()
        {
            foreach (var observer in _weatherOservers.ToArray())
            {
                if (_weatherOservers.Contains(observer))
                    observer.OnCompleted();
            }
            _weatherOservers.Clear();
        }
    }
}
