using Strategy.Contracts;

namespace Strategy.Strategies
{
    /// <summary>
    /// Concrete Strategies implement the algorithm while following the base
    /// Strategy interface. The interface makes them interchangeable in the
    /// Context.
    /// </summary>
    public class ReversedSortingStrategy : ISortingStrategy
    {
        public object Sort(object data)
        {
            List<string> collection = data as List<string>;

            collection.Sort();
            collection.Reverse();

            return collection;
        }
    }
}
