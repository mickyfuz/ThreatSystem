﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ThreatSystem.Models
{
    public class Threat
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
        [MaxLength(200)]
        public string Description { get; set; }
        [MaxLength(10)]
        public string initials { get; set; }

        public Goods Goods { get; set; }
        public int GoodsId { get; set; }
    }
}
