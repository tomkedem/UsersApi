using DataAccess.DbAccess;
using DataAccess.Models;

namespace DataAccess.Data;

public class UserData : IUserData
{
    private readonly ISqlDataAccess _db;

    public UserData(ISqlDataAccess db)
    {
        _db = db;
    }
   
    
    public Task<IEnumerable<string>> GetUsersByLike(string userType) =>
        _db.LoadData<string, dynamic>(storProcedur: "dbo.spGetNameforprintUsingLikeOperator", new { nameforprint = userType });

    public async Task<UserModel?> GetUser(int id)
    {
        var result = await _db.LoadData<UserModel, dynamic>(
            storProcedur: "dbo.spUser_Get", new { Id = id });
        return result.FirstOrDefault();
    }

    public Task InsertUser(UserModel user) => _db.SaveData(storProcedur: "dbo.spUser_Insert", user);
    public Task UpdateUser(UserModel user) => _db.SaveData(storProcedur: "dbo.spUser_Update", user);
    public Task DeleteUser(int id, string updateUserName) => _db.SaveData(storProcedur: "dbo.spUser_Delete", new { Id = id, Update_user_id = updateUserName });


}
