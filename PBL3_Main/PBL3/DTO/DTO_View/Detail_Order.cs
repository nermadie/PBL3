using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.DTO.DTO_View
{
    public class Detail_Order
    {
        public string IdOrder { get; set; }
        public string IdPerson { get; set; }
        public DateTime TimeOrder { get; set; }
        public int TotalCost { get; set; }
        //CBBIdPerson - filter
        //CBBSort - TotalCost, TimeOrder
    }
}
