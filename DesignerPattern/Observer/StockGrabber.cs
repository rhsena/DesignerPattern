using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignerPattern.Observer
{
    public class StockGrabber : Subject
    {
        private IList<Observer> observers;
        private double ibmPrice;
        private double aaplPrice;
        private double googPrice;

        public StockGrabber()
        {
            observers = new List<Observer>();
        }

        public void Register(Observer newObserver)
        {
            observers.Add(newObserver);
        }

        public void Unregister(Observer deleteObserver)
        {
            //observers.Remove(deleteObserver);
            int observerIndex = observers.IndexOf(deleteObserver);
            Console.WriteLine("Observer " + (observerIndex + 1) + " deleted");
            observers.RemoveAt(observerIndex);
        }

        public void NotifyObserver()
        {
            foreach(Observer observer in observers)
            {
                observer.Update(ibmPrice, aaplPrice, googPrice);
            }
        }

        public void setIBMPrice(double newIbmPrice)
        {
            this.ibmPrice = newIbmPrice;
            NotifyObserver();
        }
        public void setAAPLPrice(double newAaplPrice)
        {
            this.aaplPrice = newAaplPrice;
            NotifyObserver();
        }
        public void setGOOGPrice(double newGoogPrice)
        {
            this.googPrice = newGoogPrice;
            NotifyObserver();
        }
    }
}
