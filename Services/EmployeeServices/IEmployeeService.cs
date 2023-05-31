using Sanshop.Models;

namespace Sanshop.Services.EmployeeServices
{
    public interface IEmployeeService
    {
        Task<List<Employee>> GetAllEmployee();

        Task<Employee?> GetSingleEmployee(int id);

        Task<List<Employee>> AddEmployee(Employee oneemployee);

        Task<List<Employee>?> UpdateEmployee(int id, Employee request);

        Task<List<Employee>?> DeleteEmployee(int id);
    }
}
