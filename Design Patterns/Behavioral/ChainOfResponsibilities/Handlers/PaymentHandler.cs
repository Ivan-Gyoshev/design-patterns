using ChainOfResponsibilities.Contracts;

namespace ChainOfResponsibilities.Handlers
{
    class PaymentHandler : HandlerBase
    {
        public override object Handle(object request)
        {
            if (request.ToString().Equals("Payment approved!"))
                return "Order processed successfully";

            return base.Handle(request);
        }
    }
}
