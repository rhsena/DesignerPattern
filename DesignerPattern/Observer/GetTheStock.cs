using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DesignerPattern.Observer
{
    public class GetTheStock 
    {
        private int StartTime;
        private string Stock;
        private double Price;

        private Subject stockGrabber;
        private volatile bool _shouldStop;

        public GetTheStock(Subject stockGrabber, int newStartTime, string newStock, double newPrice)
        {
            this.stockGrabber = stockGrabber;
            this.StartTime = newStartTime;
            this.Stock = newStock;
            this.Price = newPrice;
        }

        public void DoWork()
        {
            for (int i = 1; i <=20; i++)
            {
                try
                {
                    Thread.Sleep(2000);
                }
                catch (ThreadInterruptedException e)
                {
                    Console.WriteLine(e);
                }
                Random random = new Random();
                double radNum = (random.NextDouble() * (.07)) - .04;
                radNum = Math.Truncate(radNum * 100) / 100;
                Price = Price + radNum;
                if (Stock == "IBM") ((StockGrabber)stockGrabber).setIBMPrice(Price);
                if (Stock == "AAPL") ((StockGrabber)stockGrabber).setAAPLPrice(Price);
                if (Stock == "GOOG") ((StockGrabber)stockGrabber).setGOOGPrice(Price);
                Console.WriteLine(" ");
            }
        }

        public void RequestStop()
        {
            _shouldStop = true;
        }
    }
}
