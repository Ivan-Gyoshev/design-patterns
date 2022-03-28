using Abstract_Factory.Contracts;
using Abstract_Factory.Models.MacOS;

namespace Abstract_Factory.Factories
{
    /// <summary>
    /// Each concrete factory has a corresponding product variant.
    /// </summary>
    public class MacGUIFactory : FactoryBase
    {
        public override IButton GenerateButton()
        {
            return new MacButton();
        }

        public override ICheckBox GenerateCheckBox()
        {
            return new MacCheckbox();
        }
    }
}
