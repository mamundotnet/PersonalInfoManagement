using System.ComponentModel.DataAnnotations;

namespace PersonalInfoManagement.Models.DbModels
{
    public class PersonalInfo
    {
        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string Gender { get; set; }

        public string Address { get; set; }

        public string Nationality { get; set; }

        public DateTime CreatedDate { get; set; }
    }
}
