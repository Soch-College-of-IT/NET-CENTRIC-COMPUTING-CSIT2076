using System.ComponentModel.DataAnnotations;

namespace ModelBindingDemo.Models
{
    public class UserViewModel
    {
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
    }
}
