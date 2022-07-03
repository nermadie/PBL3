using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.DTO.DTO_View
{
    public class Detail_PopcornDrinkOrder
    {
        //no need IdPopcornDrinkOrder
        public string IdOrder { get; set; }
        public string NamePopcornDrink { get; set; }
        public int PopcornDrinkPrice { get; set; }
        public int Quantity { get; set; }
    }
}
