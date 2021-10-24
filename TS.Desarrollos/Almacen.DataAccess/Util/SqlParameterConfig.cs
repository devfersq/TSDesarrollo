using System;

namespace Almacen.DataAccess.Utils
{
    public class SqlParameterConfig : Attribute
    {
        public bool IsDataList { get; set; }
        public SqlParameterConfig(bool _isDataList)
        {
            IsDataList = _isDataList;
        }
    }
}
