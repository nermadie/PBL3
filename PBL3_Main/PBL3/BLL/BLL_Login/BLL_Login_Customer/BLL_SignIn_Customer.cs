using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL3.EntityFramework;
using PBL3.DTO.DTO_Person;

namespace PBL3.BLL.BLL_Login.BLL_Login_Admin
{
    public partial class BLL_Login_Customer
    {
        private QLRapChieuPhim db = new QLRapChieuPhim();
        private static BLL_Login_Customer _Instance;

        public static BLL_Login_Customer Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new BLL_Login_Customer();
                }

                return _Instance;
            }
            private set { }
        }
        private BLL_Login_Customer()
        {
        }
        //For SignIn UserControl
        public bool checkUsernameSignIn(string username)
        {
            var result = db.Customers.Where(u => u.Username == username).ToList();
            if (result.Count > 1)
            {
                throw new Exception("Database dang co 2 Customer co cung Username");
            }
            return result.Count > 0;
        }
        public Customer checkAccountSignIn(string username, string password)
        {
            var result = db.Customers.Where(u => u.Username == username && u.Password == password).ToList();
            Customer customer;
            if (result.Count > 1)
            {
                throw new Exception("Database đang có 2 Customer có cùng Account");
            }
            else
            {
                customer = result.FirstOrDefault();
            }

            return customer;
        }
    }
}
