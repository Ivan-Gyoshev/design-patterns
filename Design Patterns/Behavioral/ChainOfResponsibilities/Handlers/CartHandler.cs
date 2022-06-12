using ChainOfResponsibilities.Contracts;

namespace ChainOfResponsibilities.Handlers
{
    class CartHandler : HandlerBase
    {
        public override object Handle(object request)
        {
            if ((request as string).Equals("Item added"))
                return "Item has been added to cart.";

            return base.Handle(request);
        }
    }
}
