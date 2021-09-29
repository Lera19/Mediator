using System;

namespace Mediator.Colleagues
{
    public class ClientColleague : Colleague
    {
        public ClientColleague(ManagerMediator mediator) : base(mediator)
        {
        }
        public override void SendByEmail(string msg)
        {
            Console.WriteLine("Email from factory: Order from " + msg + "count yoghurt");
        }
    }
}