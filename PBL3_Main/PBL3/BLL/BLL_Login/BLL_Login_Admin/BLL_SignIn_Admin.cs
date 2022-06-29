using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL3.EntityFramework;
using PBL3.DTO.DTO_Person;

namespace PBL3.BLL.BLL_Login.BLL_Login_Admin
{
    public class BLL_SignIn_Admin
    {
        private QLRapChieuPhim db = new QLRapChieuPhim();
        private static BLL_SignIn_Admin _Instance;

        public static BLL_SignIn_Admin Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new BLL_SignIn_Admin();
                }

                return _Instance;
            }
            private set { }
        }
        private BLL_SignIn_Admin()
        {
        }
        //For SignIn UserControl
        public bool checkUsernameSignIn(string username)
        {
            var result = db.Admins.Where(u => u.Username == username).ToList();
            if (result.Count > 1)
            {
                throw new Exception("Database dang co 2 Admin co cung Username");
            }
            return result.Count > 0;
        }
        public Admin checkAccountSignIn(string username, string password)
        {
            var result = db.Admins.Where(u => u.Username == username && u.Password == password).ToList();
            Admin admin;
            if (result.Count > 1)
            {
                throw new Exception("Database đang có 2 Admin có cùng Account");
            }
            else
            {
                admin = result.FirstOrDefault();
            }

            return admin;
        }
    }
}
