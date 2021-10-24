using Almacen.DataAccess.Domain;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Reflection;

namespace Almacen.DataAccess
{
    public static class SPQueryBuilderResults
    {
        public static MultipleResultSetWrapper QueryMultipleResults(this DbContext db, string sql)
        {
            return new MultipleResultSetWrapper(db, sql);
        }

        public class MultipleResultSetWrapper
        {
            private readonly DbContext _db;
            private readonly string _storedProcedure;
            public MultipleResultSetWrapper(DbContext db, string sql)
            {
                _db = db;
                _storedProcedure = sql;
            }

            public List<List<dynamic>> ExecuteMultipleResults(SqlParameter[] parameters, params Type[] types)
            {
                List<List<dynamic>> results = new List<List<dynamic>>();

                var connection = _db.Database.GetDbConnection();
                var command = connection.CreateCommand();
                command.CommandText = _storedProcedure;
                command.CommandType = CommandType.StoredProcedure;

                if (parameters != null && parameters.Any())
                {
                    command.Parameters.AddRange(parameters);
                }

                if (command.Connection.State != ConnectionState.Open)
                {
                    command.Connection.Open();
                }

                int counter = 0;
                using (var reader = command.ExecuteReader())
                {
                    do
                    {
                        var innerResults = new List<dynamic>();

                        if (counter > types.Length - 1) { break; }

                        while (reader.Read())
                        {
                            var item = Activator.CreateInstance(types[counter]);

                            for (int inc = 0; inc < reader.FieldCount; inc++)
                            {
                                Type type = item.GetType();
                                string name = reader.GetName(inc);
                                PropertyInfo property = type.GetProperty(name);

                                if (property != null && name == property.Name)
                                {
                                    var value = reader.GetValue(inc);
                                    if (value != null && value != DBNull.Value)
                                    {
                                        property.SetValue(item, Convert.ChangeType(value, Nullable.GetUnderlyingType(property.PropertyType) ?? property.PropertyType), null);
                                    }
                                }
                            }
                            innerResults.Add(item);
                        }
                        results.Add(innerResults);
                        counter++;
                    }
                    while (reader.NextResult());
                    reader.Close();
                }
                return results;
            }

            public List<string> ExecuteMultipleJsonResults(SqlParameter[] parameters, params Type[] types)
            {
                List<string> results = new List<string>();

                var connection = _db.Database.GetDbConnection();
                var command = connection.CreateCommand();
                command.CommandText = _storedProcedure;
                command.CommandType = CommandType.StoredProcedure;

                if (parameters != null && parameters.Any())
                {
                    command.Parameters.AddRange(parameters);
                }

                if (command.Connection.State != ConnectionState.Open)
                {
                    command.Connection.Open();
                }

                int counter = 0;
                using (var reader = command.ExecuteReader())
                {
                    do
                    {
                        var innerResults = new List<dynamic>();

                        if (counter > types.Length - 1) { break; }

                        while (reader.Read())
                        {
                            var item = Activator.CreateInstance(types[counter]);

                            for (int inc = 0; inc < reader.FieldCount; inc++)
                            {
                                Type type = item.GetType();
                                string name = reader.GetName(inc);
                                PropertyInfo property = type.GetProperty(name);

                                if (property != null && name == property.Name)
                                {
                                    var value = reader.GetValue(inc);
                                    if (value != null && value != DBNull.Value)
                                    {
                                        property.SetValue(item, Convert.ChangeType(value, Nullable.GetUnderlyingType(property.PropertyType) ?? property.PropertyType), null);
                                    }
                                }
                            }
                            innerResults.Add(item);
                        }
                        results.Add(JsonConvert.SerializeObject(innerResults));
                        counter++;
                    }
                    while (reader.NextResult());
                    reader.Close();
                }
                return results;
            }
        }
    }
}
