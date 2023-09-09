using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using  Application.Interfaces;
using  Application.Models;
using  Domain.Entities;
using  Domain.Repositories;

namespace  Application.Services
{
    public class ContaService : IContaService
    {
        private readonly IContaRepository _contaRepository;
        private readonly IMapper _mapper;
        public ContaService(IContaRepository contaRepository, IMapper mapper)
        {
            _contaRepository = contaRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<ContaDTO>> Get()
        {
            var result = await _contaRepository.Get();

            var resultmap = _mapper.Map<IEnumerable<ContaDTO>>(result);

            return resultmap;
        }
		public async Task<bool> Criar(ContaDTO conta)
		{
			var result = await _contaRepository.Criar(conta);

			return true;
		}
        public async Task<bool> Excluir(ContaDTO conta)
        {
            var result = await _contaRepository.Excluir(conta);

            return true;
        }
        public async Task<bool> Editar(ContaDTO conta)
        {
            var result = await _contaRepository.Editar(conta);

            return true;
        }
    }
}
