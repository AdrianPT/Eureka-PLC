using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PLCv4.Models
{
    public class UtilizadorViewModel
    {
        public string Id { get; set; }


        [Display(Name = "Utilizador")]
        public string UserName { get; set; }

        [Display(Name = "Palavra passe")]
        [DataType(DataType.Password)]
        public string Password { get; set; }


        [Display(Name = "Confirmar palavra passe")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }

        [Display(Name = "Nome")]
        public string Name { get; set; }

        [Display(Name = "Correio electrónico")]
        public string Email { get; set; }
        public List<SelectListItem> ApplicationRoles { get; set; }



        [Display(Name = "Role")]
        public string ApplicationRoleId { get; set; }
    }
}
