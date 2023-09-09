using Application.Models;
using Domain.Entities;

namespace Application.Interfaces
{
    public interface ICEPService
    {
        Task<CEPDTO> GetCEP();
    }
}
