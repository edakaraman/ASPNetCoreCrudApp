﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class StuClass
    {
        [Key]
        public int ID { get; set; }
        public string Classes { get; set; }

    }
}
