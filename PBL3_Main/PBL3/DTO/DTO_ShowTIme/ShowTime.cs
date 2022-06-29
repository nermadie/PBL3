using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL3.DTO.DTO_Order;

namespace PBL3.DTO.DTO_ShowTime
{
    public sealed class ShowTime
    {
        public ShowTime()
        {
            TicketOrders = new HashSet<TicketOrder>();
        }
        public string IdMovie { get; set; }
        [Key, Column(Order = 1)]
        public string IdRoom { get; set; }
        [Key, Column(Order = 2)]
        public DateTime Time { get; set; }
        public string Seat { get; set; }
        public int TicketPrice { get; set; }
        //Navigaion Properties
        [ForeignKey("IdMovie")]
        public Movie Movie { get; set; }
        [ForeignKey("IdRoom")]
        public Room Room { get; set; }
        public ICollection<TicketOrder> TicketOrders { get; set; }
    }
}
