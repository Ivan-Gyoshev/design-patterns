using Factory_Method.Contracts;
using Factory_Method.Models;

namespace Factory_Method.Factories
{
    /// <summary>
    /// Subclass, which overrides the base factory.
    /// </summary>
    public class HuaweiFactory : SmartphoneFactory
    {
        public override ISmartphone ProduceSmartphone()
        {
            return new Huawei();
        }
    }
}
