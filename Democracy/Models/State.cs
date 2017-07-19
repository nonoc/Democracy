﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Democracy.Models
{
    public class State
    {
        [Key]
        public int StateId { get; set; }

        [Required(ErrorMessage ="The field {0} is required")]
        public string Description { get; set; }
    }
}