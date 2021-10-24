
using System.Data.SqlClient;

namespace Almacen.DataAccess.Utils
{
    public class StoredProcedure
    {
        public SqlParameter[] Parameters { get; set; }
        public string Name { get; set; }
    }
}
