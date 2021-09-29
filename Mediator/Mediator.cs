namespace Mediator
{
    public abstract class Mediator
    {
        public abstract void Notify(string msg, Colleague colleague);
    }
}
