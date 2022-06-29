using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL3.EntityFramework;
using PBL3.DTO.DTO_Person;

namespace PBL3.BLL.BLL_Login.BLL_Login_Employee
{
    public class BLL_SignIn_Employee
    {
        private QLRapChieuPhim db = new QLRapChieuPhim();
        private static BLL_SignIn_Employee _Instance;

        public static BLL_SignIn_Employee Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new BLL_SignIn_Employee();
                }

                return _Instance;
            }
            private set { }
        }
        private BLL_SignIn_Employee()
        {
        }
        //For SignIn UserControl
        public bool checkUsernameSignIn(string username)
        {
            var result = db.Employees.Where(u => u.Username == username).ToList();
            if (result.Count > 1)
            {
                throw new Exception("Database dang co 2 Employee co cung Username");
            }
            return result.Count > 0;
        }
        public Employee checkAccountSignIn(string username, string password)
        {
            var result = db.Employees.Where(u => u.Username == username && u.Password == password).ToList();
            Employee employee;
            if (result.Count > 1)
            {
                throw new Exception("Database đang có 2 Employee có cùng Account");
            }
            else
            {
                employee = result.FirstOrDefault();
            }

            return employee;
        }
    }
}
