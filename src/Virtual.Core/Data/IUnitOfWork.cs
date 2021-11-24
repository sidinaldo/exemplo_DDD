using System.Threading.Tasks;

namespace Virtual.Core.Data
{
    public interface IUnitOfWork
    {
        Task<bool> Commit();
    }
}
