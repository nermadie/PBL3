using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.DTO.DTO_View
{
    public class Detail_TicketOrder
    {
        //no need IdTicketOrder 
        public string IdOrder { get; set; }
        public string NameRoom { get; set; }
        public DateTime Time { get; set; }
        public string SeatPurchased { get; set; }
    }
}
