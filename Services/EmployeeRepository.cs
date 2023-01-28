using BlazorCrud.Data;
using BlazorCrud.Pages;
using BlazorCrud.SqlServer;
using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorCrud.Services
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private Context _dbContext;

        public EmployeeRepository(Context dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<int> AddEmployee(EmployeeModel employee)
        {
            var query = "[dbo].[AddEmployee]";
            var parameters = new { Name = employee.Name, Age = employee.Age, Position = employee.Position, City = employee.City };

            using (var connection = _dbContext.CreateConnection())
            {
                var result = await connection.ExecuteAsync(query, parameters, commandType: CommandType.StoredProcedure);
                return result;
            }
        }

        public async Task<int> DeleteEmployee(int id)
        {
            var query = "[dbo].[DeleteEmployee]";
            var parameters = new { Id = id };

            using (var connection = _dbContext.CreateConnection())
            {
                var result = await connection.ExecuteAsync(query, parameters, commandType: CommandType.StoredProcedure);
                return result;
            }
        }

        public async Task<List<EmployeeModel>> GetAllEmployee()
        {
            var query = "[dbo].[GetEmployee]";

            using (var connection = _dbContext.CreateConnection())
            {
                var employees = await connection.QueryAsync<EmployeeModel>(query, commandType: CommandType.StoredProcedure);
                return employees.ToList();
            }
        }

        public async Task<EmployeeModel> GetEmployeeById(int id)
        {
            var query = "[dbo].[GetEmployeeById]";
            var parameters = new { Id = id };

            using (var connection = _dbContext.CreateConnection())
            {
                var employee = await connection.QuerySingleOrDefaultAsync<EmployeeModel>(query, parameters, commandType: CommandType.StoredProcedure);
                return employee;
            }
        }

        public async Task<int> UpdateEmployee(EmployeeModel employee)
        {
            var query = "[dbo].[UpdateEmployee]";
            var parameters = new { Id = employee.Id, Name = employee.Name, Age = employee.Age, Position = employee.Position, City = employee.City };

            using (var connection = _dbContext.CreateConnection())
            {
                var result = await connection.ExecuteAsync(query, parameters, commandType: CommandType.StoredProcedure);
                return result;
            }
        }
    }
}
