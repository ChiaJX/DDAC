﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Sportswear.Models
{
    public class registerStaff
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Email { get; set; }


        [Required]
        public string Password { get; set; }

        [Required]
        public string Role { get; set; }



    }
}