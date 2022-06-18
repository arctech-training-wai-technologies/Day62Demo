using Microsoft.EntityFrameworkCore;
using WebApplication1.Data;
using WebApplication1.Data.Models;

namespace WebApplication1.Services.WithoutDI;

public class UserService
{
    public async Task<List<User>> GetAllAsync(ApplicationDbContext dbContext)
    {
        var users = await dbContext.Users.ToListAsync();

        return users;
    }
}