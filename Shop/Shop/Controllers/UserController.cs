using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Shop.Models.Requests.User;
using Shop.Models.Responses.User;
using Shop.Services.User;

namespace Shop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        public readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<GetUserResponse>> GetUser(int id)
        {
            return await _userService.GetUserAsync(id);
        }

        [HttpGet("users")]
        public async Task<ActionResult<GetUsersListResponse>> GetUsersList()
        {
            return await _userService.GetUsersListAsync();
        }

        [HttpPost]
        public async Task<ActionResult> CreateUserAsync(CreateUserRequest request)
        {
           await _userService.CreateUserAsync(request);
           return Ok(request);
        }

        [HttpPut]
        public async Task<ActionResult> UpdateUserInfoAsync(UpdateUserRequest request)
        {
            await _userService.UpdateUserInfoAsync(request);
            return Ok(request);
        }

        [HttpDelete]
        public async Task<ActionResult> DeleteUserAsync([Required] int id)
        {
            await _userService.DeleteUserAsync(id);
            return Ok();
        }
    }
    
}
