using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL3.DTO.DTO_Order;
using PBL3.DTO.DTO_Person;
using PBL3.DTO.DTO_PopcornDrink;
using PBL3.DTO.DTO_ShowTime;
using PBL3.DTO.DTO_View;
using PBL3.EntityFramework;

namespace PBL3.BLL.BLL_MainForm.BLL_Admin
{
    public class BLL_Admin
    {
        private static BLL_Admin _Instance;

        public static BLL_Admin Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new BLL_Admin();
                return _Instance;
            }
            private set { }
        }
        private QLRapChieuPhim db;
        private BLL_Admin()
        {
            db = new QLRapChieuPhim();
        }
        public void CreateDB_Once()
        {

        }
        //PopcornDrink
        public string GetNew_IdPopcornDrink() //pd****
        {
            int count = GetAll_PopcornDrink().Count;
            string curMax = GetAll_PopcornDrink().OrderBy(p => p.IdPopcornDrink).ElementAt(count - 1).IdPopcornDrink;
            int newMax = Convert.ToInt32(curMax[2].ToString() + curMax[3] + curMax[4] + curMax[5]) + 1;
            return "pd" + newMax.ToString();
        }
        public List<PopcornDrink> GetAll_PopcornDrink()
        {
            return db.PopcornDrinks.ToList();
        }
        public PopcornDrink Find_PopcornDrink_By_IdPopcornDrink(string _IdPopcornDrink)
        {
            return db.PopcornDrinks.Find(_IdPopcornDrink);
        }
        public bool CheckExist_PopcornDrink_By_IdPopcornDrink(string _IdPopcornDrink)
        {
            return Find_PopcornDrink_By_IdPopcornDrink(_IdPopcornDrink) != null;
        }
        public string Get_IdPopcornDrink_By_NamePopcornDrink(string _NamePopcornDrink)
        {
            if (db.PopcornDrinks.FirstOrDefault(x => x.NamePopcornDrink == _NamePopcornDrink) != null)
            {
                return db.PopcornDrinks.FirstOrDefault(x => x.NamePopcornDrink == _NamePopcornDrink).IdPopcornDrink;
            }
            return "not found";
        }
        public string AddUpdate_PopcornDrink(PopcornDrink pd)
        {
            if (Get_IdPopcornDrink_By_NamePopcornDrink(pd.NamePopcornDrink) != "not found")
            {
                pd.IdPopcornDrink = GetNew_IdPopcornDrink();
                db.PopcornDrinks.Add(pd);
                db.SaveChanges();
                return "Added";
            }
            else
            {
                PopcornDrink found = Find_PopcornDrink_By_IdPopcornDrink(Get_IdPopcornDrink_By_NamePopcornDrink(pd.NamePopcornDrink));
                found.PricePopcornDrink = pd.PricePopcornDrink;
                db.SaveChanges();
                return "Updated";
            }
        }
        public void Delete_PopcornDrink_By_IdPopcornDrink(string _IdPopcornDrink)
        {
            PopcornDrink pd = db.PopcornDrinks.Find(_IdPopcornDrink);
            db.PopcornDrinks.Remove(pd);
            db.SaveChanges();
        }
        public void DeleteRange_PopcornDrink(List<string> _IdPopcornDrinks)
        {
            foreach (string id in _IdPopcornDrinks)
            {
                Delete_PopcornDrink_By_IdPopcornDrink(id);
            }
        }
        //Admin
        public List<Admin> GetAll_Admin()
        {
            return db.Admins.ToList();
        }
        public Admin Find_Admin_By_IdAdmin(string _IdAdmin)
        {
            return db.Admins.Find(_IdAdmin);
        }
        public bool CheckExist_Admin_By_IdAdmin(string _IdAdmin)
        {
            return Find_Admin_By_IdAdmin(_IdAdmin) != null;
        }
        public string AddUpdate_Admin(Admin am)
        {
            if (CheckExist_Admin_By_IdAdmin(am.IdPerson) != false)
            {
                db.Admins.Add(am);
                db.SaveChanges();
                return "Added";
            }
            else
            {
                Admin found = Find_Admin_By_IdAdmin(am.IdPerson);
                found.NamePerson = am.NamePerson;
                found.Address = am.Address;
                found.Phone = am.Phone;
                found.Birth = am.Birth;
                found.Gender = am.Gender;
                found.Username = am.Username;
                found.Password = am.Password;
                db.SaveChanges();
                return "Updated";
            }
        }
        public void Delete_Admin_By_IdAdmin(string _IdAdmin)
        {
            Admin am = db.Admins.Find(_IdAdmin);
            db.Admins.Remove(am);
            db.SaveChanges();
        }
        public void DeleteRange_Admin(List<string> _IdAdmins)
        {
            foreach (string id in _IdAdmins)
            {
                Delete_Admin_By_IdAdmin(id);
            }
        }
        //Customer
        public List<Customer> GetAll_Customer()
        {
            return db.Customers.ToList();
        }
        public Customer Find_Customer_By_IdCustomer(string _IdCustomer)
        {
            return db.Customers.Find(_IdCustomer);
        }
        public bool CheckExist_Customer_By_IdCustomer(string _IdCustomer)
        {
            return Find_Customer_By_IdCustomer(_IdCustomer) != null;
        }
        public string AddUpdate_Customer(Customer ctm)
        {
            if (CheckExist_Customer_By_IdCustomer(ctm.IdPerson) != false)
            {
                db.Customers.Add(ctm);
                db.SaveChanges();
                return "Added";
            }
            else
            {
                Customer found = Find_Customer_By_IdCustomer(ctm.IdPerson);
                found.NamePerson = ctm.NamePerson;
                found.Address = ctm.Address;
                found.Phone = ctm.Phone;
                found.Birth = ctm.Birth;
                found.Gender = ctm.Gender;
                found.Username = ctm.Username;
                found.Password = ctm.Password;
                found.Vip = ctm.Vip;
                db.SaveChanges();
                return "Updated";
            }
        }
        public void Delete_Customer_By_IdCustomer(string _IdCustomer)
        {
            Customer ctm = db.Customers.Find(_IdCustomer);
            db.Customers.Remove(ctm);
            db.SaveChanges();
        }
        public void DeleteRange_Customer(List<string> _IDCustomers)
        {
            foreach (string id in _IDCustomers)
            {
                Delete_Customer_By_IdCustomer(id);
            }
        }
        //Employee
        public List<Employee> GetAll_Employee()
        {
            return db.Employees.ToList();
        }
        public Employee Find_Employee_By_IdEmployee(string _IdEmployee)
        {
            return db.Employees.Find(_IdEmployee);
        }
        public bool CheckExist_Employee_By_IdEmployee(string _IdEmployee)
        {
            return Find_Employee_By_IdEmployee(_IdEmployee) != null;
        }
        public string AddUpdate_Employee(Employee eple)
        {
            if (CheckExist_Employee_By_IdEmployee(eple.IdPerson) != false)
            {
                db.Employees.Add(eple);
                db.SaveChanges();
                return "Added";
            }
            else
            {
                Employee found = Find_Employee_By_IdEmployee(eple.IdPerson);
                found.NamePerson = eple.NamePerson;
                found.Address = eple.Address;
                found.Phone = eple.Phone;
                found.Birth = eple.Birth;
                found.Gender = eple.Gender;
                found.Username = eple.Username;
                found.Password = eple.Password;
                found.Wage = eple.Wage;
                found.Shift = eple.Shift;
                db.SaveChanges();
                return "Updated";
            }
        }
        public void Delete_Employee_By_IdEmployee(string _IdEmployee)
        {
            Employee eple = db.Employees.Find(_IdEmployee);
            db.Employees.Remove(eple);
            db.SaveChanges();
        }
        public void DeleteRange_Employee(List<string> _IDEmployees)
        {
            foreach (string id in _IDEmployees)
            {
                Delete_Employee_By_IdEmployee(id);
            }
        }
        //Movie
        public List<Movie> GetAll_Movie()
        {
            return db.Movies.ToList();
        }
        public Movie Find_Movie_By_IdMovie(string _IdMovie)
        {
            return db.Movies.Find(_IdMovie);
        }
        public bool CheckExist_Movie_By_IdMovie(string _IdMovie)
        {
            return Find_Movie_By_IdMovie(_IdMovie) != null;
        }
        public string AddUpdate_Moive(Movie mv)
        {
            if (CheckExist_Movie_By_IdMovie(mv.IdMovie) != false)
            {
                db.Movies.Add(mv);
                db.SaveChanges();
                return "Added";
            }
            else
            {
                Movie found = Find_Movie_By_IdMovie(mv.IdMovie);
                found.NameMovie = mv.NameMovie;
                found.Director = mv.Director;
                found.Actor = mv.Actor;
                found.Duration = mv.Duration;
                found.Rate = mv.Rate;
                found.Description = mv.Description;
                found.Category = mv.Category;
                found.ReleaseDate = mv.ReleaseDate;
                found.LinkTrailer = mv.LinkTrailer;
                db.SaveChanges();
                return "Updated";
            }
        }
        public void Delete_Movie_By_IdMovie(string _IdMovie)
        {
            Movie mv = db.Movies.Find(_IdMovie);
            db.Movies.Remove(mv);
            db.SaveChanges();
        }
        public void DeleteRange_Movie(List<string> _IdMoives)
        {
            foreach (string id in _IdMoives)
            {
                Delete_Movie_By_IdMovie(id);
            }
        }
        //Room
        public List<Room> GetAll_Room()
        {
            return db.Rooms.ToList();
        }
        public Room Find_Room_By_IdRoom(string _IdRoom)
        {
            return db.Rooms.Find(_IdRoom);
        }
        public bool CheckExist_Room_By_IdRoom(string _IdRoom)
        {
            return Find_Room_By_IdRoom(_IdRoom) != null;
        }
        public string AddUpdate_Room(Room r)
        {
            if (CheckExist_Room_By_IdRoom(r.IdRoom) != false)
            {
                db.Rooms.Add(r);
                db.SaveChanges();
                return "Added";
            }
            else
            {
                Room found = Find_Room_By_IdRoom(r.IdRoom);
                found.NameRoom = r.NameRoom;
                found.NumberSeats = r.NumberSeats;
                db.SaveChanges();
                return "Updated";
            }
        }
        public void Delete_Room_By_IdRoom(string _IdRoom)
        {
            Room r = db.Rooms.Find(_IdRoom);
            db.Rooms.Remove(r);
            db.SaveChanges();
        }
        public void DeleteRange_Room(List<string> _IdRooms)
        {
            foreach (string id in _IdRooms)
            {
                Delete_Room_By_IdRoom(id);
            }
        }
        //ShowTime
        public List<ShowTime> Get_ShowTime_From_Today_With_IdMovie(string _ValueCBBMovie) //aka IdMovie
        {
            List<ShowTime> stList = new List<ShowTime>();
            if (_ValueCBBMovie == "All")
            {
                stList = db.ShowTimes.Where(x => DateTime.Compare(x.Time, DateTime.Now) > 0).ToList();
            }
            else
            {
                stList = db.ShowTimes.Where(x => DateTime.Compare(x.Time, DateTime.Now) > 0 && x.IdMovie == _ValueCBBMovie).ToList();
            }
            return stList;
        }
        public List<ShowTime> GetAll_ShowTime()
        {
            return db.ShowTimes.ToList();
        }
        public ShowTime Find_ShowTime_By_IdRoom_And_Time(string _IdRoom, DateTime _Time)
        {
            return db.ShowTimes.Find(_IdRoom, _Time);
        }
        public bool CheckExist_ShowTime_By_IdRoom_And_Time(string _IdRoom, DateTime _Time)
        {
            return Find_ShowTime_By_IdRoom_And_Time(_IdRoom, _Time) != null;
        }
        public string AddUpdate_ShowTime(ShowTime st)
        {
            if (CheckExist_ShowTime_By_IdRoom_And_Time(st.IdRoom, st.Time) != false)
            {
                db.ShowTimes.Add(st);
                db.SaveChanges();
                return "Added";
            }
            else
            {
                ShowTime found = Find_ShowTime_By_IdRoom_And_Time(st.IdRoom, st.Time);
                found.IdMovie = st.IdMovie;
                found.Seat = st.Seat;
                found.TicketPrice = st.TicketPrice;
                db.SaveChanges();
                return "Updated";
            }
        }
        public void Delete_ShowTime_By_IdRoom_And_Time(string _IdRoom, DateTime _Time)
        {
            ShowTime st = db.ShowTimes.Find(_IdRoom, _Time);
            db.ShowTimes.Remove(st);
            db.SaveChanges();
        }
        public void DeleteRange_ShowTime_By_IdRoom_And_Time(List<string> _IdRooms, List<DateTime> _Times)
        {

            for (int i = 0; i < _IdRooms.Count; i++)
            {
                Delete_ShowTime_By_IdRoom_And_Time(_IdRooms.ElementAt(i), _Times.ElementAt(i));
            }
        }
        //TicketOrder
        public List<TicketOrder> Get_TicketOrder_By_IdOrder(string _IdOrder)
        {
            List<TicketOrder> res = new List<TicketOrder>();
            if (_IdOrder == "All")
            {
                res = db.TicketOrders.ToList();
            }
            else
            {
                res = db.TicketOrders.Where(x => x.IdOrder == _IdOrder).ToList();
            }
            return res;
        }
        public TicketOrder Find_TicketOrder_By_IdTicketOrder(string _IdTicketOrder)
        {
            return db.TicketOrders.Find(_IdTicketOrder);
        }
        public bool CheckExist_TicketOrder_By_IdTicketOrder(string _IdTicketOrder)
        {
            return Find_TicketOrder_By_IdTicketOrder(_IdTicketOrder) != null;
        }
        public string AddUpdate_TicketOrder(TicketOrder tkod)
        {
            if (CheckExist_TicketOrder_By_IdTicketOrder(tkod.IdTicketOrder) != false)
            {
                db.TicketOrders.Add(tkod);
                db.SaveChanges();
                return "Added";
            }
            else
            {
                TicketOrder found = Find_TicketOrder_By_IdTicketOrder(tkod.IdTicketOrder);
                found.IdOrder = tkod.IdOrder;
                found.IdRoom = tkod.IdRoom;
                found.SeatPurchased = tkod.SeatPurchased;
                found.Time = tkod.Time;
                db.SaveChanges();
                return "Updated";
            }
        }
        public void Delete_TicketOrder_By_IdTicketOrder(string _IdTicketOrder)
        {
            TicketOrder tkod = db.TicketOrders.Find(_IdTicketOrder);
            db.TicketOrders.Remove(tkod);
            db.SaveChanges();
        }
        public void DeleteRange_TicketOrder_By_IdTicketOrder(List<string> _IdTicketOrders)
        {
            foreach (string id in _IdTicketOrders)
            {
                Delete_TicketOrder_By_IdTicketOrder(id);
            }
        }
        // PopcorndrinkOrder
        public List<PopcornDrinkOrder> Get_PopcornDrinkOrder_By_IdOrder(string _IdOrder)
        {
            List<PopcornDrinkOrder> res = new List<PopcornDrinkOrder>();
            if (_IdOrder == "All")
            {
                res = db.PopcornDrinkOrders.ToList();
            }
            else
            {
                res = db.PopcornDrinkOrders.Where(x => x.IdOrder == _IdOrder).ToList();
            }
            return res;
        }
        public List<PopcornDrinkOrder> GetAll_PopcornDrinkOrder()
        {
            return db.PopcornDrinkOrders.ToList();
        }
        public PopcornDrinkOrder Find_PopcornDrinkOrder_By_IdPopcornDrinkOrder(string _IdPopcornDrinkOrder)
        {
            return db.PopcornDrinkOrders.Find(_IdPopcornDrinkOrder);
        }
        public bool CheckExist_PopcornDrinkOrder_By_IdPopcornDrinkOrder(string _IdPopcornDrinkOrder)
        {
            return Find_PopcornDrinkOrder_By_IdPopcornDrinkOrder(_IdPopcornDrinkOrder) != null;
        }
        public string AddUpdate_PopcornDrinkOrder(PopcornDrinkOrder pdod)
        {
            if (CheckExist_PopcornDrinkOrder_By_IdPopcornDrinkOrder(pdod.IdPopcornDrinkOrder) != false)
            {
                db.PopcornDrinkOrders.Add(pdod);
                db.SaveChanges();
                return "Added";
            }
            else
            {
                PopcornDrinkOrder found = Find_PopcornDrinkOrder_By_IdPopcornDrinkOrder(pdod.IdPopcornDrinkOrder);
                found.IdOrder = pdod.IdOrder;
                found.NamePopcornDrink = pdod.NamePopcornDrink;
                found.PopcornDrinkPrice = pdod.PopcornDrinkPrice;
                found.Quantity = pdod.Quantity;
                db.SaveChanges();
                return "Updated";
            }
        }
        public void Delete_PopcornDrinkOrder_By_IdPopcornDrinkOrder(string _IdPopcornDrinkOrder)
        {
            PopcornDrinkOrder pdod = db.PopcornDrinkOrders.Find(_IdPopcornDrinkOrder);
            db.PopcornDrinkOrders.Remove(pdod);
            db.SaveChanges();
        }
        public void DeleteRange_PopcornDrinkOrder(List<string> _IdPopcornDrinkOrders)
        {
            foreach (string id in _IdPopcornDrinkOrders)
            {
                Delete_PopcornDrinkOrder_By_IdPopcornDrinkOrder(id);
            }
        }
        // Order
        public List<Order> Get_Order_By_IdCustomer(string _IdCustomer)
        {
            List<Order> res = new List<Order>();
            if (_IdCustomer == "All")
            {
                res = db.Orders.ToList();
            }
            else
            {
                res = db.Orders.Where(x => x.IdCustomer == _IdCustomer).ToList();
            }
            return res;
        }
        public Order Find_Order_By_IdOrder(string _IdOrder)
        {
            return db.Orders.Find(_IdOrder);
        }
        public bool CheckExist_Order_By_IdOrder(string _IdOrder)
        {
            return Find_Order_By_IdOrder(_IdOrder) != null;
        }
        public string AddUpdate_Order(Order od)
        {
            if (CheckExist_Order_By_IdOrder(od.IdOrder) != false)
            {
                db.Orders.Add(od);
                db.SaveChanges();
                return "Added";
            }
            else
            {
                Order found = Find_Order_By_IdOrder(od.IdOrder);
                found.IdCustomer = od.IdCustomer;
                found.TimeOrder = od.TimeOrder;
                found.Code = od.Code;
                db.SaveChanges();
                return "Updated";
            }
        }
        public void Delete_Order_By_IdOrder(string _IdOrder)
        {
            Order od = db.Orders.Find(_IdOrder);
            db.Orders.Remove(od);
            db.SaveChanges();
        }
        public void DeleteRange_Order(List<string> _IdOrders)
        {
            foreach (string id in _IdOrders)
            {
                Delete_Order_By_IdOrder(id);
            }
        }
        // CBBItem, Format
        public List<Format_ShowTime> List_ShowTime_To_List_Formart_ShowTime(List<ShowTime> stList)
        {
            List<Format_ShowTime> res = new List<Format_ShowTime>();

            foreach (ShowTime st in stList)
            {
                Format_ShowTime fmst = new Format_ShowTime();
                fmst.NameMovie = Find_Movie_By_IdMovie(st.IdMovie).NameMovie;
                fmst.NameRoom = Find_Room_By_IdRoom(st.IdRoom).NameRoom;
                fmst.SeatStatus = st.Seat;//View the map
                fmst.SeatView = fmst.Get_SeatView_From_SeatStatus(fmst.SeatStatus);//View the DGV
                fmst.SlotView = fmst.Get_SlotView_From_SeatStatus(fmst.SeatStatus);//View the DGV
                fmst.NumberSlots = fmst.Get_NumberSlots_From_SeatStatus(fmst.SeatStatus);//View the DGV
                fmst.TicketPrice = st.TicketPrice;
                fmst.Time = st.Time;
                res.Add(fmst);
            }
            return res;
        }
        public List<CBBItem2> Get_CBBMovie()
        {
            List<CBBItem2> res = new List<CBBItem2>();
            res.Add(new CBBItem2 { Value = "All", Text = "All" });
            foreach (Movie mv in db.Movies.ToList())
            {
                res.Add(new CBBItem2 { Value = mv.IdMovie, Text = mv.NameMovie });
            }
            return res;
        }
        public string CheckCode_Return_IdOrder(string _Code)
        {
            Order found = db.Orders.FirstOrDefault(x => x.Code == _Code);
            if (found != null)
            {
                found = db.Orders.Find(found.IdOrder);
                found.Code = String.Empty;
                db.SaveChanges();
                return found.IdOrder;
            }
            else
            {
                return "code not found";
            }
        }
        public List<CBBItem2> Get_CBBSort_Employee()
        {
            List<CBBItem2> res = new List<CBBItem2>();
            res.Add(new CBBItem2 { Value = "Name", Text = "Name" });
            res.Add(new CBBItem2 { Value = "Wage", Text = "Wage" });
            res.Add(new CBBItem2 { Value = "Shift", Text = "Shift" });
            return res;
        }
        public List<Employee> Sort_Employee(List<Employee> list, string sortby)
        {
            switch (sortby)
            {
                case "Name":
                    {
                        return list.OrderBy(p => p.NamePerson).ToList();
                    }
                case "Wage":
                    {
                        return list.OrderBy(p => p.Wage).ToList();
                    }
                case "Shift":
                    {
                        return list.OrderBy(p => p.Shift).ToList();
                    }
                default:
                    return list;
            }
        }
        public List<CBBItem2> Get_CBBSort_Format_ShowTime()
        {
            List<CBBItem2> res = new List<CBBItem2>();
            res.Add(new CBBItem2 { Value = "TicketPrice", Text = "TicketPrice" });
            res.Add(new CBBItem2 { Value = "Time", Text = "Time" });
            return res;
        }
        public List<Format_ShowTime> Sort_Format_ShowTime(List<Format_ShowTime> list, string sortby)
        {
            switch (sortby)
            {
                case "TicketPrice":
                    {
                        return list.OrderBy(p => p.TicketPrice).ToList();
                    }
                case "Time":
                    {
                        return list.OrderBy(p => p.Time).ToList();
                    }
                default:
                    return list;
            }
        }

    }
}
