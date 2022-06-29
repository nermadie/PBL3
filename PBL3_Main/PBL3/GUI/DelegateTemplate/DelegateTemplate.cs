using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL3.DTO.DTO_Person;

namespace PBL3.GUI.DelegateTemplate
{
    public delegate void Del_void();
    public delegate void Del_string(string str);

    public delegate void Del_Customer(Customer cus);
    public delegate void Del_Event(object sender, EventArgs e);
}
