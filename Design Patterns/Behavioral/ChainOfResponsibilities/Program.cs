using ChainOfResponsibilities.Handlers;
using System;

namespace ChainOfResponsibilities
{
    class Program
    {
        static void Main(string[] args)
        {
            var cartHandler = new CartHandler();
            var orderHandler = new OrderHandler();
            var paymentHandler = new PaymentHandler();

            // Building the chain

            cartHandler.SetNext(orderHandler).SetNext(paymentHandler);

            // The client should be able to send a request to any of the handlers not just the first one of the chain.

            Console.WriteLine("Added to cart>Order Approved>Payment completed.");
            Client.Run(cartHandler);

            Console.WriteLine("Order Approved>Payment completed.");
            Client.Run(orderHandler);
        }
    }
}
