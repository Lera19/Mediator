using Mediator;
using System;

namespace Stages.Manufacturing
{
    public class MakingYoghurtColleague : Colleague
    {
        public MakingYoghurtColleague(ManagerMediator mediator) :base(mediator)
        { }
        public override void Notify(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}
