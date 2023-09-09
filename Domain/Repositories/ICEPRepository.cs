

using Domain.Entities;

namespace Domain.Repositories
{
    public interface ICEPRepository
    {
        Task<CEPDTO> GetCEP();
    }
}
