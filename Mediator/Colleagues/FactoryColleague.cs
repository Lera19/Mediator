using System;

namespace Mediator.Colleagues
{
    public class FactoryColleague : Colleague
    {
        public FactoryColleague(ManagerMediator mediator) : base(mediator)
        {
        }
        public override void SendByEmail(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}
