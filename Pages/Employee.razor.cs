using BlazorCrud.Data;
using BlazorCrud.Services;
using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorCrud.Pages
{
    public partial class Employee
    {
        [Inject]
        private IEmployeeRepository _employeeRepository { get; set; }
        private List<EmployeeModel> _employee = new List<EmployeeModel>();

        protected override async Task OnInitializedAsync()
        {
            await GetAllEmployee();
        }

        public async Task GetAllEmployee()
        {
            _employee = await _employeeRepository.GetAllEmployee();
        }
    }
}
