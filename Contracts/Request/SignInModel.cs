using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DemoAPI.Contracts.Request
{
    public class SignInModel
    {
        [Required(ErrorMessage="Enter your Email")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Enter your Password")]
        public string Password { get; set; }
    }
}
