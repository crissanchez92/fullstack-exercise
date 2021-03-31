namespace roofstock.Api.Adapters
{
    public interface IAdapter<T>
    {
        /// <summary>
        /// Adapts the item to an instance of T
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        T Adapt(object item);
    }
}