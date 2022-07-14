using Strategy;
using Strategy.Contracts;
using Strategy.Strategies;

namespace Factory_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            Context context = new Context();

            List<ISortingStrategy> sortingStrategies = new List<ISortingStrategy>
            {
                new NormalSortingStrategy(),
                new ReversedSortingStrategy()
            };

            List<string> collectionToSort = new List<string>
            {
                "a", "b", "c", "d", "e"
            };

            foreach (var strategy in sortingStrategies)
            {
                context.SetSortingStrategy(strategy);
                context.Sort(collectionToSort, strategy.GetType().Name);
            }
        }
    }
}
