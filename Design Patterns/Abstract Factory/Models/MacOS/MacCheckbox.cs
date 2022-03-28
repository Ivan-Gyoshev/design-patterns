using Abstract_Factory.Contracts;
using System;

namespace Abstract_Factory.Models.MacOS
{
    /// <summary>
    /// Concrete implementations of products are created by Concrete Factory
    /// </summary>
    public class MacCheckbox : ICheckBox
    {
        public void CheckIn()
        {
            Console.WriteLine("Mac checked in");
        }

        /// <summary>
        /// It could also have own things and collaborate with the
        /// products from the same family. The Abstract Factory makes sure
        /// that all products it creates are of the same variant and thus, compatible.
        /// </summary>
        /// <param name="collaborator"></param>
        public void CancelCheckIn(IButton collaborator)
        {
            Console.Write("Mac canceled check in, because ");
            collaborator.Click();
        }
    }
}
