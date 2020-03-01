using System.Collections.Generic;

namespace TaxaJuros.Data.Interface.Base
{
    public interface IRepositoryBase<T> where T : class
    {
        List<T> GetAll();
    }
}