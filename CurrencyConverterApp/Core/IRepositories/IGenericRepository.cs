namespace CurrencyConverterApp.Core.IRepositories
{
    public interface IGenericRepository<T> where T : class
    {
        Task<IEnumerable<T>> All();
        Task<T> GetById(Guid Id);
        Task<bool> Add(T entity);
        Task<bool> Delete(Guid Id);
        Task<bool> Upsert(T entity);
    }
}
