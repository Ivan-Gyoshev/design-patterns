using ChainOfResponsibilities.Contracts;
using System;
using System.Collections.Generic;

namespace ChainOfResponsibilities
{
    // The client code is suited to work with a single handler. In most cases it's not aware that this handler is part of a chain.
    class Client
    {
        static List<string> storeCommands = new List<string>()
        {
            "Item added",
            "Order approved",
            "Payment approved!"
        };

        public static void Run(HandlerBase handler)
        {
            foreach (var cmd in storeCommands)
            {
                Console.WriteLine($"Command handled: {cmd}");

                var result = handler.Handle(cmd);

                if (result is not null)
                    Console.WriteLine($" {result}");
                else
                    Console.WriteLine($" {cmd} was not handled successfully");
            }
        }
    }
}
