using Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Mediator
{
    public class ManagerMediator : Mediator
    {
        public Colleague Production { get; set; }
        public Colleague MakingYoghurt { get; set; }
        public Colleague Package { get; set; }
        public Colleague Transfer { get; set; }

        public List<Order> orders = new List<Order>()
        {
                new Order() {Id = Guid.NewGuid().ToString(), CountYoghurt = 100, Price = 2000 }
        };
        private List<Yoghurt> yoghurts = new List<Yoghurt>()
        {
                new Yoghurt(){ Id = Guid.NewGuid().ToString(), NameYoghurt = "KLO", Price = 15, Description = "Good" }
        };


        public bool ComparisonPriceForOrderSmaller(Order order, Yoghurt yoghurt)
        {

            var result = yoghurt.Price * order.CountYoghurt <= order.Price;
            return result;

        }

        public bool CheckingParameterYoghurt(Yoghurt yoghurt)
        {
            string parameter = "with lactose";
            var result = yoghurt.Description.Contains(parameter);
            return result;

        }


        public override void Send(string msg, Colleague colleague)
        {
            if (ComparisonPriceForOrderSmaller(orders.First(), yoghurts.First()))
            {
                if (CheckingParameterYoghurt(yoghurts.First()) == false)
                {
                    if (Production == colleague)
                    {
                        MakingYoghurt.Notify(msg);
                    }
                    else if (MakingYoghurt == colleague)
                    {
                        Package.Notify(msg);
                    }
                    else if (Package == colleague)
                    {
                        Transfer.Notify(msg);
                    }
                    else if (Transfer == colleague)
                    {
                        Production.Notify(msg);
                    }
                }
                else
                {
                    Production.NotifyCustomerAboutDelivery();
                }
            }
            else
            {
                Production.NotifyCustomerAboutDelivery();
            }
        }
    }
}