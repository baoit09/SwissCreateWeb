using FluentValidation;

namespace SwissCreateWeb.Framework.Validators
{
    public abstract class BaseSwissCreateValidator<T> : AbstractValidator<T> where T : class
    {
        protected BaseSwissCreateValidator()
        {
            PostInitialize();
        }

        /// <summary>
        /// Developers can override this method in custom partial classes
        /// in order to add some custom initialization code to constructors
        /// </summary>
        protected virtual void PostInitialize()
        {
        }
    }
}