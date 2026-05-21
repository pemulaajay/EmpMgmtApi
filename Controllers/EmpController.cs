using EmpManagement.Data;
using EmpManagement.Model;
using Microsoft.AspNetCore.Mvc;

namespace EmpManagement.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmpController : ControllerBase
    {
        private readonly AppDbContext _context;

        public EmpController(AppDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult GetEmpList()
        {
            var Emp = _context.Employees.ToList();
            return Ok(Emp);
        }
        [HttpPost]
        public IActionResult EditEmp([FromBody] Employee Emp)
        {
            if (Emp == null) {

                _context.Entry(Emp).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            }
            return Ok(Emp);
        }
        [HttpPost]
        public IActionResult Register(Employee emp)
        {
            if (emp != null) { _context.Employees.Add(emp);
                _context.SaveChanges();
            }
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteEmp(int id) {
             var emp = _context.Employees.Find(id);
            if (emp == null) { return NotFound(); }
            _context.Employees.Remove(emp);
            _context.SaveChanges();
            return Ok();
                }
    }
}
