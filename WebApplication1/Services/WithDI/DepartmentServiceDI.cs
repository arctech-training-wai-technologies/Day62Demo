using Microsoft.EntityFrameworkCore;
using WebApplication1.Data;
using WebApplication1.Data.Models;

namespace WebApplication1.Services.WithDI;

public interface IDepartmentServiceDI
{
    Task<List<Department>> GetAllAsync();
}

public class DepartmentServiceDI : IDepartmentServiceDI
{
    private readonly ApplicationDbContext _dbContext;
    public DepartmentServiceDI(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<List<Department>> GetAllAsync()
    {
        var departments = await _dbContext.Departments.ToListAsync();

        return departments;
    }
}