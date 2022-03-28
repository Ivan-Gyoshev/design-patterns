using Abstract_Factory.Contracts;
using System;

namespace Abstract_Factory.Models.Windows
{
    /// <summary>
    /// Concrete implementations of products are created by Concrete Factory
    /// </summary>
    public class WindowsCheckbox : ICheckBox
    {
        public void CheckIn()
        {
            Console.WriteLine("Windows checked in");
        }

        /// <summary>
        /// The variant of this product, is only able to work with the
        /// variant of the same family. Nevertheless, it accepts any instance of
        /// the abstract product as an argument.
        /// </summary>
        /// <param name="collaborator"></param>
        public void CancelCheckIn(IButton collaborator)
        {
            Console.Write("Windows canceled check in, because ");
            collaborator.Click();
        }
    }
}
