using CurrencyConverterApp.Core.IRepositories;

namespace CurrencyConverterApp.Core.IConfigurations
{
    public interface IUnitOfWork
    {
        IUserRepository Users { get; }

        Task ComplateAsync();
    }
}
