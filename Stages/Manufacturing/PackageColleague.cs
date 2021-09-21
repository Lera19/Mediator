using Mediator;
using System;

namespace Stages.Manufacturing
{
    public class PackageColleague : Colleague
    {
        public PackageColleague(ManagerMediator mediator) :base(mediator)
        { }
        public override void Notify(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}
