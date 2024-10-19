using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.BehavioralPattern.ObserverPattern
{
    /*
     Key Concepts of the Observer Pattern:
    Subject: The object that maintains a list of its observers and notifies them of state changes.
    Observer: An object that wishes to be notified when the subject's state changes. 
              The observer registers itself with the subject to receive updates.
    Loose Coupling: The subject does not need to know the specific implementation of the observers; 
                    it just knows that they implement a common interface.
     */
    public interface ISubject
    {
        void RegisterObserver(IObserver observer);
        void RemoveObserver(IObserver observer);
        void NotifyObservers();
    }

}
