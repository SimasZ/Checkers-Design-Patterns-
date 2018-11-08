using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Checkers.Checker.Observer;

namespace Checkers.Net
{
	[Serializable]
	class NetListener
    {
        List<Observer> observerCollection = new List<Observer>();

        public void EndTurnEvent()
        {
            //Some end turn event
        }

        public void RegisterObserver(Observer observer)
        {
            observerCollection.Add(observer);
        }

        public void UnregisterObserver(Observer observer)
        {
            observerCollection.Remove(observer);
        }

        public void NotifyObservers()
        {
            foreach(Observer observer in observerCollection)
            {
                observer.Update();
            }
        }
    }
}
