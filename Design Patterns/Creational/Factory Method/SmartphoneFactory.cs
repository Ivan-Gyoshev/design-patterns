using Factory_Method.Contracts;
using System;

namespace Factory_Method
{
    /// <summary>
    /// Declares a base factory method which is supposed to return an object which
    /// implements ISmartphone interface. The base factory subclasses provide the
    /// implementation of the method. Despite of its name the core functionality
    /// of the factory is closely related to the business logic. Subclasses can
    /// indirectly change that business logic by overriding the base method and 
    /// returning different object implementation.
    /// </summary>
    public abstract class SmartphoneFactory
    {
        // Could also provide some default implementation
        public abstract ISmartphone ProduceSmartphone();

        public string ProductionReport()
        {
            // Calls base factory method to create object.
            ISmartphone smartphone = ProduceSmartphone();

            // Use the created object.
            string report = "The factory produced smartphone with device characteristics: " + Environment.NewLine + smartphone.DeviceInformation();

            return report;
        }
    }
}
