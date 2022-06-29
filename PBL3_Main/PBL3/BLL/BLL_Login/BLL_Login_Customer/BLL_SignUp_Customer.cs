using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms.Suite;
using PBL3.DTO.DTO_Person;

namespace PBL3.BLL.BLL_Login.BLL_Login_Admin
{
    public partial class BLL_Login_Customer
    {
        public bool checkUsernameSignUp(string username)
        {
            var result = db.Customers.Where(u => u.Username == username).ToList();
            return !(result.Count > 0);
        }

        private string converttoFormatIdCustomer(int id)
        {
            int count = 0, id_clone = id;
            while (true)
            {
                if (id_clone == 0)
                    break;
                count++;
                id_clone /= 10;
            }

            string str = "customer";
            for (int i = 0; i < 6 - count; i++)
                str += "0";
            str += id;
            return str;
        }
        private string findGoodIdCustomer()
        {
            var result = db.Customers.Select(cus => cus).Count();
            return converttoFormatIdCustomer(result + 1);
        }
        public void addCustomertoDatabase(string username, string password, string name)
        {
            Customer temp = new Customer
            {
                IdPerson = findGoodIdCustomer(),
                Username = username,
                Password = password,
                NamePerson = name,
                Birth = DateTime.MaxValue//default value
            };
            db.Customers.Add(temp);
            db.SaveChanges();
        }
    }
}
