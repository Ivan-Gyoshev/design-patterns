using Abstract_Factory.Contracts;

namespace Abstract_Factory
{
    /// <summary>
    /// The Abstract Factory base model declares a set of methods that
    /// return abstract products. These products are called a family and 
    /// are usually related by concept. Product of one family are usually
    /// able to collaborate among themselves.The products of one variants are
    /// incompatible with the products of another.
    /// </summary>
    public abstract class FactoryBase
    {
        public abstract IButton GenerateButton();

        public abstract ICheckBox GenerateCheckBox();
    }
}
