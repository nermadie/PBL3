using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.DTO.DTO_View
{
    public class Detail_Employee
    {
        public string IdPerson { get; set; }
        public string NamePerson { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public bool Gender { get; set; }
        public DateTime Birth { get; set; }
        public string Username { get; set; }
        public int Shift { get; set; }
        public int Wage { get; set; }
    }
}
