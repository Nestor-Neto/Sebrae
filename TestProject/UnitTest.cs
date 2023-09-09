using API.Controllers;
using Application.Services;
using AutoMapper;
using Domain.Entities;
using Domain.Repositories;
using Infra.Repositories;
using Moq;
using NPOI.SS.Formula.Functions;
using Xunit;

namespace TestProject
{
    public class UnitTest
    {
       
        [Fact]
        public void Cep()
        {
            var list = new CEPDTO
            {
                cep = "01001-000",
                logradouro = "Praça da Sé",
                complemento = "lado ímpar",
                bairro = "Sé",
                localidade = "São Paulo",
                uf = "SP",
                ibge = "3550308",
                gia = "1004",
                ddd = "11",
                siafi = "7107"
            };
            var retorno = new CEPRepository().GetCEP().Result;

            //
            Assert.Equal(list.cep, retorno.cep);
            Assert.Equal(list.logradouro, retorno.logradouro);
            Assert.Equal(list.complemento, retorno.complemento);
            Assert.Equal(list.bairro, retorno.bairro);
            Assert.Equal(list.localidade, retorno.localidade);
            Assert.Equal(list.ibge, retorno.ibge);
            Assert.Equal(list.gia, retorno.gia);
            Assert.Equal(list.ddd, retorno.ddd);
            Assert.Equal(list.siafi, retorno.siafi);
        }
    }
}