using DesignerPattern.Observer;
using DesignerPattern.Strategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DesignerPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            #region Strategy
                Animal borsalino = new Cachorro();
                Animal copia = new Passaro();

                Console.WriteLine("Borsalino " + borsalino.TentarVoar() + " Moshi-Moshi");
                Console.WriteLine("Copia " + copia.TentarVoar() + " Pablo Pó");
                borsalino.setHabilidadeVoar(new Voa());
                copia.setHabilidadeVoar(new NaoVoa());
                Console.WriteLine("Borsalino " + borsalino.TentarVoar() + " Moshi-Moshi");
                Console.WriteLine("Copia " + copia.TentarVoar() + " Pablo Pó");
                Console.ReadLine();
            #endregion

            # region Observer
                StockGrabber stockGrabber = new StockGrabber();
                StockObserver observer1 = new StockObserver(stockGrabber);

                stockGrabber.setIBMPrice(197.00);
                stockGrabber.setAAPLPrice(677.60);
                stockGrabber.setGOOGPrice(676.40);

                StockObserver observer2 = new StockObserver(stockGrabber);
                stockGrabber.Unregister(observer2);

                GetTheStock getStockIBM = new GetTheStock(stockGrabber, 2 , "IBM", 197.00);
                GetTheStock getStockAPPL = new GetTheStock(stockGrabber, 2, "AAPL", 677.60);
                GetTheStock getStockGOOG = new GetTheStock(stockGrabber, 2, "GOOG", 676.40);

                Thread workerThreadIBM = new Thread(getStockIBM.DoWork);
                Thread workerThreadAAPL = new Thread(getStockAPPL.DoWork);
                Thread workerThreadGOOG = new Thread(getStockGOOG.DoWork);
                workerThreadIBM.Start();
                workerThreadAAPL.Start();
                workerThreadGOOG.Start();


                Console.ReadLine();
            #endregion
        }
    }
}
