﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;

namespace Domain.Repositories
{
    public interface IContaRepository
    {
        Task<IEnumerable<ContaDTO>> Get();
		Task<bool> Criar(ContaDTO conta);
        Task<bool> Excluir(ContaDTO conta);
        Task<bool> Editar(ContaDTO conta);
    }
}
