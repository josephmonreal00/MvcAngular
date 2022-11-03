using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NikeCopy.ViewModels
{
    public class ContactViewModel
    {
        [Required]
        [MinLength(5, ErrorMessage = "Too Short")]
        public string FirstName { get; set; }
        [Required]
        [MinLength(5)]
        public string LastName { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        //[PasswordPropertyText]
        public string Password { get; set; }
        [Required]
        [MaxLength(255, ErrorMessage = "Too Long")]
        public string Message { get; set; }
    }
}
