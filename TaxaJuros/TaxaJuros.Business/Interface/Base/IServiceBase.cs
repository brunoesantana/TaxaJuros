using System.Collections.Generic;

namespace TaxaJuros.Business.Interface.Base
{
    public interface IServiceBase<T> where T : class
    {
        List<T> GetAll();
    }
}