﻿using HomePlanIt.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomePlanIt.Models
{
    public class SupplyCreate
    {
        public int SupplyId { get; set; }

        public int DIYId { get; set; }

        [Display(Name = "")]
        public bool AlreadyHave { get; set; }

        public string Brand { get; set; }

        public string Color { get; set; }

        public int Quantity { get; set; }

        [Required]
        [Display(Name = "Item")]
        public string SupplyName { get; set; }

        public decimal TotalCost { get; set; }

        public virtual DIY DIY { get; set; }

        public override string ToString() => SupplyName;  
    }
}
