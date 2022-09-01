using Builder.Contracts;

namespace Builder
{
    /// <summary>
    /// The Concrete Builder classes follow the Builder interface and provide
    /// specific implementations of the building steps. Your program may have
    /// several variations of Builders, implemented differently.
    /// </summary>
    public class CarBuilder : ICarBuilder
    {
        private Car _car = new Car();

        // A fresh builder instance should contain a blank product object, which
        // is used in further assembly.
        public CarBuilder()
        {
            Reset();
        }

        // All production steps work with the same product instance.
        public void BuildCoupe()
        {
            _car.AttachPart("Coupe");
        }

        public void BuildEngine()
        {
            _car.AttachPart("Engine");
        }

        public void InstallGPS()
        {
            _car.AttachPart("GPS");
        }

        public void AttachSpoiler()
        {
            _car.AttachPart("Car Spoiler");
        }

        public void Reset()
        {
            _car = new();
        }

        // Concrete Builders are supposed to provide their own methods for
        // retrieving results. That's because various types of builders may
        // create entirely different products that don't follow the same
        // interface. Therefore, such methods cannot be declared in the base
        // Builder interface (at least in a statically typed programming
        // language).
        //
        // Usually, after returning the end result to the client, a builder
        // instance is expected to be ready to start producing another product.
        // That's why it's a usual practice to call the reset method at the end
        // of the `GetProduct` method body. However, this behavior is not
        // mandatory, and you can make your builders wait for an explicit reset
        // call from the client code before disposing of the previous result.
        public Car GetProduct()
        {
            Car result = _car;

            Reset();

            return result;
        }
    }
}
