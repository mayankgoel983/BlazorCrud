using System.ComponentModel.DataAnnotations;

namespace BlazorCrud.Data
{
    public class EmployeeModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Please Enter Name")]
        [MinLength(3,ErrorMessage = "Length Should be more than 3")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please Enter Age"), Range(1,100,ErrorMessage = "Age must be between 1 and 100")]
        public int Age { get; set; }
        [Required(ErrorMessage = "Please Enter Position")]
        [MinLength(3, ErrorMessage = "Length Should be more than 2")]
        public string Position { get; set; }
        [Required(ErrorMessage = "Please Enter City")]
        [MinLength(3, ErrorMessage = "Length Should be more than 3")]
        public string City { get;set; }
    }
}
