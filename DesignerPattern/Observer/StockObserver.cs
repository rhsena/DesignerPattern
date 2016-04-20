using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignerPattern.Observer
{
    public class StockObserver : Observer
    {
        private double IbmPrice;
        private double AaplPrice;
        private double GoogPrice; 

        private static int ObserverIDTracker = 0;

        private int ObserverID;

        private Subject StockGrabber;

        public StockObserver(Subject stockGrabber)
        {
            this.StockGrabber = stockGrabber;
            this.ObserverID = ++ObserverIDTracker;
            Console.WriteLine("New Observer " + this.ObserverID);
            StockGrabber.Register(this);
        }

        public void Update(double ibmPrice, double aaplPrice, double googPrice)
        {
            this.IbmPrice = ibmPrice;
            this.AaplPrice = aaplPrice;
            this.GoogPrice = googPrice;
            printThePrices();
        }

        public void printThePrices()
        {
            Console.WriteLine(ObserverID);
            Console.WriteLine("IBM: " + IbmPrice);
            Console.WriteLine("AAPL: " + AaplPrice);
            Console.WriteLine("Goog: " + GoogPrice);
        }
    }
}
