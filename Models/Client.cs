//using Mediator;

//namespace Models
//{
//    public abstract class Client
//    {
//        protected ManagerMediator _mediator;
//        public Client(ManagerMediator mediator)
//        {
//            _mediator = mediator;
//        }
//        public string Id { get; set; }
//        public string Name { get; set; }
//        public Order Order { get; set; }
//        public string Email { get; set; }

//        public void SendRequirementsTomediator()
//        {
//            _mediator.NotifyFromClient();
//        }

//    }

//    public class ClientColleague : Client
//    {
//        public ClientColleague(ManagerMediator mediator): base(mediator)
//        { }
//    }
//}
