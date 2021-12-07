using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using DataAccess.Data;
using DataAccess.Models;

namespace UsersAPI.Controllers;

[ApiVersion("1.0")]
[Route("api/v{version:apiVersion}/[controller]")]
[ApiController]
public class UsersController : ControllerBase
{
    private readonly IUserData _data;

    public UsersController(IUserData data)
    {
        _data = data;
    }
    
    [HttpGet("/v{version:apiVersion}/like/{userType}")]
    [ProducesResponseType(statusCode: StatusCodes.Status200OK)]
    public async Task<ActionResult> GetUsersByLike(string userType)
    {
        return Ok(await _data.GetUsersByLike(userType));
    }
    
    [HttpGet("{id}")]
    [ProducesResponseType(statusCode: StatusCodes.Status200OK)]
    [ProducesResponseType(statusCode: StatusCodes.Status404NotFound)]
    public async Task<ActionResult<IAsyncEnumerable<UserModel>>> GetUser(int id)
    {
        var result = await _data.GetUser(id);
        if (result == null)
            return NotFound("לא נמצאו נתונים");
        return Ok(result);
    }

    [HttpPost]
    [ProducesResponseType(statusCode: StatusCodes.Status200OK)]
    public async Task<ActionResult> InsertUser(UserModel user)
    {
        user.Insert_user_id = Environment.UserName;
        await _data.InsertUser(user);
        return Ok("ההוספה בוצעה בהצלחה");
    }
    [HttpPut]
    [ProducesResponseType(statusCode: StatusCodes.Status200OK)]
    public async Task<ActionResult> UpdateUser(UserModel user)
    {
        user.Update_user_id = Environment.UserName;
        await _data.UpdateUser(user);
        return Ok("העדכון בוצע בהצלחה");
    }

    [HttpDelete]
    [ProducesResponseType(statusCode: StatusCodes.Status200OK)]
    [ProducesResponseType(statusCode: StatusCodes.Status404NotFound)]

    public async Task<ActionResult> DeleteUser(int id)
    {
        string userName = Environment.UserName;
        var user = await _data.GetUser(id);
        if (user == null) return NotFound("לא נמצאו נתונים");

        await _data.DeleteUser(id, userName);
        return Ok("המחיקה בוצעה בהצלחה");
    }

}
