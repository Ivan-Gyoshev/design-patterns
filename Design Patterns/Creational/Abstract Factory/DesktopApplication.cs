using Abstract_Factory.Contracts;
using Abstract_Factory.Factories;
using System;

namespace Abstract_Factory
{
    /// <summary>
    /// The client code works with factories and products only through abstract types.
    /// Abstract factory and Abstract product. This lets you pass any factory
    /// or product subclass to the client without breaking it.
    /// </summary>
    public class DesktopApplication
    {
        public void Start()
        {
            Console.WriteLine("Starting the application on Windows...");
            ConfigureApplication(new WindowsGUIFactory());
            Console.WriteLine();

            Console.WriteLine("Starting the application on MacOS");
            ConfigureApplication(new MacGUIFactory());
        }

        private void ConfigureApplication(FactoryBase factory)
        {
            IButton button = factory.GenerateButton();
            ICheckBox checkBox = factory.GenerateCheckBox();

            checkBox.CheckIn();
            checkBox.CancelCheckIn(button);
        }
    }
}
