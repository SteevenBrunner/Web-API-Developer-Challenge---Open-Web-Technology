using Microsoft.VisualBasic.CompilerServices;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Web_API_Developer_Challenge___Open_Web_Technology.Models;

namespace Web_API_Developer_Challenge___Open_Web_Technology
{
    public class Contact
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Firstname is required")]
        [StringLength(50, ErrorMessage = "First name cannot be longer than 50 characters.")]
        public string Firstname { get; set; }

        [Required(ErrorMessage = "Lastname is required")]
        [StringLength(50, ErrorMessage = "First name cannot be longer than 50 characters.")]
        public string Lastname { get; set; }

        [Required(ErrorMessage = "Fullname is required")]
        [StringLength(100, ErrorMessage = "First name cannot be longer than 100 characters.")]
        public string Fullname { get; set; }

        [Required(ErrorMessage = "Address is required")]
        [StringLength(200, ErrorMessage = "First name cannot be longer than 150 characters.")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Mobile no. is required")]
        [RegularExpression("^(?!0+$)(\\+\\d{1,3}[- ]?)?(?!0+$)\\d{10,15}$", ErrorMessage = "Please enter valid phone no.")]
        public string MobilePhoneNumber { get; set; }

        
        public List<Skills> SkillId { get; set; }
    }
}
