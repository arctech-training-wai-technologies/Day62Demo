using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication1.Data;
using WebApplication1.Models;
using WebApplication1.Services;
using WebApplication1.Services.WithDI;
using WebApplication1.Services.WithoutDI;
using WebApplication1.ViewModel;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IDepartmentServiceDI _departmentServiceDi;
        private readonly IUserServiceDI _userServiceDi;

        public HomeController(
            ILogger<HomeController> logger,
            IDepartmentServiceDI departmentServiceDi,
            IUserServiceDI userServiceDi)
        {
            _logger = logger;
            _departmentServiceDi = departmentServiceDi;
            _userServiceDi = userServiceDi;
        }

        /// <summary>
        /// Without Dependency Injection
        /// </summary>
        /// <returns></returns>
        public async Task<IActionResult> Index()
        {
            await using var dbContext = new ApplicationDbContext();
            var departmentService = new DepartmentService();
            var userService = new UserService();

            var departmentUserViewModel = new DepartmentUserViewModel
            {
                Departments = await departmentService.GetAllAsync(dbContext),
                Users = await userService.GetAllAsync(dbContext)
            };

            return View(departmentUserViewModel);
        }

        /// <summary>
        /// With Dependency Injection
        /// </summary>
        /// <returns></returns>
        public async Task<IActionResult> PrivacyAsync()
        {
            var departmentUserViewModel = new DepartmentUserViewModel
            {
                Departments = await _departmentServiceDi.GetAllAsync(),
                Users = await _userServiceDi.GetAllAsync()
            };

            return View(departmentUserViewModel);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}