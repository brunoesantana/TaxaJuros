using NUnit.Framework;
using System.Linq;
using TaxaJuros.Api.Mapper;
using TaxaJuros.Business;
using TaxaJuros.Business.Interface;
using TaxaJuros.Data.Context;
using TaxaJuros.Data.Interface;
using TaxaJuros.Data.Repository;

namespace TaxaJurosServicesTest
{
    public class TaxaServiceTest
    {
        private ITaxaService _taxaService;
        private ITaxaRepository _taxaRepository;

        private const double UM_POR_CENTO = 1D / 100;

        [SetUp]
        public void Setup()
        {
            MapperConfig.RegisterMappings();

            _taxaRepository = new TaxaRepository(new DataContext());
            _taxaService = new TaxaService(_taxaRepository);
        }

        [Test]
        public void Deve_retornar_taxa_corretamente()
        {
            var list = _taxaService.GetAll();
            Assert.IsTrue(list.Any());

            var taxa = list.FirstOrDefault();
            Assert.IsNotNull(taxa);
            Assert.IsTrue(taxa.Value == UM_POR_CENTO);
        }
    }
}