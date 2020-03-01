using System.Collections.Generic;
using TaxaJuros.Business.Interface.Base;
using TaxaJuros.Data.Interface.Base;

namespace TaxaJuros.Business.Base
{
    public class BaseService<T> : IServiceBase<T> where T : class
    {
        protected readonly IRepositoryBase<T> Repository;

        public BaseService(IRepositoryBase<T> repository)
        {
            Repository = repository;
        }

        public virtual List<T> GetAll()
        {
            return Repository.GetAll();
        }
    }
}