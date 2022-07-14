namespace Strategy.Contracts
{
    /// <summary>
    /// Declares operations common to all supported versions of some logic
    /// 
    /// The Context uses this interface to execute specific logic defined by Concrete Strategy
    /// </summary>
    public interface ISortingStrategy
    {
        object Sort(object data);
    }
}
