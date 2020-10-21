using LinqToDB;
using LinqToDbDemo.Context;
using LinqToDbDemo.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace LinqToDbDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly SampleDbContext _sampleDbContext;

        public EmployeeController(SampleDbContext sampleDbContext)
        {
            _sampleDbContext = sampleDbContext;
        }

        [HttpGet]
        public Task<Employee[]> GetEmployees()
        {
            return _sampleDbContext.Employees.LoadWith(dep => dep.Department).ToArrayAsync();
        }
    }
}
