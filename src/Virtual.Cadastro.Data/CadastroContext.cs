using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using Virtual.Core.Data;

namespace Virtual.Cadastro.Data
{
    public class CadastroContext : DbContext, IUnitOfWork
    {
        public Task<bool> Commit()
        {
            throw new System.NotImplementedException();
        }
    }
}
