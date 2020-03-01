using AutoMapper;

namespace TaxaJuros.CrossCutting.Helper
{
    public static class MapperHelper
    {
        public static TDestiny Map<TSource, TDestiny>(TSource origin)
        {
            return Mapper.Map<TDestiny>(origin);
        }
    }
}