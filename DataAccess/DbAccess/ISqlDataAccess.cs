
namespace DataAccess.DbAccess;

public interface ISqlDataAccess
{
    Task<IEnumerable<T>> LoadData<T, U>(string storProcedur, U parameters, string conectionId = "DefaultConnection");
    Task<IEnumerable<T>> SaveData<T>(string storProcedur, T parameters, string conectionId = "DefaultConnection");
}