namespace Abstract_Factory.Contracts
{
    /// <summary>
    /// Each distinct product of a product family should have a base interface.
    /// All of it's variants should implement this interface.
    /// </summary>
    public interface ICheckBox
    {
        void CheckIn();

        void CancelCheckIn(IButton collaborator);
    }
}
