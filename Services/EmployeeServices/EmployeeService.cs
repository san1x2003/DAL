using Sanshop.Models;

namespace Sanshop.Services.EmployeeServices
{
    public class EmployeeService : IEmployeeService
    {

        private readonly DataContext _context;

        public EmployeeService(DataContext context)
        {
            _context = context;
        }
        public async Task<List<Employee>> AddEmployee(Employee oneEmployee)
        {
            _context.Employee.Add(oneEmployee);

            await _context.SaveChangesAsync();

            return await _context.Employee.ToListAsync();
        }

        public async Task<List<Employee>?> DeleteEmployee(int id)
        {
            var oneEmployee = await _context.Employee.FindAsync(id);
            if (oneEmployee is null)
                return null;

            _context.Employee.Remove(oneEmployee);

            await _context.SaveChangesAsync();


            return await _context.Employee.ToListAsync();
        }

        public async Task<List<Employee>> GetAllEmployee()
        {
            var employees = await _context.Employee.ToListAsync();
            return employees;
        }

        public async Task<Employee?> GetSingleEmployee(int id)
        {
            var oneEmployee = await _context.Employee.FindAsync(id);
            if (oneEmployee is null)
                return null;
            return oneEmployee;
        }

        public async Task<List<Employee>?> UpdateEmployee(int id, Employee request)
        {
            var oneEmployee = await _context.Employee.FindAsync(id);
            if (oneEmployee is null)
                return null;

            oneEmployee.Id = request.Id;
            oneEmployee.Name = request.Name;
            oneEmployee.Email = request.Email;
            oneEmployee.Identifier = request.Identifier;
            oneEmployee.PostId = request.PostId;
            oneEmployee.Post = request.Post;

            await _context.SaveChangesAsync();

            return await _context.Employee.ToListAsync();
        }
    }
}
