using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL3.DTO.DTO_Person;

namespace PBL3.BLL.BLL_Login.BLL_Login_Admin
{
    public partial class BLL_Login_Customer
    {
        public string checkUsernameForgot(string username)
        {
            var result = db.Customers.Where(u => u.Username == username).ToList();
            if (result.Count > 1)
                throw new Exception("Database dang co 2 Customer co cung Username");
            else if (result.Count == 0)
                return "";
            return result[0].Password;
        }
    }
}
