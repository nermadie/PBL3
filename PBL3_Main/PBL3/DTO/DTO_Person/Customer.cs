using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL3.DTO.DTO_Order;

namespace PBL3.DTO.DTO_Person
{
    public class Customer : Person
    {
        public Customer()
        {
            Orders = new HashSet<Order>();
        }
        public bool Vip { get; set; }
        //Navigation Properties
        public virtual ICollection<Order> Orders { get; set; }
    }
}
