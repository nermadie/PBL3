using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL3.DTO.DTO_Person;

namespace PBL3.DTO.DTO_Order
{
    public sealed class Order
    {
        public Order()
        {
            PopcornDrinkOrders = new HashSet<PopcornDrinkOrder>();
            TicketOrders = new HashSet<TicketOrder>();
        }
        [Key]
        public string IdOrder { get; set; }
        public string IdCustomer { get; set; }
        [Required]
        public DateTime TimeOrder { get; set; }
        public string Code { get; set; }
        //Navigation Properties
        [ForeignKey("IdCustomer")]
        public Customer Customer { get; set; }
        public ICollection<PopcornDrinkOrder> PopcornDrinkOrders { get; set; }
        public ICollection<TicketOrder> TicketOrders { get; set; }
    }
}
