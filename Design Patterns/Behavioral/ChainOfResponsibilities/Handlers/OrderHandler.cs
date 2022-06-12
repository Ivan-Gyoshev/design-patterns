using ChainOfResponsibilities.Contracts;

namespace ChainOfResponsibilities.Handlers
{
    class OrderHandler : HandlerBase
    {
        public override object Handle(object request)
        {
            if (request.ToString().Equals("Order approved"))
                return "Continue to payment..";

            return base.Handle(request);
        }
    }
}
