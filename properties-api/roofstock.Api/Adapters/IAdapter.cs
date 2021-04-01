namespace roofstock.Api.Adapters
{
    /// <summary>
    /// Defines how an Adapter should behaves.
    /// </summary>
    /// <typeparam name="T"></typeparam>
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