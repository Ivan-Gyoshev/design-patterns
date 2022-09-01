using Builder.Contracts;
using System.IO;

namespace Builder
{
    /// <summary>
    /// The client code creates a builder which is passed to the director and
    /// then the construction proccess is initiated. The end result is 
    /// the final product from the builder.
    /// </summary>
    public class Client
    {
        public Client()
        {
            CarBuilder = new CarBuilder();
            Director = new Director();
        }

        public Director Director { get; set; }

        public CarBuilder CarBuilder { get; set; }

        public void Execute()
        {
            Director.Builder = CarBuilder;

            Console.WriteLine("Standard basic Car:");
            Director.BuildBaseCarModel();
            Console.WriteLine(CarBuilder.GetProduct().PartsReport);

            Console.WriteLine("Standard full featured Car:");
            Director.BuildCarWithGPSFeature();
            Console.WriteLine(CarBuilder.GetProduct().PartsReport);

            // Note: The builder can be used without the director.

            Console.WriteLine("Custom Car:");
            CarBuilder.BuildEngine();
            CarBuilder.BuildCoupe();
            CarBuilder.InstallGPS();
            CarBuilder.AttachSpoiler();
            Console.WriteLine(CarBuilder.GetProduct().PartsReport);
        }
    }
}
