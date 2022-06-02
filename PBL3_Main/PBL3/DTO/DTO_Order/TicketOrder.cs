using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL3.DTO.DTO_ShowTime;

namespace PBL3.DTO.DTO_Order

{
    public class TicketOrder
    {
        [Key]
        [Required]
        public string IdTicketOrder { get; set; }
        public string IdOrder { get; set; }

        public string IdRoom { get; set; }
        public DateTime Time { get; set; }
        public string SeatPurchased { get; set; }
        //Navigation Properties
        [ForeignKey("IdRoom, Time")]
        public virtual ShowTime ShowTime { get; set; }
        [ForeignKey("IdOrder")]
        public virtual Order Order { get; set; }
    }
}
