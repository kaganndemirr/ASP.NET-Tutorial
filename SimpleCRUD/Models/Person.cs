using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SimpleCRUD.Models
{
    public class Person
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("First Name")]
        [Required(ErrorMessage = "This field is required")]
        public string FirstName { get; set; } = string.Empty;

        [DisplayName("Second Name")]
        public string SecondName { get; set; } = string.Empty;

        [DisplayName("Last Name")]
        [Required(ErrorMessage = "This field is required")]
        public string LastName { get; set; } = string.Empty;

        [DisplayName("Birthday")]
        public DateTime BirthDate { get; set; }

        [Required(ErrorMessage = "This field is required")]
        public string Phone { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public string Address { get; set; } = string.Empty;

        public string From { get; set; } = string.Empty;

        [DisplayName("Personnel ?")]
        [Required(ErrorMessage = "This field is required")]
        public bool isPersonnel { get; set; }

        public string Title { get; set; } = string.Empty;

        [Required(ErrorMessage = "This field is required")]
        public int InstutionNumber { get; set; }


    }
}
