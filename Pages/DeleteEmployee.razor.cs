using BlazorCrud.Data;
using BlazorCrud.Services;
using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;

namespace BlazorCrud.Pages
{
    public partial class DeleteEmployee
    {
        [Parameter]
        public string Id { get; set; }

        public EmployeeModel obj = new EmployeeModel();

        [Inject]
        private IEmployeeRepository employeeRepository { get; set; }

        [Inject]
        private NavigationManager NavigationManager { get; set; }

        protected override async Task OnInitializedAsync()
        {
            obj = await employeeRepository.GetEmployeeById(int.Parse(Id));
        }

        public async void DeleteEmployeeById()
        {
            await employeeRepository.DeleteEmployee(int.Parse(Id));
            NavigationManager.NavigateTo("employee");
        }
    }
}
