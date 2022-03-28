using Abstract_Factory.Contracts;
using System;

namespace Abstract_Factory.Models.Windows
{
    /// <summary>
    /// Concrete implementations of products are created by Concrete Factory
    /// </summary>
    public class WindowsButton : IButton
    {
        public void Click()
        {
            Console.WriteLine("Windows button click happened");
        }
    }
}
