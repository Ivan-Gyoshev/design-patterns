using Strategy.Contracts;
using System.Reflection;

namespace Strategy
{
    /// <summary>
    /// Defines the interface of interest to the clients.
    /// </summary>
    public class Context
    {
        private ISortingStrategy _strategy;

        public Context() { }

        // Usualy the context accept the strategy from the constructor but
        // also provides a setter to change it at runtime
        public Context(ISortingStrategy strategy)
        {
            _strategy = strategy;
        }

        public void SetSortingStrategy(ISortingStrategy sortingStrategy) => _strategy = sortingStrategy;

        public void Sort(List<string> collectionToSort, string strategy)
        {
            Console.WriteLine($"Context: Sorting data... Using {strategy}");
            var result = _strategy.Sort(collectionToSort);

            foreach (var element in collectionToSort)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();
        }
    }
}
