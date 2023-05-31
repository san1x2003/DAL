using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Sanshop.Models;
using Sanshop.Services.EmployeeServices;

namespace Sanshop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;
        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Employee>>> GetAllEmployee()
        {
            return await _employeeService.GetAllEmployee();
        }

        [HttpGet("(id)")]
        public async Task<ActionResult<Employee>> GetSinglEmployee(int id)
        {
            var result = await _employeeService.GetSingleEmployee(id);
            if (result is null)
                return NotFound("Sorry");

            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<List<Employee>>> AddEmployee(Employee oneEmployee)
        {
            var result = await _employeeService.AddEmployee(oneEmployee);
            return Ok(result);
        }

        [HttpPut("(id)")]
        public async Task<ActionResult<List<Employee>>> UpdateEmployee(int id, Employee request)
        {
            var result = await _employeeService.UpdateEmployee(id, request);
            if (result is null)
                return NotFound("Sorry");

            return Ok(result);
        }

        [HttpDelete("(id)")]
        public async Task<ActionResult<List<Employee>>> DeleteEmployee(int id)
        {
            var result = await _employeeService.DeleteEmployee(id);
            if (result is null)
                return NotFound("Sorry");

            return Ok(result);
        }

    }
}