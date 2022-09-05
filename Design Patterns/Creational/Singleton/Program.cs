namespace Singleton
{
    public class Program
    {
        private const string FirstValue = "First";
        private const string SecondValue = "Second";

        static void Main(string[] args)
        {
            Console.WriteLine("Two threads will prove that only one instance of the Singleton object is created.");

            Thread firstProcess = new Thread(() =>
            {
                GetProviderInstance(FirstValue);
            });

            Thread secondProcess = new Thread(() =>
            {
                GetProviderInstance(SecondValue);
            });

            firstProcess.Start();
            secondProcess.Start();

            firstProcess.Join();
            secondProcess.Join();
        }

        private static void GetProviderInstance(string value)
        {
            Provider provider = Provider.GetInstance(value);
            Console.WriteLine(provider.Value);
        }
    }
}