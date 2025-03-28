using Shop.Models.Requests.User;
using Shop.Models.Responses.User;

namespace Shop.Services.User
{
    public interface IUserService
    {
        public Task<GetUserResponse> GetUserAsync(int id);
        public Task<GetUsersListResponse> GetUsersListAsync();
        public Task CreateUserAsync(CreateUserRequest request);
        public Task UpdateUserInfoAsync(UpdateUserRequest request);
        public Task DeleteUserAsync(int id);
    }
}
