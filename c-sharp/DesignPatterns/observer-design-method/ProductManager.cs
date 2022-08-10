using System.Collections.Generic;

namespace observer_design_method
{
    public class ProductManager
    {
        private List<Observer> _observers = new List<Observer>();
        public void UpdatePrice()
        {
            Notify();
        }

        public void Notify()
        {
            foreach (Observer observer in _observers)
                observer.Update();
        }

        public void Attach(Observer observer)
        {
            _observers.Add(observer);
        }

        public void Detach(Observer observer)
        {
            if (_observers.Contains(observer))
                _observers.Remove(observer);
        }
    }
}
