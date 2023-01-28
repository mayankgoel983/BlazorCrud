using BlazorCrud.Data;
using BlazorCrud.Services;
using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;

namespace BlazorCrud.Pages
{
    public partial class EditEmployee
    {
        [Parameter]
        public string Id { get; set; }
        [Inject]
        private NavigationManager NavigationManager { get; set; }
        [Inject]
        private IEmployeeRepository _employeeRepository { get; set; }
        public EmployeeModel obj = new EmployeeModel();

        protected override async Task OnInitializedAsync()
        {
            obj = await _employeeRepository.GetEmployeeById(int.Parse(Id));
        }

        public async void UpdateEmployee()
        {
            obj.Id = int.Parse(Id);
            await _employeeRepository.UpdateEmployee(obj);
            NavigationManager.NavigateTo("employee");
        }

    }
}
