using Factory_Method.Factories;
using System;

namespace Factory_Method
{
    public class Statistic
    {
        public void GlobalStatistics()
        {
            Console.WriteLine("Huawei statistics:");
            this.FactoryStatistics(new HuaweiFactory());

            Console.WriteLine("Samsung statistics:");
            this.FactoryStatistics(new SamsungFactory());

            Console.WriteLine("IPhone statistics:");
            this.FactoryStatistics(new IPhoneFactory());
        }

        private void FactoryStatistics(SmartphoneFactory factory)
        {
            Console.WriteLine(factory.ProductionReport());
        }
    }
}
