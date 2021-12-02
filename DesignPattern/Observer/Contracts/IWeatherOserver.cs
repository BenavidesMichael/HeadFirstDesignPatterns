namespace DesignPattern.Observer.Contracts
{
    public interface IWeatherOserver<T>
    {
        void Subscribe(IObservable<T> provider);
        void Unsubscribe();
    }
}
