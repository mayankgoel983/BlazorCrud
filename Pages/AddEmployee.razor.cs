using BlazorCrud.Data;
using BlazorCrud.Services;
using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;

namespace BlazorCrud.Pages
{
    public partial class AddEmployee
    {

        [Inject]
        private IEmployeeRepository _employeeRepository { get; set; }

        [Inject]
        public NavigationManager NavigationManager { get; set; }
        public EmployeeModel obj = new EmployeeModel();

        public async void CreateEmployee()
        {
            await _employeeRepository.AddEmployee(obj);
            NavigationManager.NavigateTo("employee");
        }
    }
}
