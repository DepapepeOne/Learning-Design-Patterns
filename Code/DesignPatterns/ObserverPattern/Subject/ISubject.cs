using ObserverPattern.Observer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Subject
{
    public interface ISubject
    {
        void RegisterObserver(IObserver o);

        void RemoveObserver(IObserver o);

        void NotifyObservers();
    }
}
