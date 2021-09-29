using System.Timers;

namespace Mediator.Production
{
    public class ProductionYoghurt : IProduction
    {
        public void Production()
        {
            Timer timer = new Timer(2000);
            timer.Start();
            MakingYoghurt();
            timer.Start();
            Packages();
            timer.Start();
            SendingToTheWarehouse();
        }
        public void MakingYoghurt()
        { }

        public void Packages()
        { }

        public void SendingToTheWarehouse()
        { }
    }
}
