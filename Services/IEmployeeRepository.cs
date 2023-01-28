using BlazorCrud.Data;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorCrud.Services
{
    public interface IEmployeeRepository
    {
        public Task<List<EmployeeModel>> GetAllEmployee();
        public Task<EmployeeModel> GetEmployeeById(int id);
        public Task<int> AddEmployee(EmployeeModel employee);
        public Task<int> UpdateEmployee(EmployeeModel employee);
        public Task<int> DeleteEmployee(int id);
    }
}
