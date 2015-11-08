using System.Collections;

namespace DesignStrategies.Observer.Canonical
{
    public abstract class Subject
    {
        private readonly ArrayList _observers = new ArrayList();

        protected void NotifyObservers()
        {
            foreach (IObserver observer in _observers)
                observer.Update();
        }

        public void RegisterObserver(IObserver observer)
        {
            _observers.Add(observer);
        }
    }
}
