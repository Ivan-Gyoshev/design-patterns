using Abstract_Factory.Contracts;
using Abstract_Factory.Models.Windows;

namespace Abstract_Factory.Factories
{
    /// <summary>
    /// Concrete Factories produce a family of products that belong to a single
    /// variant. The Factory guarantees that the resulting products are compatible.
    /// The signature of the concrete factory methods return an abstract product, while
    /// inside the method a concrete type is instantiated.
    /// </summary>
    public class WindowsGUIFactory : FactoryBase
    {
        public override IButton GenerateButton()
        {
            return new WindowsButton();
        }

        public override ICheckBox GenerateCheckBox()
        {
            return new WindowsCheckbox();
        }
    }
}
