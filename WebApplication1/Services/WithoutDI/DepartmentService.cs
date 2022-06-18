using Microsoft.EntityFrameworkCore;
using WebApplication1.Data;
using WebApplication1.Data.Models;

namespace WebApplication1.Services.WithoutDI;

public class DepartmentService
{
    public async Task<List<Department>> GetAllAsync(ApplicationDbContext dbContext)
    {
        var departments = await dbContext.Departments.ToListAsync();

        return departments;
    }
}