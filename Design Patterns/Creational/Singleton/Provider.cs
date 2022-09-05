namespace Singleton
{
    /// <summary>
    /// This implementation of the Singleton pattern is called "double check lock". It is safe
    /// in multithreaded environment and provides lazy initialization for the Singleton object.
    /// </summary>
    public class Provider
    {
        private Provider() { }

        private static Provider _instance;

        // A lock object which will synchronize threads during first access to the Singleton object.
        private static readonly object _instanceLock = new object();

        public static Provider GetInstance(string value)
        {
            // This statement is needed to prevent threads stumbling over the
            // lock once the instance is ready
            if (_instance is null)
            {
                // Situation: The program just launced. Since there is no Singleton
                // instance yet, multiple threads will try to simultaneously to access this
                // object almost at the same time. The first of them will acquire lock and will
                // proceed further while the rest of them will wait here. This lock prevents
                // multiple threads from creating more than one Singleton object.
                lock (_instanceLock)
                {
                    // Since the first thread acquired lock and reached this block of code
                    // it will continue and create a new instance of this object and then exit
                    // the code block. All the next threads will try to enter this statement but
                    // since there is already an instance of the Singleton object they will not
                    // create a new instance of it, but use the already created one.
                    if (_instance is null)
                    {
                        _instance = new Provider();
                        _instance.Value = value;
                    }
                }
            }

            return _instance;
        }

        public string Value { get; private set; }
    }
}
