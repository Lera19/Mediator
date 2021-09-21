using System;

namespace Mediator
{
    public abstract class Colleague
    {
        protected Mediator mediator;
        public Colleague(Mediator mediator)
        {
            this.mediator = mediator;
        }
        public virtual void Send(string msg)
        {
            mediator.Send(msg, this);
        }

        public abstract void Notify(string msg);

        public virtual void NotifyCustomerAboutDelivery()
        {
            Console.WriteLine("it is impossible to deliver the order ");
        }

    }
}
