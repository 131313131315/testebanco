using Domain.Entities;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IUnitOfWorkGenerico<T> where T : BaseEntityGenerico
    {
        IRepositoryGenerico<T> Repository { get; }
        Task<int> CommitAsync();
    }
}
