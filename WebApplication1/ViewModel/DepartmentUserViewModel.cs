using WebApplication1.Data.Models;

namespace WebApplication1.ViewModel;

public class DepartmentUserViewModel
{
    public List<Department> Departments { get; set; }
    public List<User> Users { get; set; }
}