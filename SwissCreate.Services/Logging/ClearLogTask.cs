using SwissCreate.Services.Tasks;

namespace SwissCreate.Services.Logging
{
    public partial class ClearLogTask : ITask
    {
        #region Fields

        private readonly ILogger _logger;

        #endregion

        #region Ctor

        public ClearLogTask(ILogger logger)
        {
            this._logger = logger;
        }

        #endregion

        #region Methods

        public virtual void Execute()
        {
            _logger.ClearLog();
        }

        #endregion
    }
}
