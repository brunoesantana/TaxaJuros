using System.Collections.Generic;
using System.Linq;
using TaxaJuros.Data.Context;
using TaxaJuros.Data.Interface.Base;
using TaxaJuros.Domain.Base;

namespace TaxaJuros.Data.Base
{
    public class BaseRepository<T> : IRepositoryBase<T> where T : EntityBase
    {
        protected readonly DataContext _context;

        public BaseRepository(DataContext context)
        {
            _context = context;
        }

        public virtual List<T> GetAll()
        {
            return _context.Set<T>().Where(w => w.Active).ToList();
        }
    }
}