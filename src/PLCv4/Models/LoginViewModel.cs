using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PLCv4.Models
{
    public class LoginViewModel
    {
        [Required]
        [Display(Name = "Utilizador")]
        public string UserName { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Palavra passe")]
        public string Password { get; set; }
        [Display(Name = "Lembrar-me?")]
        public bool RememberMe { get; set; }
    }
}
