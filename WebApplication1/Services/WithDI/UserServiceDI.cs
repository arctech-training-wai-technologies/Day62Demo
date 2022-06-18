using Microsoft.EntityFrameworkCore;
using WebApplication1.Data;
using WebApplication1.Data.Models;

namespace WebApplication1.Services.WithDI;

public interface IUserServiceDI
{
    Task<List<User>> GetAllAsync();
}

public class UserServiceDI : IUserServiceDI
{
    private readonly ApplicationDbContext _dbContext;

    public UserServiceDI(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<List<User>> GetAllAsync()
    {
        var users = await _dbContext.Users.ToListAsync();

        return users;
    }
}