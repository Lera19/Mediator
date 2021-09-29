//using Mediator;
//using System;

//namespace Models
//{
//    public abstract class Factory 
//    {
//        public string _factory;
//        protected ManagerMediator _mediator;
//        public Factory(ManagerMediator mediator)
//        {
//            _mediator = mediator;
//        }
//        public string Id { get; set; }
//        public string Name { get; set; }
//        public Yoghurt Yoghurt { get; set; }


//        public void RequirementsFromMediator(ClientColleague client)
//        {
//            Console.WriteLine(this._factory + "has received requirements from" +client.Name);
//        }

//        public void SendQueryToMediator()
//        {
//            _mediator.NotifyFromFactory("received query from" + this._factory);
//        }
//    }

//    public class FactoryColleague : Factory
//    {
//        public FactoryColleague(ManagerMediator mediator) : base(mediator)
//        { }
//    }
//}
