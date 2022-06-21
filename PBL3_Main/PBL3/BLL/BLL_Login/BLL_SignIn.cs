using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL3.DAL;

namespace PBL3.BLL.BLL_Login
{
    public partial class BLL_Login
    {
        private QLRapChieuPhim db = new QLRapChieuPhim();
        private static BLL_Login _Instance;

        public static BLL_Login Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new BLL_Login();
                }

                return _Instance;
            }
            private set { }
        }
        private BLL_Login()
        {
        }

        public bool checkUsername(string username)
        {
            var result = db.Customers.Where(u => u.Username == username).ToList();
            if (result.Count > 1)
            {
                throw new Exception("Database dang co 2 Customer co cung Username");
            }
            return result.Count > 0;
        }
        public bool checkAccount(string username, string password)
        {
            var result = db.Customers.Where(u => u.Username == username && u.Password == password).ToList();
            if (result.Count > 1)
            {
                throw new Exception("Database đang có 2 Customer có cùng Username");
            }
            return result.Count > 0;
        }
    }
}
