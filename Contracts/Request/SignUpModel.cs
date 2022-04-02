using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DemoAPI.Contracts.Request
{
    public class SignUpModel
    {
        [Required(ErrorMessage = "Enter your Name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Enter your Email")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Enter your Password")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Confirm your Password")]
        public string ConfirmPassword { get; set; }
        [Required(ErrorMessage = "Enter your Gender")]
        public string Gender { get; set; }
    }
}
