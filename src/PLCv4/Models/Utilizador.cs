﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PLCv4.Models
{
    public class Utilizador : IdentityUser
    {
        public string Name { get; set; }
    }
}
