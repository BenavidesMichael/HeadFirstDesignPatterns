namespace DesignPattern.Observer.Models
{
    internal class Unsubscriber : IDisposable
    {
        private IList<IObserver<Weather>> _observers;
        private IObserver<Weather> _observer;

        
        public Unsubscriber(IList<IObserver<Weather>> observers, IObserver<Weather> observer)
        {
            this._observers = observers;
            this._observer = observer;
        }

        public void Dispose()
        {
            if (!(_observer == null)) _observers.Remove(_observer);
        }

    }
}
