﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ThreatSystem.Models
{
    public class Goods
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
        [MaxLength(50)]
        public string Description { get; set; }

        public Threat Threat { get; set; }
        public int ThreatId { get; set; }
    }
}
