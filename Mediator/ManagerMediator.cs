using Mediator.Models;
using Mediator.Production;
using System;
using System.Collections.Generic;

namespace Mediator
{
    public class ManagerMediator : Mediator
    {
        public Colleague ClientColleague { get; set; }
        public Colleague FactoryColleague { get; set; }

        public List<Client> client = new List<Client>()
        {
            new Client(){ Id = Guid.NewGuid().ToString(), Name="Client1",
                Order = new Order() { CountYoghurt = 100, Price = 2000 }}
        };
        private List<Factory> factories = new List<Factory>()
        {
            new Factory(){Id = Guid.NewGuid().ToString(), Name="Factory 1", 
                Yoghurt=new Yoghurt(){ NameYoghurt = "KLO", Price = 15, Description = "Good" }}
        };


        public override void Notify(string msg, Colleague colleague)
        {
            
            ClientColleague.SendByEmail(msg);
                if (ComparisonPriceForOrderSmaller(client.Find(c => c.Order.Price == 2000), factories.Find(c => c.Yoghurt.NameYoghurt == "KLO")) == true
                    && CheckingParameterYoghurt(factories.Find(c => c.Yoghurt.NameYoghurt == "KLO"), "with lactose") == false)
                    {
                        IProduction prod = new ProductionYoghurt();
                        prod.MakingYoghurt();
                        prod.Packages();
                        prod.SendingToTheWarehouse();

                        FactoryColleague.SendByEmail("Order is ready");
                    }
                else
                {
                    FactoryColleague.SendByEmail("Sorry we can't doing this order");
                }
                
            }


        public bool ComparisonPriceForOrderSmaller(Client client , Factory factory)
        {
            var result = factory.Yoghurt.Price * client.Order.CountYoghurt <= client.Order.Price;
            return result;

        }

        public bool CheckingParameterYoghurt(Factory factory, string parameter)
        {
            var result = factory.Yoghurt.Description.Contains(parameter);
            return result;

        }

    }
}