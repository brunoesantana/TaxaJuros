using System.Collections.Generic;
using TaxaJuros.CrossCutting.Helper;
using TaxaJuros.Data.Base;
using TaxaJuros.Data.Context;
using TaxaJuros.Data.Interface;
using TaxaJuros.Domain;

namespace TaxaJuros.Data.Repository
{
    public class TaxaRepository : BaseRepository<Taxa>, ITaxaRepository
    {
        public TaxaRepository(DataContext context) : base(context)
        {
        }

        public override List<Taxa> GetAll()
        {
            return MockHelper.GetTaxa();
        }
    }
}