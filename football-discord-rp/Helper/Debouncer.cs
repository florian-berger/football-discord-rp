namespace football_discord_rp.Helper
{
    /// <summary>
    ///     Class that allows debounced execution of functionality
    /// </summary>
    /// <param name="timespan"></param>
    /// <param name="action"></param>
    internal class Debouncer(TimeSpan timespan, Action action) : IDisposable
    {
        #region Private variables
        
        private readonly HashSet<ManualResetEvent> _resetEvents = [];
        private readonly Lock _mutex = new();

        #endregion Private variables

        #region Public methods

        /// <summary>
        ///     Queues a new execution of the action
        /// </summary>
        public void Invoke()
        {
            var newResetEvent = new ManualResetEvent(false);

            lock (_mutex)
            {
                while (_resetEvents.Count > 0)
                {
                    var otherReset = _resetEvents.First();
                    _resetEvents.Remove(otherReset);
                    otherReset.Set();
                }

                _resetEvents.Add(newResetEvent);
            }

            ThreadPool.QueueUserWorkItem(_ =>
            {
                try
                {
                    if (!newResetEvent.WaitOne(timespan))
                    {
                        action();
                    }
                }
                finally
                {
                    lock (_mutex)
                    {
                        using (newResetEvent)
                        {
                            _resetEvents.Remove(newResetEvent);
                        }
                    }
                }
            });
        }

        #endregion Public methods

        #region IDisposable

        /// <inheritdoc />
        public void Dispose()
        {
            lock (_mutex)
            {
                while (_resetEvents.Count > 0)
                {
                    var reset = _resetEvents.First();
                    _resetEvents.Remove(reset);
                    
                    reset.Set();
                }
            }
        }

        #endregion IDisposable
    }
}
