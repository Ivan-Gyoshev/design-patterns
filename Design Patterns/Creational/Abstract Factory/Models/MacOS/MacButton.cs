using Abstract_Factory.Contracts;
using System;

namespace Abstract_Factory.Models.MacOS
{
    /// <summary>
    /// Concrete implementations of products are created by Concrete Factory
    /// </summary>
    public class MacButton : IButton
    {
        public void Click()
        {
            Console.WriteLine("Mac button click happened");
        }
    }
}
