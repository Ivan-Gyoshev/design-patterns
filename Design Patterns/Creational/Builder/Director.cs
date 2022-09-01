using Builder.Contracts;

namespace Builder
{
    /// <summary>
    /// The director is only responsible for executing the building steps
    /// in particular sequence. It is helpful when the final product should
    /// be produced according to any configurations or specific order.
    /// Otherwise the Director is optional due to the client's ability
    /// to directly control the builder.
    /// </summary>
    public class Director
    {
        private ICarBuilder _builder;

        public ICarBuilder Builder
        {
            get { return _builder; }
            set { _builder = value; }
        }

        // The Director can construct several product variants using the same building steps.
        public void BuildBaseCarModel()
        {
            _builder.BuildEngine();
            _builder.BuildCoupe();
        }

        public void BuildCarWithGPSFeature()
        {
            _builder.BuildEngine();
            _builder.BuildCoupe();
            _builder.InstallGPS();
        }
    }
}
