namespace Mediator
{
    public abstract class Colleague
    {
        protected Mediator mediator;
        public Colleague(Mediator mediator)
        {
            this.mediator = mediator;
        }
        public virtual void SendByEmail(string msg)
        {
            mediator.Notify(msg);
        }
    }
}
