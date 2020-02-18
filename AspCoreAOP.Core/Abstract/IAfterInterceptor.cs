namespace AspCoreAOP.Core.Abstract
{
    public interface IAfterInterceptor : IInterceptor
    {
        void OnAfter();
    }
}
