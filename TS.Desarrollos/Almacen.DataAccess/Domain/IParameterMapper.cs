using Almacen.DataAccess.Utils;


namespace Almacen.DataAccess.Domain
{
    public interface IParameterMapper
    {
        StoredProcedure Map<TSource>(TSource source);
    }
}
