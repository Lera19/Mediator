using Mediator;
using Stages;
using Stages.Manufacturing;
using System;

namespace MediatorClient
{
    class Program
    {
        static void Main(string[] args)
        {
            ManagerMediator mediator = new ManagerMediator();
            Colleague production = new ProductionColleague(mediator);
            Colleague makingYoghurt = new MakingYoghurtColleague(mediator);
            Colleague package = new PackageColleague(mediator);
            Colleague transfer = new TransferColleague(mediator);

            mediator.Production = production;
            mediator.MakingYoghurt = makingYoghurt;
            mediator.Package = package;
            mediator.Transfer = transfer;

            production.Send("Order production");
            makingYoghurt.Send("Yoghurt done, ready for package");
            package.Send("Ready for transfer");
            transfer.Send("Ready order");

            Console.ReadKey();

        }
    }
}