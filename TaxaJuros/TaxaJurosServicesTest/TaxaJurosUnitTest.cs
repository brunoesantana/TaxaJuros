using NSubstitute;
using NUnit.Framework;
using System.Collections.Generic;
using TaxaJuros.Business;
using TaxaJuros.Business.Interface;
using TaxaJuros.CrossCutting.Exceptions;
using TaxaJuros.Data.Interface;
using TaxaJuros.Domain;

namespace TaxaJuros.Test
{
    public class TaxaJurosUnitTest
    {
        private ITaxaRepository _mock;
        private ITaxaService _taxaService;

        [SetUp]
        public void Setup()
        {
            _mock = Substitute.For<ITaxaRepository>();
            _mock.GetAll().Returns(new List<Taxa>());
            _taxaService = new TaxaService(_mock);
        }

        [Test]
        public void Deve_lancar_excessao_se_nao_encontrar_registro()
        {
            var ex = Assert.Throws<NotFoundException>(() => _taxaService.GetAll());
            Assert.AreEqual(ex.Message, "Registro não encontrado");
        }
    }
}