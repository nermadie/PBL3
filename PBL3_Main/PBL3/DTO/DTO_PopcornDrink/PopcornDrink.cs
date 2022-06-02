using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.DTO.DTO_PopcornDrink
{
    public class PopcornDrink
    {
        [Key]
        [Required]
        public string IdPopcornDrink { get; set; }
        public string NamePopcornDrink { get; set; }
        public int PricePopcornDrink { get; set; }
    }
}
