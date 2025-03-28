using Azure.Core;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Shop.Data;
using Shop.Data.Entities;
using Shop.Models.Requests.User;
using Shop.Models.Responses.User;

namespace Shop.Services.User
{
    public class UserService : IUserService
    {
        public readonly AppDbContext _dbContext;
        public UserService(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<GetUserResponse> GetUserAsync(int id)
        {
            var user = await _dbContext.Users.FirstOrDefaultAsync(u => u.Id == id)
                ?? throw new InvalidOperationException($"User with id {id} not found");

            return new GetUserResponse { Id = user.Id, FullName = user.FullName, Email = user.Email };
        }

        public async Task<GetUsersListResponse> GetUsersListAsync()
        {
            var users = await _dbContext.Users.ToListAsync();

            var usersList = new List<GetUserResponse>();

            foreach (var user in users)
            {
                usersList.Add(new GetUserResponse
                {
                    Id = user.Id,
                    FullName = user.FullName,
                    Email = user.Email,
                });
            }

            return new GetUsersListResponse
            {
                Users = usersList,
                TotalCount = usersList.Count()
            };
        }

        public async Task CreateUserAsync(CreateUserRequest request)
        {
            if (request.Password.Length < 8)
                throw new InvalidOperationException("Password length must be minimum 8");

            var user = new Shop.Data.Entities.User
            {
                FullName = request.FullName,
                Email = request.Email,
                Password = request.Password
            };
            
            _dbContext.Users.Add(user);

            await _dbContext.SaveChangesAsync();
        }

        public async Task UpdateUserInfoAsync(UpdateUserRequest request)
        {
            var user = await _dbContext.Users.FirstOrDefaultAsync(u => u.Id == request.Id)
                ?? throw new InvalidOperationException($"User with id {request.Id} not found");

            user.FullName = request.FullName;
            user.Email = request.Email;
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteUserAsync(int id)
        {
            var user = await _dbContext.Users.FirstOrDefaultAsync(u => u.Id == id)
                ?? throw new InvalidOperationException($"User with id {id} not found");

            _dbContext.Users.Remove(user);
            await _dbContext.SaveChangesAsync();
        }


    }
}
