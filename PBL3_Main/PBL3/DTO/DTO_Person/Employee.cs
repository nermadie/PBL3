using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL3.DTO.DTO_Order;

namespace PBL3.DTO.DTO_Person
{
    public class Employee : Person
    {
        public int Shift { get; set; }
        public int Wage { get; set; }
    }
}
