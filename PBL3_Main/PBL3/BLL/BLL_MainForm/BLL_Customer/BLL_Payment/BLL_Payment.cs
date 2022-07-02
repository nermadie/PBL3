using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL3.DTO.DTO_Order;
using PBL3.DTO.DTO_ShowTime;
using PBL3.EntityFramework;

namespace PBL3.BLL.BLL_MainForm.BLL_Customer.BLL_Payment
{
    public class BLL_Payment
    {
        private QLRapChieuPhim db = new QLRapChieuPhim();
        private static BLL_Payment _Instance;
        public static BLL_Payment Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new BLL_Payment();
                }

                return _Instance;
            }
            private set { }
        }
        private BLL_Payment()
        {
        }
        private string converttoFormatIdOrder(int id)
        {
            int count = 0, id_clone = id;
            while (true)
            {
                if (id_clone == 0)
                    break;
                count++;
                id_clone /= 10;
            }

            string str = "order";
            for (int i = 0; i < 8 - count; i++)
                str += "0";
            str += id;
            return str;
        }
        public string findGoodIdOrder()
        {
            var result = db.Orders.Select(o => o).Count();
            return converttoFormatIdOrder(result + 1);
        }
        private Random random = new Random();

        public string RandomString(int length)
        {
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            while (true)
            {
                string temp = new string(Enumerable.Repeat(chars, length)
                    .Select(s => s[random.Next(s.Length)]).ToArray());
                if (db.Orders.Count(o => o.Code == temp) == 0)
                {
                    return temp;
                }
            }
        }

        public void AddOrder(Order order)
        {
            db.Orders.Add(order);
            db.SaveChanges();
        }
        private string converttoFormatIdTicketOrder(int id)
        {
            int count = 0, id_clone = id;
            while (true)
            {
                if (id_clone == 0)
                    break;
                count++;
                id_clone /= 10;
            }

            string str = "ticketorder";
            for (int i = 0; i < 8 - count; i++)
                str += "0";
            str += id;
            return str;
        }
        public string findGoodIdTicketOrder()
        {
            var result = db.TicketOrders.Select(to => to).Count();
            return converttoFormatIdTicketOrder(result + 1);
        }
        public void AddTicketOrder(TicketOrder torder)
        {
            db.TicketOrders.Add(torder);
            db.SaveChanges();
        }

        public void UpdateShowtimeSeats(string seat, string idRoom, DateTime time)
        {
            ShowTime temp = db.ShowTimes.Find(idRoom, time);
            int index = 0;
            switch (seat[0])
            {
                case 'A':
                    index = 0 * 10 + Convert.ToInt32(seat[1].ToString());
                    break;
                case 'B':
                    index = 1 * 10 + Convert.ToInt32(seat[1].ToString());
                    break;
                case 'C':
                    index = 2 * 10 + Convert.ToInt32(seat[1].ToString());
                    break;
                case 'D':
                    index = 3 * 10 + Convert.ToInt32(seat[1].ToString());
                    break;
                case 'E':
                    index = 4 * 10 + Convert.ToInt32(seat[1].ToString());
                    break;
                case 'F':
                    index = 5 * 10 + Convert.ToInt32(seat[1].ToString());
                    break;
                case 'G':
                    index = 6 * 10 + Convert.ToInt32(seat[1].ToString());
                    break;
                case 'H':
                    index = 7 * 10 + Convert.ToInt32(seat[1].ToString());
                    break;
            }

            StringBuilder sb = new StringBuilder(temp.Seat);
            MessageBox.Show($"{index}, {sb}");
            sb[index] = '1';
            temp.Seat = sb.ToString();
            db.SaveChanges();
        }
        private string converttoFormatIdPDOrder(int id)
        {
            int count = 0, id_clone = id;
            while (true)
            {
                if (id_clone == 0)
                    break;
                count++;
                id_clone /= 10;
            }

            string str = "pdorder";
            for (int i = 0; i < 8 - count; i++)
                str += "0";
            str += id;
            return str;
        }
        public string findGoodIdPDOrder()
        {
            var result = db.PopcornDrinkOrders.Select(pdo => pdo).Count();
            return converttoFormatIdPDOrder(result + 1);
        }
        public void AddPDOrder(PopcornDrinkOrder pdorder)
        {
            db.PopcornDrinkOrders.Add(pdorder);
            db.SaveChanges();
        }
    }
}
