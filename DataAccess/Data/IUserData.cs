using DataAccess.Models;

namespace DataAccess.Data;

public interface IUserData
{
    Task DeleteUser(int id, string updateUserName);
    Task<UserModel?> GetUser(int id);
    Task<IEnumerable<string>> GetUsersByLike(string userType);
    Task InsertUser(UserModel user);
    Task UpdateUser(UserModel user);
}