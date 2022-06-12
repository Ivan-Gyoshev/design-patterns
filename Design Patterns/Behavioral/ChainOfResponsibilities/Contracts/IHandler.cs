namespace ChainOfResponsibilities.Contracts
{
    /// <summary>
    /// Declares a method for building the chain of handlers and a method for executing a request.
    /// </summary>
    interface IHandler
    {
        /// <summary>
        /// Building the chain of handlers.
        /// </summary>
        /// <param name="handler"></param>
        /// <returns></returns>
        IHandler SetNext(IHandler handler);

        /// <summary>
        /// Executes a request.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        object Handle(object request);
    }
}
