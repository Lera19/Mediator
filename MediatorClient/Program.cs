using Mediator;
using Mediator.Colleagues;
using System;

namespace MediatorClient
{
    class Program
    {
        static void Main(string[] args)
        {
            ManagerMediator mediator = new ManagerMediator();

            Colleague client = new ClientColleague(mediator);
            Colleague factory = new FactoryColleague(mediator);

            mediator.ClientColleague = client;
            mediator.FactoryColleague = factory;

            mediator.Notify("100");

            Console.ReadKey();
        }
    }
}