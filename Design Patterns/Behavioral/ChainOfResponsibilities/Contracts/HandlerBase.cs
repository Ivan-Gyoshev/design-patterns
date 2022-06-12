namespace ChainOfResponsibilities.Contracts
{
    abstract class HandlerBase : IHandler
    {
        private IHandler _nextHandler;

        public virtual object Handle(object request)
        {
            if (_nextHandler is not null)
                return _nextHandler.Handle(request);

            return null;
        }

        public IHandler SetNext(IHandler handler)
        {
            _nextHandler = handler;
            // Returning handler here will let you link handlers in a convinient way.
            return handler;
        }
    }
}
