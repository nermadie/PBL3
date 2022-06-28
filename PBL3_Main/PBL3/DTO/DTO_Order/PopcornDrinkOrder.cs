﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.DTO.DTO_Order
{
    public class PopcornDrinkOrder
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdPopcornDrinkOrder { get; set; }
        public int IdOrder { get; set; }
        public string NamePopcornDrink { get; set; }
        public int PopcornDrinkPrice { get; set; }
        public int Quantity { get; set; }
        //Navigation Properties
        [ForeignKey("IdOrder")]
        public virtual Order Order { get; set; }
    }
}
