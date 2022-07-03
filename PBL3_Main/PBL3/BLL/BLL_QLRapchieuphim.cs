using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;
using PBL3.DTO.DTO_Order;
using PBL3.DTO.DTO_Person;
using PBL3.DTO.DTO_PopcornDrink;
using PBL3.DTO.DTO_ShowTime;
using PBL3.DTO.DTO_View;
using PBL3.EntityFramework;
using PBL3.GUI.DelegateTemplate;
using ListItem = PBL3.GUI.GUI_AdditionalUserControl.UC_ButtonTimePrice.ListItem;

namespace PBL3.BLL
{
    public partial class BLL_QLRapchieuphim
    {
        private QLRapChieuPhim db = new QLRapChieuPhim();
        private static BLL_QLRapchieuphim _Instance;

        public static BLL_QLRapchieuphim Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new BLL_QLRapchieuphim();
                }

                return _Instance;
            }
            private set { }
        }
        private BLL_QLRapchieuphim()
        {
        }
        public bool checkUsernameSignInAdmin(string username)
        {
            var result = db.Admins.Where(u => u.Username == username).ToList();
            if (result.Count > 1)
            {
                throw new Exception("Database dang co 2 Admin co cung Username");
            }
            return result.Count > 0;
        }
        public Admin checkAccountSignInAdmin(string username, string password)
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
        public string checkUsernameForgotCustomer(string username)
        {
            var result = db.Customers.Where(u => u.Username == username).ToList();
            if (result.Count > 1)
                throw new Exception("Database dang co 2 Customer co cung Username");
            else if (result.Count == 0)
                return "";
            return result[0].Password;
        }
        public bool checkUsernameSignInCustomer(string username)
        {
            var result = db.Customers.Where(u => u.Username == username).ToList();
            if (result.Count > 1)
            {
                throw new Exception("Database dang co 2 Customer co cung Username");
            }
            return result.Count > 0;
        }
        public Customer checkAccountSignInCustomer(string username, string password)
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
        public bool checkUsernameSignUpCustomer(string username)
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
        public bool checkUsernameSignInEmployee(string username)
        {
            var result = db.Employees.Where(u => u.Username == username).ToList();
            if (result.Count > 1)
            {
                throw new Exception("Database dang co 2 Employee co cung Username");
            }
            return result.Count > 0;
        }
        public Employee checkAccountSignInEmployee(string username, string password)
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
        public Movie getMoviebyIdMovie(string idMovie)
        {
            return db.Movies.FirstOrDefault(m => m.IdMovie == idMovie);
        }
        public List<Movie> getMovies(string text, string sortBy, string category)
        {
            var listAllMovie = db.Movies.ToList();
            if (sortBy == "Latest" && category == "All")
                return listAllMovie.Where(m => m.NameMovie.ToLower().Contains(text.ToLower())).OrderByDescending(m => m.ReleaseDate).ToList();
            if (sortBy == "Latest" && category != "All")
                return listAllMovie.Where(m => m.NameMovie.ToLower().Contains(text.ToLower()) && m.Category.Contains(category)).OrderByDescending(m => m.ReleaseDate).ToList();
            if (sortBy == "Popular" && category != "All")
                return listAllMovie.Where(m => m.NameMovie.ToLower().Contains(text.ToLower()) && m.Category.Contains(category)).OrderByDescending(m => m.Rate).ToList();
            if (sortBy == "Popular" && category == "All")
                return listAllMovie.Where(m => m.NameMovie.ToLower().Contains(text.ToLower())).OrderByDescending(m => m.Rate).ToList();
            throw new Exception("Wrong");
        }

        public CBBItem[] getCBBCategory()
        {
            List<string> categories = new List<string>();
            var category_strings = db.Movies.Select(m => m.Category).ToList();
            string[] separatingStrings = { ", " };
            foreach (string category_string in category_strings)
                categories.AddRange(category_string.Split(separatingStrings, System.StringSplitOptions.RemoveEmptyEntries));
            List<CBBItem> res = new List<CBBItem>();
            categories = categories.Distinct().ToList();
            res.Add(new CBBItem
            {
                Text = "All",
                Value = 0
            });
            for (int i = 1; i <= categories.Count; i++)
                res.Add(new CBBItem
                {
                    Text = categories[i - 1],
                    Value = i
                });
            return res.ToArray();
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
        public List<PopcornDrink> getListPopcornDrink()
        {
            return db.PopcornDrinks.ToList();
        }
        public Image getImagebyIdPopcornDrink(string idPopcornDrink)
        {
            try
            {
                using (FileStream stream = new FileStream(@"..\..\Image\Picture\PicturePopcornDrink\" + idPopcornDrink + ".jpg", FileMode.Open, FileAccess.Read))
                {
                    Image temp = Image.FromStream(stream);
                    stream.Dispose();
                    return temp;
                }
            }
            catch (Exception)
            {
                try
                {
                    using (FileStream stream = new FileStream(@"..\..\Image\Picture\PicturePopcornDrink\" + idPopcornDrink + ".png", FileMode.Open, FileAccess.Read))
                    {
                        Image temp = Image.FromStream(stream);
                        stream.Dispose();
                        return temp;
                    }
                }
                catch (Exception)
                {
                    try
                    {
                        using (FileStream stream = new FileStream(@"..\..\Image\Picture\PicturePopcornDrink\" + idPopcornDrink + ".jpeg", FileMode.Open, FileAccess.Read))
                        {
                            Image temp = Image.FromStream(stream);
                            stream.Dispose();
                            return temp;
                        }
                    }
                    catch (Exception)
                    {
                        return null;
                    }
                }
            }
        }

        public PopcornDrink getPDbyidPD(string idPopcornDrink)
        {
            return db.PopcornDrinks.FirstOrDefault(pd => pd.IdPopcornDrink == idPopcornDrink);
        }
        public ListItem[] getListItem(DateTime dateTime, Del_Movie importData, Del_ShowTime buyTicketbyShowTime_Tickets, string text)
        {
            var showTimeinThisDay = db.ShowTimes.Include("Movie").Where(st => DbFunctions.TruncateTime(st.Time) == dateTime.Date).ToList();
            //var movieinThisDay = (from st in showTimeinThisDay group st by st.IdMovie into g select g).ToList();
            var movieinThisDay = showTimeinThisDay.Where(st => st.Movie.NameMovie.ToLower().Contains(text.ToLower())).GroupBy(st => st.IdMovie).ToList();
            int numofMovie = movieinThisDay.Count;
            ListItem[] listItems = new ListItem[numofMovie];
            for (int i = 0; i < numofMovie; i++)
            {
                string tempKey = movieinThisDay[i].Key;
                Movie temp = db.Movies.FirstOrDefault(m => m.IdMovie == tempKey);
                listItems[i] = new ListItem(temp.IdMovie);
                listItems[i].buyTicketbyShowTime_ListItem = buyTicketbyShowTime_Tickets;
                listItems[i].TitleText = temp.NameMovie;
                listItems[i].DescriptionText = temp.Description;
                listItems[i].Rating = (float)temp.Rate;
                listItems[i].PosterImage = getImagebyIdMovie(temp.IdMovie);
                var showTimeByMovieinThisDay =
                    showTimeinThisDay.Where(st => st.IdMovie == temp.IdMovie).OrderBy(st => st.Time).ToList();
                listItems[i].ChangeTimeList(showTimeByMovieinThisDay);
                //set delegate
                listItems[i].importDatatoPanelDetail = importData;
            }
            return listItems;
        }
        public Image getImagebyIdMovie(string idMovie)
        {
            try
            {
                using (FileStream stream = new FileStream(@"..\..\Image\Picture\PictureMovie\" + idMovie + ".jpg", FileMode.Open, FileAccess.Read))
                {
                    Image temp = Image.FromStream(stream);
                    stream.Dispose();
                    return temp;
                }
            }
            catch (Exception)
            {
                try
                {
                    using (FileStream stream = new FileStream(@"..\..\Image\Picture\PictureMovie\" + idMovie + ".png", FileMode.Open, FileAccess.Read))
                    {
                        Image temp = Image.FromStream(stream);
                        stream.Dispose();
                        return temp;
                    }
                }
                catch (Exception)
                {
                    try
                    {
                        using (FileStream stream = new FileStream(@"..\..\Image\Picture\PictureMovie\" + idMovie + ".jpeg", FileMode.Open, FileAccess.Read))
                        {
                            Image temp = Image.FromStream(stream);
                            stream.Dispose();
                            return temp;
                        }
                    }
                    catch (Exception)
                    {
                        return null;
                    }
                }
            }
        }
        public ShowTime getShowTimebyidRoom_Time(string idRoom, DateTime time)
        {
            return db.ShowTimes.Include("Room").Include("Movie").FirstOrDefault(t => t.IdRoom == idRoom && t.Time == time);
        }

        public CBBItemS[] GetCBBHistory(Customer currentCus)
        {
            List<CBBItemS> result = new List<CBBItemS>();
            var orders = db.Orders.Where(o => o.IdCustomer == currentCus.IdPerson).OrderBy(o => o.TimeOrder).ToList();
            foreach (var order in orders)
            {
                CBBItemS temp = new CBBItemS
                {
                    Text = order.TimeOrder.ToString(),
                    Value = order.IdOrder
                };
                result.Add(temp);
            }
            return result.ToArray();
        }

        public Customer getCustomerbyIDCus(string currentCus)
        {
            return db.Customers.FirstOrDefault(c => c.IdPerson == currentCus);
        }

        public List<PopcornDrinkOrder> getDataPDbyIdOrder(string idOrder)
        {
            return db.PopcornDrinkOrders.Where(pco => pco.IdOrder == idOrder).ToList();
        }

        public List<TicketOrder> getDataTicketOrderbyIdOrder(string idOrder)
        {
            return db.TicketOrders.Include("ShowTime.Movie").Include("ShowTime.Room").Include("ShowTime").Where(to => to.IdOrder == idOrder).ToList();
        }

        public string getCodebyIdOrder(string idOrder)
        {
            return db.Orders.FirstOrDefault(o => o.IdOrder == idOrder).Code;
        }

        public Image getImagebyIdPerson(string idPerson)
        {
            try
            {
                using (FileStream stream = new FileStream(@"..\..\Image\Picture\PicturePerson\" + idPerson + ".jpg", FileMode.Open, FileAccess.Read))
                {
                    Image temp = Image.FromStream(stream);
                    stream.Dispose();
                    return temp;
                }
            }
            catch (Exception e)
            {
                try
                {
                    using (FileStream stream = new FileStream(@"..\..\Image\Picture\PicturePerson\" + idPerson + ".png", FileMode.Open, FileAccess.Read))
                    {
                        Image temp = Image.FromStream(stream);
                        stream.Dispose();
                        return temp;
                    }
                }
                catch (Exception e2)
                {
                    try
                    {
                        using (FileStream stream = new FileStream(@"..\..\Image\Picture\PicturePerson\" + idPerson + ".jpeg", FileMode.Open, FileAccess.Read))
                        {
                            Image temp = Image.FromStream(stream);
                            stream.Dispose();
                            return temp;
                        }
                    }
                    catch (Exception e3)
                    {
                        return null;
                    }
                }
            }
        }

        public void delImagebyIdPerson(string idPerson)
        {
            if (File.Exists(@"..\..\Image\Picture\PicturePerson\" + idPerson + ".jpg"))
                File.Delete(@"..\..\Image\Picture\PicturePerson\" + idPerson + ".jpg");
            else if (File.Exists(@"..\..\Image\Picture\PicturePerson\" + idPerson + ".png"))
                File.Delete(@"..\..\Image\Picture\PicturePerson\" + idPerson + ".png");
        }

        public void updateCustomer(Customer cus)
        {
            Customer temp = db.Customers.FirstOrDefault(c => c.IdPerson == cus.IdPerson);
            temp.IdPerson = cus.IdPerson;
            temp.NamePerson = cus.NamePerson;
            temp.Phone = cus.Phone;
            temp.Address = cus.Address;
            temp.Gender = cus.Gender;
            temp.Birth = cus.Birth;
            temp.Username = cus.Username;
            temp.Password = cus.Password;
            db.SaveChanges();
        }

        public Employee getEmployeebyIDEm(string idEmployee)
        {
            return db.Employees.FirstOrDefault(c => c.IdPerson == idEmployee);
        }

        public List<PopcornDrinkOrder> getDataPDbyCode(string text)
        {
            var order = db.Orders.FirstOrDefault(o => o.Code == text);
            if (order != null)
                return db.PopcornDrinkOrders.Where(pdo => pdo.IdOrder == order.IdOrder).ToList();
            return new List<PopcornDrinkOrder>();
        }

        public List<TicketOrder> getDataTicketOrderbyCode(string text)
        {
            var order = db.Orders.FirstOrDefault(o => o.Code == text);
            if (order != null)
                return db.TicketOrders.Include("ShowTime.Movie").Include("ShowTime.Room").Include("ShowTime").Where(to => to.IdOrder == order.IdOrder).ToList();
            return new List<TicketOrder>();
        }

        public void checkCodeforOrder(string text)
        {
            Order order = db.Orders.FirstOrDefault(o => o.Code == text);
            order.Code = null;
            db.SaveChanges();
        }
    }
}
