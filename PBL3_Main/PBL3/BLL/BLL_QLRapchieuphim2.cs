using System;
using System.Collections.Generic;
using System.Linq;
using PBL3.DTO.DTO_Order;
using PBL3.DTO.DTO_Person;
using PBL3.DTO.DTO_PopcornDrink;
using PBL3.DTO.DTO_ShowTime;
using PBL3.DTO.DTO_View;
using PBL3.EntityFramework;

namespace PBL3.BLL
{
    public partial class BLL_QLRapchieuphim
    {
        //PopcornDrink :
        //no sort
        //no filter
        //search by Name
        //To make sure that we wont have 2 PopcornDrink with a same name in the DB, we let NamePopcornDrink is a key too (in AddUpdate func), so if we add new one which have a same name with another in DB, it will be update, not add
        public string GetNew_IdPopcornDrink() //pd****
        {
            string curMax = db.PopcornDrinks.OrderBy(x => x.IdPopcornDrink).ToList().ElementAt(db.PopcornDrinks.Count() - 1).IdPopcornDrink;
            string newMax = "";
            for (int i = 2; i < 6; i++)
            {
                newMax += curMax[i].ToString();
            }
            newMax = (Convert.ToInt32(newMax) + 1).ToString();
            while (newMax.Length < 4)
            {
                newMax = "0" + newMax;
            }
            return "pd" + newMax;
        }
        public List<PopcornDrink> Get_PopcornDrink_By_KeyWord(string _KeyWord = "")
        {
            if (_KeyWord == "")
            {
                return db.PopcornDrinks.ToList();
            }
            else
            {
                return db.PopcornDrinks.Where(x => x.NamePopcornDrink.Contains(_KeyWord)).ToList();
            }
        }
        public PopcornDrink Find_PopcornDrink_By_IdPopcornDrink(string _IdPopcornDrink)
        {
            return db.PopcornDrinks.Find(_IdPopcornDrink);
        }
        public PopcornDrink Get_PopcornDrink_By_IdPopcornDrink(string _IdPopcornDrink)
        {
            return db.PopcornDrinks.FirstOrDefault(x => x.IdPopcornDrink == _IdPopcornDrink);
        }
        public bool CheckExist_PopcornDrink_By_IdPopcornDrink(string _IdPopcornDrink)
        {
            return Get_PopcornDrink_By_IdPopcornDrink(_IdPopcornDrink) != null;
        }
        public PopcornDrink Get_PopcornDrink_By_NamePopcornDrink(string _NamePopcornDrink)
        {
            return db.PopcornDrinks.FirstOrDefault(x => x.NamePopcornDrink == _NamePopcornDrink);
        }
        public bool CheckExist_PopcornDrink_By_NamePopcornDrink(string _NamePopcornDrink)
        {
            return Get_PopcornDrink_By_NamePopcornDrink(_NamePopcornDrink) != null;
        }
        public string AddUpdate_PopcornDrink(PopcornDrink pd)
        {
            if (CheckExist_PopcornDrink_By_IdPopcornDrink(pd.IdPopcornDrink) == false)
            {
                if (CheckExist_PopcornDrink_By_NamePopcornDrink(pd.NamePopcornDrink) == false)
                {
                    pd.IdPopcornDrink = GetNew_IdPopcornDrink();
                    db.PopcornDrinks.Add(pd);
                    db.SaveChanges();
                    return "Added";
                }
                else
                {
                    return "Cant create a new PopcornDrink with an old NamePopcornDrink";
                }
            }
            else
            {
                if (CheckExist_PopcornDrink_By_NamePopcornDrink(pd.NamePopcornDrink) == false)
                {
                    PopcornDrink found = Find_PopcornDrink_By_IdPopcornDrink(pd.IdPopcornDrink);
                    found.NamePopcornDrink = pd.NamePopcornDrink;
                    found.PricePopcornDrink = pd.PricePopcornDrink;
                    db.SaveChanges();
                    return "Updated";
                }
                else
                {
                    return "Cant update PopcornDrink with an old NamePopcornDrink";
                }

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
        //Customer
        //no filter
        //no sort
        //search by Name, Address, Phone, Username
        //no add, update, delete
        public string GetNew_IdPerson_For_Customer()//customer******
        {
            string curMax = db.Customers.OrderBy(x => x.IdPerson).ToList().ElementAt(db.Customers.Count() - 1).IdPerson;
            string newMax = "";
            for (int i = 8; i < 14; i++)
            {
                newMax += curMax[i].ToString();
            }
            return "customer" + (Convert.ToInt32(newMax) + 1).ToString();
        }
        public List<Customer> Get_Customer_By_Keyword(string _Keyword = "") //Return List all employee if insert ""
        {
            if (_Keyword == "")
            {
                return db.Customers.ToList();
            }
            else
            {
                return db.Customers.Where(x => x.NamePerson.Contains(_Keyword)
                || x.Address.Contains(_Keyword)
                || x.Phone.Contains(_Keyword)
                || x.Username.Contains(_Keyword)).ToList();
            }
        }
        public Customer Find_Customer_By_IdCustomer(string _IdCustomer)
        {
            return db.Customers.Find(_IdCustomer);
        }
        public Customer Get_Customer_By_IdCustomer(string _IdCustomer)
        {
            return db.Customers.FirstOrDefault(x => x.IdPerson == _IdCustomer);
        }
        public bool CheckExist_Customer_By_IdCustomer(string _IdCustomer)
        {
            return Get_Customer_By_IdCustomer(_IdCustomer) != null;
        }
        public string AddUpdate_Customer(Customer ctm)
        {
            if (CheckExist_Customer_By_IdCustomer(ctm.IdPerson) == false)
            {
                ctm.IdPerson = GetNew_IdPerson_For_Customer();
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
        public List<Detail_Customer> List_Customer_To_List_Detail_Customer(List<Customer> list)
        {
            List<Detail_Customer> res = new List<Detail_Customer>();
            foreach (Customer c in list)
            {
                Detail_Customer detail = new Detail_Customer();
                detail.IdPerson = c.IdPerson;
                detail.NamePerson = c.NamePerson;
                detail.Phone = c.Phone;
                detail.Address = c.Address;
                detail.Vip = c.Vip;
                detail.Birth = c.Birth;
                detail.Gender = c.Gender;
                detail.Username = c.Username;
                res.Add(detail);
            }
            return res;
        }
        //Employee :
        //filter by shift
        //search by Name, Address, Phone, Username
        //sort by high wage to low, low wage to high
        public List<CBBItemS> Get_CBBSort_For_Employee()
        {
            List<CBBItemS> res = new List<CBBItemS>();
            res.Add(new CBBItemS { Text = "Wage: high to low", Value = "Wage: high to low" });
            res.Add(new CBBItemS { Text = "Wage: low to high", Value = "Wage: low to high" });
            return res;
        }
        public List<CBBItemS> Get_CBBFilter_By_Shift_For_Employee()
        {
            List<CBBItemS> res = new List<CBBItemS>();
            res.Add(new CBBItemS { Value = "0", Text = "All" });
            foreach (CBBItemS item in db.Employees.Select(e => new CBBItemS { Value = e.Shift.ToString(), Text = e.Shift.ToString() }).Distinct().ToList())
            {
                res.Add(item);
            }
            return res;
        }
        public List<Employee> Filter_Employee_By_Shift(List<Employee> list, int _Shift)
        {
            if (_Shift == 0)
            {
                return list;
            }
            else
            {
                return list.Where(x => x.Shift == _Shift).ToList();
            }
        }
        public List<Employee> Get_Employee_By_Keyword(string _Keyword = "") //Return List all employee if insert ""
        {
            if (_Keyword == "")
            {
                return db.Employees.ToList();
            }
            else
            {
                return db.Employees.Where(x => x.NamePerson.Contains(_Keyword)
                || x.Address.Contains(_Keyword)
                || x.Phone.Contains(_Keyword)
                || x.Username.Contains(_Keyword)).ToList();
            }
        }
        public Employee Get_Employee_By_IdPerson(string _IdPerson)
        {
            return db.Employees.FirstOrDefault(x => x.IdPerson == _IdPerson);
        }
        public Employee Find_Employee_By_IdPerson(string _IdPerson)
        {
            return db.Employees.Find(_IdPerson);
        }
        public bool CheckExist_Employee_By_IdPerson(string _IdPerson)
        {
            return Get_Employee_By_IdPerson(_IdPerson) != null;
        }
        public string GetNew_IdPerson_For_Employee()//employee******
        {
            string curMax = db.Employees.OrderBy(x => x.IdPerson).ToList().ElementAt(db.Employees.Count() - 1).IdPerson;
            string newMax = "";
            for (int i = 8; i < 14; i++)
            {
                newMax += (curMax[i].ToString());
            }
            newMax = (Convert.ToInt32(newMax) + 1).ToString();
            while (newMax.Length < 6)
            {
                newMax = "0" + newMax;
            }
            return "employee" + newMax;
        }
        public void Delete_Employee_By_IdPerson(string _IdPerson)
        {
            Employee eple = db.Employees.Find(_IdPerson);
            db.Employees.Remove(eple);
            db.SaveChanges();
        }
        public void DeleteRange_Employee(List<string> _IdPersons)
        {
            foreach (string id in _IdPersons)
            {
                Delete_Employee_By_IdPerson(id);
            }
        }
        public List<Detail_Employee> Sort_List_Detail_Employee(List<Detail_Employee> list, string _SortBy)
        {
            switch (_SortBy)
            {
                case "Wage: low to high":
                    return list.OrderBy(x => x.Wage).ToList();
                case "Wage: high to low":
                    return list.OrderByDescending(x => x.Wage).ToList();
                default:
                    return list;
            }
        }
        public List<Detail_Employee> List_Employee_To_List_Detail_Employee(List<Employee> list)
        {
            List<Detail_Employee> res = new List<Detail_Employee>();
            foreach (Employee emp in list)
            {
                res.Add(new Detail_Employee
                {
                    IdPerson = emp.IdPerson,
                    NamePerson = emp.NamePerson,
                    Address = emp.Address,
                    Phone = emp.Phone,
                    Shift = emp.Shift,
                    Wage = emp.Wage,
                    Gender = emp.Gender,
                    Birth = emp.Birth,
                    Username = emp.Username,
                });
            }
            return res;
        }
        //Movie :
        //search by NameMovie, Director, Actor, Category, Description
        //sort by Rate: high to low, Rate: low to high, ReleaseDate: old to new, ReleaseDate: new to old
        //no filter
        //no delete
        public List<CBBItemS> Get_CBBSort_For_Movie()
        {
            List<CBBItemS> res = new List<CBBItemS>();
            res.Add(new CBBItemS { Text = "Rate: high to low", Value = "Rate: high to low" });
            res.Add(new CBBItemS { Text = "Rate: low to high", Value = "Rate: low to high" });
            res.Add(new CBBItemS { Text = "ReleaseDate: old to new", Value = "ReleaseDate: old to new" });
            res.Add(new CBBItemS { Text = "ReleaseDate: new to old", Value = "ReleaseDate: new to old" });
            return res;
        }
        public List<Detail_Movie> Sort_List_Detail_Movie(List<Detail_Movie> list, string _SortBy)
        {
            switch (_SortBy)
            {
                case "Rate: high to low":
                    return list.OrderByDescending(x => x.Rate).ToList();
                case "Rate: low to high":
                    return list.OrderBy(x => x.Rate).ToList();
                case "ReleaseDate: old to new":
                    return list.OrderBy(x => x.ReleaseDate).ToList();
                case "ReleaseDate: new to old":
                    return list.OrderByDescending(x => x.ReleaseDate).ToList();
                default:
                    return list;
            }
        }
        public List<Movie> Get_Movie_By_Keyword(string _Keyword = "")
        {
            if (_Keyword == "")
            {
                return db.Movies.ToList();
            }
            else
            {
                return db.Movies.Where(x => x.NameMovie.Contains(_Keyword)
                        || x.Director.Contains(_Keyword)
                        || x.Actor.Contains(_Keyword)
                        || x.Category.Contains(_Keyword)
                        || x.Description.Contains(_Keyword)).ToList();
            }
        }
        public Movie Find_Movie_By_IdMovie(string _IdMovie)
        {
            return db.Movies.Find(_IdMovie);
        }
        public Movie Get_Movie_By_IdMovie(string _IdMovie)
        {
            return db.Movies.FirstOrDefault(x => x.IdMovie == _IdMovie);
        }
        public bool CheckExist_Movie_By_IdMovie(string _IdMovie)
        {
            return Get_Movie_By_IdMovie(_IdMovie) != null;
        }
        public string GetNew_IdMovie_For_Movie()//movie******
        {
            string curMax = db.Movies.OrderBy(x => x.IdMovie).ToList().ElementAt(db.Movies.Count() - 1).IdMovie;
            string newMax = "";
            for (int i = 5; i < 11; i++)
            {
                newMax += curMax[i].ToString();
            }
            newMax = (Convert.ToInt32(newMax) + 1).ToString();
            while (newMax.Length < 6)
            {
                newMax = "0" + newMax;
            }
            return "movie" + newMax;
        }
        public string AddUpdate_Movie(Movie mv)
        {
            if (CheckExist_Movie_By_IdMovie(mv.IdMovie) == false)
            {
                mv.IdMovie = GetNew_IdMovie_For_Movie();
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
        //public void Delete_Movie_By_IdMovie(string _IdMovie)
        //{
        //    Movie mv = db.Movies.Find(_IdMovie);
        //    db.Movies.Remove(mv);
        //    db.SaveChanges();
        //}
        //public void DeleteRange_Movie(List<string> _IdMoives)
        //{
        //    foreach (string id in _IdMoives)
        //    {
        //        Delete_Movie_By_IdMovie(id);
        //    }
        //}
        public List<Detail_Movie> List_Movie_To_List_Detail_Movie(List<Movie> list)
        {
            List<Detail_Movie> res = new List<Detail_Movie>();
            foreach (Movie mv in list)
            {
                res.Add(new Detail_Movie
                {
                    IdMovie = mv.IdMovie,
                    NameMovie = mv.NameMovie,
                    Description = mv.Description,
                    Director = mv.Director,
                    Actor = mv.Actor,
                    Duration = mv.Duration,
                    Category = mv.Category,
                    ReleaseDate = mv.ReleaseDate,
                    Rate = mv.Rate,
                });
            }
            return res;
        }
        //Room
        //no search
        //no filter
        //no sort
        //To make sure that we wont have 2 Room with a same name in the DB, we let NameRoom is a key too (in AddUpdate func), so if we add new one which have a same name with another in DB, it will be update, not add
        public List<Room> GetAll_Room()
        {
            return db.Rooms.ToList();
        }
        public Room Find_Room_By_IdRoom(string _IdRoom)
        {
            return db.Rooms.Find(_IdRoom);
        }
        public Room Get_Room_By_IdRoom(string _IdRoom)
        {
            return db.Rooms.FirstOrDefault(x => x.IdRoom == _IdRoom);
        }
        public bool CheckExist_Room_By_IdRoom(string _IdRoom)
        {
            return Get_Room_By_IdRoom(_IdRoom) != null;
        }
        public Room Get_Room_By_NameRoom(string _NameRoom)
        {
            return db.Rooms.FirstOrDefault(x => x.NameRoom == _NameRoom);
        }
        public bool CheckExist_Room_By_NameRoom(string _NameRoom)
        {
            return Get_Room_By_NameRoom(_NameRoom) != null;
        }
        public string GetNew_IdRoom_For_Room()//room**
        {
            string curMax = db.Rooms.OrderBy(x => x.IdRoom).ToList().ElementAt(db.Rooms.Count() - 1).IdRoom;
            string newMax = "";
            for (int i = 4; i < 6; i++)
            {
                newMax += curMax[i].ToString();
            }
            newMax = (Convert.ToInt32(newMax) + 1).ToString();
            while (newMax.Length < 2)
            {
                newMax = "0" + newMax;
            }
            return "room" + newMax;
        }
        public string AddUpdate_Room(Room r)
        {
            if (CheckExist_Room_By_IdRoom(r.IdRoom) == false)
            {
                if (CheckExist_Room_By_NameRoom(r.NameRoom) == false)
                {
                    r.IdRoom = GetNew_IdRoom_For_Room();
                    db.Rooms.Add(r);
                    db.SaveChanges();
                    return "Added";
                }
                else
                {
                    return "Cant create a new Room with an old NameRoom";
                }
            }
            else
            {
                if (CheckExist_Room_By_NameRoom(r.NameRoom) == false)
                {
                    Room found = Find_Room_By_IdRoom(r.IdRoom);
                    found.NameRoom = r.NameRoom;
                    found.NumberSeats = r.NumberSeats;
                    db.SaveChanges();
                    return "Updated";
                }
                else
                {
                    return "Cant update Room with an old NameRoom";
                }

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
        public List<Detail_Room> List_Room_To_List_Detail_Room(List<Room> list)
        {
            List<Detail_Room> res = new List<Detail_Room>();
            foreach (Room r in list)
            {
                res.Add(new Detail_Room
                {
                    IdRoom = r.IdRoom,
                    NameRoom = r.NameRoom,
                    NumberSeats = r.NumberSeats,
                });
            }
            return res;
        }
        //ShowTime
        //no delete
        //Check out the AddUpdate func and Delete funcs carefully
        //no search
        //filter by Movie and Before/After1HourAgo at the same time
        //sort by Time to show: old to new, Time to show: new to old
        public List<CBBItemS> Get_CBBNameRoom()
        {
            List<CBBItemS> res = new List<CBBItemS>();
            foreach (Room r in GetAll_Room())
            {
                res.Add(new CBBItemS { Text = r.NameRoom, Value = r.IdRoom });
            }
            return res;
        }
        public List<CBBItemS> Get_CBBSort_For_ShowTime()
        {
            List<CBBItemS> res = new List<CBBItemS>();
            res.Add(new CBBItemS { Text = "Time to show: old to new", Value = "Time to show: old to new" });
            res.Add(new CBBItemS { Text = "Time to show: new to old", Value = "Time to show: new to old" });
            return res;
        }
        public List<CBBItemS> Get_CBBFilter_By_Movie_For_ShowTime()//From new to old
        {
            List<CBBItemS> res = new List<CBBItemS>();
            res.Add(new CBBItemS { Value = "All", Text = "All" });
            foreach (Movie mv in db.Movies.OrderByDescending(x => x.ReleaseDate).ToList())
            {
                res.Add(new CBBItemS { Value = mv.IdMovie, Text = mv.NameMovie });
            }
            return res;
        }
        public List<CBBItemS> Get_CBBFilter_By_1HourAgo_For_ShowTime()
        {
            List<CBBItemS> res = new List<CBBItemS>();
            res.Add(new CBBItemS { Value = "After1HourAgo", Text = "After1HourAgo" });
            res.Add(new CBBItemS { Value = "Before1HourAgo", Text = "Before1HourAgo" });
            return res;
        }
        public List<ShowTime> Filter_By1HourAgo_And_IdMovie(string _CBBCanBuyText, string _IdMovie)
        {
            switch (_CBBCanBuyText)
            {
                case "After1HourAgo":
                    return Get_ShowTime_After1HourAgo_With_IdMovie(_IdMovie);
                case "Before1HourAgo":
                    return Get_ShowTimes_Before1HourAgo_With_IdMovie(_IdMovie);
                default:
                    return null;
            }
        }
        public bool Check_Late_Or_Shown(ShowTime st)
        {
            DateTime AHAG = DateTime.Now.AddHours(-1);
            return st.Time.CompareTo(AHAG) < 0;
        }
        public bool Check_Anyone_Ordered(ShowTime st)
        {
            //in the case st is a new ShowTime, we initilize its Seat = "temp", it still can pass this Check func at it should be, no need a full0 string
            string _SeatStatus = st.Seat;
            bool Full0 = false;
            foreach (char c in _SeatStatus)
            {
                if (c == '1')
                {
                    Full0 = true;
                    break;
                }
            }
            return Full0;
        }
        public List<ShowTime> Get_ShowTimes_Before1HourAgo_With_IdMovie(string _ValueCBBFilterByMovie)//Cannot buy
        {
            List<ShowTime> stList = new List<ShowTime>();
            DateTime AHAG = DateTime.Now.AddHours(-1);
            if (_ValueCBBFilterByMovie == "All")
            {
                stList = db.ShowTimes.Where(x => x.Time.CompareTo(AHAG) < 0).ToList();
            }
            else
            {
                stList = db.ShowTimes.Where(x => x.Time.CompareTo(AHAG) < 0 && x.IdMovie == _ValueCBBFilterByMovie).ToList();
            }
            return stList;
        }
        public List<ShowTime> Get_ShowTime_After1HourAgo_With_IdMovie(string _ValueCBBFilterByMovie)//Can buy
        {
            List<ShowTime> stList = new List<ShowTime>();
            DateTime AHAG = DateTime.Now.AddHours(-1);
            if (_ValueCBBFilterByMovie == "All")
            {
                stList = db.ShowTimes.Where(x => x.Time.CompareTo(AHAG) > 0).ToList();
            }
            else
            {
                stList = db.ShowTimes.Where(x => x.Time.CompareTo(AHAG) > 0 && x.IdMovie == _ValueCBBFilterByMovie).ToList();
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
        public ShowTime Get_ShowTime_By_IdRoom_And_Time(string _IdRoom, DateTime _Time)
        {
            return db.ShowTimes.FirstOrDefault(x => x.IdRoom == _IdRoom && x.Time == _Time);
        }
        public bool CheckExist_ShowTime_By_IdRoom_And_Time(ShowTime check)
        {
            bool NoConflict = true;
            DateTime StartCheck = check.Time;
            DateTime EndCheck = check.Time.Add(Get_Movie_By_IdMovie(check.IdMovie).Duration);
            foreach (ShowTime item in GetAll_ShowTime())
            {
                DateTime StartItem = item.Time;
                DateTime EndItem = item.Time.Add(Get_Movie_By_IdMovie(check.IdMovie).Duration);
                if (EndCheck.CompareTo(StartItem.AddMinutes(-10)) > 0
                    || StartCheck.CompareTo(EndItem.AddMinutes(10)) < 0)
                {
                    NoConflict = false;
                }
            }
            return !NoConflict;
        }

        public string GetNewBlank_SeatStatus(string _IdRoom)
        {
            if (CheckExist_Room_By_IdRoom(_IdRoom) == true)
            {
                int _NumberSeats = Get_Room_By_IdRoom(_IdRoom).NumberSeats;
                string res = "";
                for (int i = 0; i < _NumberSeats; i++)
                {
                    res += "0";
                }
                return res;
            }
            else
            {
                return "Error: room not found";
            }
        }
        public string AddUpdate_ShowTime(ShowTime st)
        {
            if (Check_Late_Or_Shown(st) == true || Check_Anyone_Ordered(st) == true)
            {
                return "Cannot add or update this ShowTime\nThis ShowTime has at least an ordered seat or an UnBuyAble Time value";
            }
            else
            {
                if (st.Seat == "temp")//want to add
                {
                    if (CheckExist_ShowTime_By_IdRoom_And_Time(st) == false)
                    {
                        if (GetNewBlank_SeatStatus(st.IdRoom) == "Error: room not found") //just for sure, almost cant happen
                        {
                            return "Error: room not found";
                        }
                        else
                        {
                            st.Seat = GetNewBlank_SeatStatus(st.IdRoom);
                            db.ShowTimes.Add(st);
                            db.SaveChanges();
                            return "Added";
                        }
                    }
                    else
                    {
                        return "Cannot add this ShowTime\nThere is already a ShowTime located with input Time and Room";
                    }
                }
                else//want to update
                {
                    if (CheckExist_ShowTime_By_IdRoom_And_Time(st) == false)
                    {
                        if (GetNewBlank_SeatStatus(st.IdRoom) == "Error: room not found") //just for sure, almost cant happen
                        {
                            return "Error: room not found";
                        }
                        else
                        {
                            ShowTime found = Find_ShowTime_By_IdRoom_And_Time(st.IdRoom, st.Time);
                            found.IdMovie = st.IdMovie;
                            found.TicketPrice = st.TicketPrice;
                            db.SaveChanges();
                            return "Updated";
                        }
                    }
                    else
                    {
                        return "Cannot update this ShowTime\nThere is already a ShowTime located with input Time and Room";
                    }
                }
            }
        }
        //public void Delete_ShowTime_By_IdRoom_And_Time(string _IdRoom, DateTime _Time)
        //{
        //    ShowTime st = db.ShowTimes.Find(_IdRoom, _Time);
        //    db.ShowTimes.Remove(st);
        //    db.SaveChanges();
        //}
        //public string DeleteRange_ShowTime_By_IdRoom_And_Time(List<string> _IdRooms, List<DateTime> _Times)
        //{
        //    bool suitable = true;
        //    for (int i = 0; i < _IdRooms.Count; i++)
        //    {
        //        ShowTime st = Get_ShowTime_By_IdRoom_And_Time(_IdRooms.ElementAt(i), _Times.ElementAt(i));
        //        if (Check_Late_Or_Shown(st) == true || Check_Anyone_Ordered(st) == true)
        //        {
        //            suitable = false;
        //            break;
        //        }
        //    }
        //    if (suitable == true)
        //    {
        //        for (int i = 0; i < _IdRooms.Count; i++)
        //        {
        //            Delete_ShowTime_By_IdRoom_And_Time(_IdRooms.ElementAt(i), _Times.ElementAt(i));
        //        }
        //        return "Delete succeed";
        //    }
        //    else
        //    {
        //        return "Delete failed";
        //    }
        //}
        public List<Detail_ShowTime> Sort_List_Detail_ShowTime(List<Detail_ShowTime> list, string _SortBy)
        {
            switch (_SortBy)
            {
                case "Time to show: new to old":
                    return list.OrderByDescending(x => x.Time).ToList();
                case "Time to show: old to new":
                    return list.OrderBy(x => x.Time).ToList();
                default:
                    return list;
            }
        }
        public List<Detail_ShowTime> List_ShowTime_To_List_Detail_ShowTime(List<ShowTime> stList)
        {
            List<Detail_ShowTime> res = new List<Detail_ShowTime>();
            foreach (ShowTime st in stList)
            {
                if (Get_Movie_By_IdMovie(st.IdMovie) != null && Get_Room_By_IdRoom(st.IdRoom) != null)
                {
                    Detail_ShowTime detail = new Detail_ShowTime();
                    detail.NameMovie = Get_Movie_By_IdMovie(st.IdMovie).NameMovie;
                    detail.NameRoom = Get_Room_By_IdRoom(st.IdRoom).NameRoom;
                    detail.SeatView = detail.Get_SeatView_From_SeatStatus(st.Seat);//View the DGV
                    detail.SlotView = detail.Get_SlotView_From_SeatStatus(st.Seat);//View the DGV
                    detail.NumberSlots = detail.Get_NumberSlots_From_SeatStatus(st.Seat);//View the DGV
                    detail.TicketPrice = st.TicketPrice;
                    detail.Time = st.Time;
                    res.Add(detail);
                }
            }
            return res;
        }
        //TicketOrder
        public List<TicketOrder> Get_List_TicketOrder_By_IdOrder(string _IdOrder)
        {
            //List<TicketOrder> res = new List<TicketOrder>();
            //if (_IdOrder == "All")
            //{
            //    res = db.TicketOrders.ToList();
            //}
            //else
            //{
            //    res = db.TicketOrders.Where(x => x.IdOrder == _IdOrder).ToList();
            //}
            //return res;
            if (_IdOrder != null)
            {
                return db.TicketOrders.Where(x => x.IdOrder == _IdOrder).ToList();
            }
            else
            {
                return null;
            }
        }
        public List<Detail_TicketOrder> List_TicketOrder_To_List_Detail_TicketOrder(List<TicketOrder> list)
        {
            if (list != null)
            {
                List<Detail_TicketOrder> res = new List<Detail_TicketOrder>();
                foreach (TicketOrder item in list)
                {
                    Detail_TicketOrder detail = new Detail_TicketOrder();
                    detail.IdOrder = item.IdOrder;
                    detail.NameRoom = Get_Room_By_IdRoom(item.IdRoom).NameRoom;
                    detail.Time = item.Time;
                    detail.SeatPurchased = item.SeatPurchased;
                    res.Add(detail);
                }
                return res;
            }
            else
            {
                return null;
            }

        }
        public List<TicketOrder> GetAll_TicketOrder()
        {
            return db.TicketOrders.ToList();
        }
        public TicketOrder Find_TicketOrder_By_IdTicketOrder(string _IdTicketOrder)
        {
            return db.TicketOrders.Find(_IdTicketOrder);
        }
        public TicketOrder Get_TicketOrder_By_IdTicketOrder(string _IdTicketOrder)
        {
            return db.TicketOrders.FirstOrDefault(x => x.IdTicketOrder == _IdTicketOrder);
        }
        public bool CheckExist_TicketOrder_By_IdTicketOrder(string _IdTicketOrder)
        {
            return Get_TicketOrder_By_IdTicketOrder(_IdTicketOrder) != null;
        }
        // PopcorndrinkOrder
        public List<PopcornDrinkOrder> Get_List_PopcornDrinkOrder_By_IdOrder(string _IdOrder)
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
        public List<Detail_PopcornDrinkOrder> List_PopcornDrinkOrder_To_List_Detail_PopcornDrinkOrder(List<PopcornDrinkOrder> list)
        {
            if (list != null)
            {
                List<Detail_PopcornDrinkOrder> res = new List<Detail_PopcornDrinkOrder>();
                foreach (PopcornDrinkOrder item in list)
                {
                    Detail_PopcornDrinkOrder detail = new Detail_PopcornDrinkOrder();
                    detail.IdOrder = item.IdOrder;
                    detail.NamePopcornDrink = item.NamePopcornDrink;
                    detail.Quantity = item.Quantity;
                    detail.PopcornDrinkPrice = item.PopcornDrinkPrice;
                    res.Add(detail);
                }
                return res;
            }
            else
            {
                return null;
            }

        }
        public PopcornDrinkOrder Find_PopcornDrinkOrder_By_IdPopcornDrinkOrder(string _IdPopcornDrinkOrder)
        {
            return db.PopcornDrinkOrders.Find(_IdPopcornDrinkOrder);
        }
        public PopcornDrinkOrder Get_PopcornDrinkOrder_By_IdPopcornDrinkOrder(string _IdPopcornDrinkOrder)
        {
            return db.PopcornDrinkOrders.FirstOrDefault(x => x.IdPopcornDrinkOrder == _IdPopcornDrinkOrder);
        }
        public bool CheckExist_PopcornDrinkOrder_By_IdPopcornDrinkOrder(string _IdPopcornDrinkOrder)
        {
            return Get_PopcornDrinkOrder_By_IdPopcornDrinkOrder(_IdPopcornDrinkOrder) != null;
        }
        // Order and statistic
        //no search
        //no sort
        //filter by datetimepicker
        public int Calculate_TotalCost(Order o)
        {
            int totalCost = 0;
            foreach (TicketOrder to in Get_List_TicketOrder_By_IdOrder(o.IdOrder))
            {
                totalCost += Get_ShowTime_By_IdRoom_And_Time(to.IdRoom, to.Time).TicketPrice;
            }
            foreach (PopcornDrinkOrder pdo in Get_List_PopcornDrinkOrder_By_IdOrder(o.IdOrder))
            {
                totalCost += pdo.Quantity * pdo.PopcornDrinkPrice;
            }
            return totalCost;
        }
        public List<Order> Get_Order_By_IdCustomer(string _IdCustomer)
        {
            if (_IdCustomer == "All")
            {
                return db.Orders.ToList();
            }
            else
            {
                return db.Orders.Where(x => x.IdCustomer == _IdCustomer).ToList();
            }
        }
        public List<Order> Get_Order_By_Date(DateTime date)
        {
            List<Order> res = new List<Order>();
            DateTime start = new DateTime(date.Year, date.Month, date.Day, 0, 0, 0);
            DateTime end = new DateTime(date.Year, date.Month, date.Day, 23, 59, 59);
            foreach (Order o in db.Orders.ToList())
            {
                if (o.TimeOrder.CompareTo(start) > 0 && o.TimeOrder.CompareTo(end) < 0)
                {
                    res.Add(o);
                }
            }
            return res;
        }
        public List<Detail_Order> List_Order_To_List_Detail_Order(List<Order> list)
        {
            if (list != null)
            {
                List<Detail_Order> res = new List<Detail_Order>();
                foreach (Order item in list)
                {
                    Detail_Order detail = new Detail_Order();
                    detail.IdOrder = item.IdOrder;
                    detail.IdPerson = item.IdCustomer;
                    detail.TimeOrder = item.TimeOrder;
                    detail.TotalCost = Calculate_TotalCost(item);

                    res.Add(detail);
                }
                return res;
            }
            else
            {
                return null;
            }

        }

        //private string Get_Order_Include(string _IdOrder)
        //{
        //    List<Detail_TicketOrder> tkList = List_TicketOrder_To_List_Detail_TicketOrder(Get_List_TicketOrder_By_IdOrder(_IdOrder)).OrderBy(x => x.NameRoom).OrderBy(x => x.Time).ToList();
        //    if (tkList.Count > 0)
        //    {
        //        bool change = false;
        //        string allSeat = ""
        //        string curNameRoom = tkList.ElementAt(0).NameRoom;
        //        DateTime curTime = tkList.ElementAt(0).Time;
        //        string curSeat = "";
        //        foreach (Detail_TicketOrder item in tkList)
        //        {
        //            if (item.NameRoom == curNameRoom && item.Time == curTime)
        //            {
        //                curSeat += item.SeatPurchased + " ";
        //            }
        //            else
        //            {
        //                curSeat = curNameRoom + "|" + curTime.ToString() + "|" + curSeat;
        //                allSeat = curSeat + "\n";
        //                curSeat = "";
        //                curNameRoom = item.NameRoom;
        //                curTime = item.Time;
        //            }
        //        }
        //    }

        //    List<Detail_PopcornDrinkOrder>
        //}

        public Order Find_Order_By_IdOrder(string _IdOrder)
        {
            return db.Orders.Find(_IdOrder);
        }
        public Order Get_Order_By_IdOrder(string _IdOrder)
        {
            return db.Orders.FirstOrDefault(x => x.IdOrder == _IdOrder);
        }
        public bool CheckExist_Order_By_IdOrder(string _IdOrder)
        {
            return Get_Order_By_IdOrder(_IdOrder) != null;
        }
        public string AddUpdate_Employee(Employee eple)
        {
            if (CheckExist_Employee_By_IdPerson(eple.IdPerson) == false)
            {
                eple.IdPerson = GetNew_IdPerson_For_Employee();
                db.Employees.Add(eple);
                db.SaveChanges();
                return "Added";
            }
            else
            {
                Employee found = Find_Employee_By_IdPerson(eple.IdPerson);
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
        public List<PopcornDrinkOrder> GetAll_PopcornDrinkOrder()
        {
            return db.PopcornDrinkOrders.ToList();
        }
        public List<ShowTime> Get_ShowTimes_By_IdMovie(string _IdMovie)
        {
            return db.ShowTimes.Where(x => x.IdMovie == _IdMovie).ToList();
        }
        public int Cal_Earnings_From_Movie(Movie mv)
        {
            int total = 0;
            List<ShowTime> stL = Get_ShowTimes_By_IdMovie(mv.IdMovie);
            foreach (ShowTime st in stL)
            {
                List<TicketOrder> tkL = db.TicketOrders.Where(x => x.IdRoom == st.IdRoom && x.Time.Equals(st.Time)).ToList();
                total += st.TicketPrice * tkL.Count;
            }
            return total;
        }
        public Movie Get_Top1_Trending_Movie()
        {
            Movie res = db.Movies.FirstOrDefault();
            int max = 0;
            foreach (Movie mv in db.Movies.ToList())
            {
                int cal = Cal_Earnings_From_Movie(mv);
                if (max < cal)
                {
                    max = cal;
                    res = mv;
                }
            }
            return res;
        }

    }
}
//Admin
//public List<Admin> GetAll_Admin()
//{
//    return db.Admins.ToList();
//}
//public Admin Find_Admin_By_IdAdmin(string _IdAdmin)
//{
//    return db.Admins.Find(_IdAdmin);
//}
//public bool CheckExist_Admin_By_IdAdmin(string _IdAdmin)
//{
//    return Find_Admin_By_IdAdmin(_IdAdmin) != null;
//}
//public string AddUpdate_Admin(Admin am)
//{
//    if (CheckExist_Admin_By_IdAdmin(am.IdPerson) != false)
//    {
//        db.Admins.Add(am);
//        db.SaveChanges();
//        return "Added";
//    }
//    else
//    {
//        Admin found = Find_Admin_By_IdAdmin(am.IdPerson);
//        found.NamePerson = am.NamePerson;
//        found.Address = am.Address;
//        found.Phone = am.Phone;
//        found.Birth = am.Birth;
//        found.Gender = am.Gender;
//        found.Username = am.Username;
//        found.Password = am.Password;
//        db.SaveChanges();
//        return "Updated";
//    }
//}
//public void Delete_Admin_By_IdAdmin(string _IdAdmin)
//{
//    Admin am = db.Admins.Find(_IdAdmin);
//    db.Admins.Remove(am);
//    db.SaveChanges();
//}
//public void DeleteRange_Admin(List<string> _IdAdmins)
//{
//    foreach (string id in _IdAdmins)
//    {
//        Delete_Admin_By_IdAdmin(id);
//    }
//}

