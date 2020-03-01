using System.Collections.Generic;
using System.Linq;
using TaxaJuros.Business.Base;
using TaxaJuros.Business.Interface;
using TaxaJuros.CrossCutting.Exceptions;
using TaxaJuros.Data.Interface;
using TaxaJuros.Domain;

namespace TaxaJuros.Business
{
    public class TaxaService : BaseService<Taxa>, ITaxaService
    {
        public TaxaService(ITaxaRepository repository) : base(repository)
        {
        }

        public override List<Taxa> GetAll()
        {
            var responseList = ((ITaxaRepository)Repository).GetAll();

            if (!responseList.Any())
                throw new NotFoundException("Registro não encontrado");

            return responseList;
        }
    }
}