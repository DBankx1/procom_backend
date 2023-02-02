using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using procom_backend.Infrastructure;
using procom_backend.Model;

namespace procom_backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : ControllerBase
    {
        private IEmployeeRepository _employeeRepository;
        public EmployeeController(IEmployeeRepository employeeRepo)
        {
            _employeeRepository = employeeRepo;
        }

        [HttpGet]
        public ActionResult<List<Employee>> GetAllEmployees()
        {
            return Ok(_employeeRepository.GetAllEmployees());
        }

        [HttpGet("{id}")]
        public ActionResult<Employee> GetEmployeeById(int id)
        {
            var employee = _employeeRepository.GetEmployeeById(id);
            if (employee == null) return NotFound(new { message = "Employee not found"});
            return Ok(employee);
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteEmployeeById(int id)
        {
            var employee = _employeeRepository.GetEmployeeById(id);
            if (employee == null) return NotFound(new { message = "Employee not found"});
            _employeeRepository.DeleteEmployee(employee);
            return Ok(new {message = "Employee has been deleted successfully"});
        }

        [HttpPost]
        public ActionResult<Employee> CreateEmployee(Employee employee)
        {
            var employee_created = _employeeRepository.CreateEmployee(employee);
            return Ok(employee_created);
        }

        [HttpPut("{id}")]
        public ActionResult<Employee> UpdateEmployee(int id, Employee employee)
        {
            return _employeeRepository.UpdateEmployee(id, employee);
        }
    }
}