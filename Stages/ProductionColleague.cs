using Mediator;
using System;


namespace Stages
{
    public class ProductionColleague : Colleague
    {
        public ProductionColleague(ManagerMediator mediator) :base(mediator)
        { }
        public override void Notify(string msg)
        {
            Console.WriteLine(msg);
        }  
    }
}
