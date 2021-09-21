using Mediator;
using System;

namespace Stages.Manufacturing
{
    public class TransferColleague : Colleague
    {
        public TransferColleague(ManagerMediator mediator): base(mediator)
        { }
        public override void Notify(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}