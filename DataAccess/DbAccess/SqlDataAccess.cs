using System.Data;
using System.Data.SqlClient;
using Dapper;
using Microsoft.Extensions.Configuration;

namespace DataAccess.DbAccess;

public class SqlDataAccess : ISqlDataAccess
{
    private readonly IConfiguration _config;

    public SqlDataAccess(IConfiguration config)
    {
        _config = config;
    }

    public async Task<IEnumerable<T>> LoadData<T, U>(
        string storProcedur,
        U parameters,
        string conectionId = "DefaultConnection"
        )
    {
        using IDbConnection dbconnection = new SqlConnection(_config.GetConnectionString(conectionId));

        return await dbconnection.QueryAsync<T>(storProcedur, parameters, commandType: CommandType.StoredProcedure);
    }

    public async Task<IEnumerable<T>> SaveData<T>(
       string storProcedur,
       T parameters,
       string conectionId = "DefaultConnection"
       )
    {
        using IDbConnection dbconnection = new SqlConnection(_config.GetConnectionString(conectionId));

        return await dbconnection.QueryAsync<T>(storProcedur, parameters, commandType: CommandType.StoredProcedure);
    }
}
