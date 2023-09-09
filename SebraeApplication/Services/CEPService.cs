
using Application.Interfaces;
using AutoMapper;
using Domain.Entities;
using Domain.Repositories;

namespace Application.Services
{
    public class CEPService : ICEPService
    {
        private readonly ICEPRepository _CEPRepository;
        private readonly IMapper _mapper;

        public CEPService(ICEPRepository CEPRepository, IMapper mapper)
        {
            _CEPRepository = CEPRepository;
            _mapper = mapper;
        }

        public async Task<CEPDTO> GetCEP()
        {
            var result = await _CEPRepository.GetCEP();

            var resultmap = _mapper.Map<CEPDTO>(result);

            return resultmap;
        }
    }
}
