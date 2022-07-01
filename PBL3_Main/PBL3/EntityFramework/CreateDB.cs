using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL3.EntityFramework;
using PBL3.DTO.DTO_Order;
using PBL3.DTO.DTO_Person;
using PBL3.DTO.DTO_PopcornDrink;
using PBL3.DTO.DTO_ShowTime;

namespace PBL3.EntityFramework
{
    public class CreateDB : DropCreateDatabaseAlways<QLRapChieuPhim>
    {
        protected override void Seed(QLRapChieuPhim context)
        {
            context.Admins.AddRange(new[]
            {
                new Admin{IdPerson = "admin01", NamePerson = "Tran Nhat Minh", Phone = "0123123", Address = "38 Do Anh Han", Gender = true, Birth = new DateTime(1999, 12, 25), Username = "admin1", Password = "admin1"},
                new Admin{IdPerson = "admin02", NamePerson = "Le Tien Dat", Phone = "0123123", Address = "", Gender = true, Birth = new DateTime(1999, 12, 25), Username = "admin2", Password = "admin2"},
                new Admin{IdPerson = "admin03", NamePerson = "Tran Dinh Gia Khiem", Phone = "0123123", Address = "", Gender = true, Birth = new DateTime(1999, 12, 25), Username = "admin3", Password = "admin3"}
            });
            context.Customers.AddRange(new[]
            {
                new Customer{ IdPerson = "customer000001", NamePerson = "NVA", Phone = "0123123", Address = "38 Do Anh Han", Gender = true, Birth = new DateTime(1999, 12, 25), Username = "usernameKH1", Password = "passwordKH1", Vip = false},
                new Customer{ IdPerson = "customer000002", NamePerson = "NVB", Phone = "0123124", Address = "12 Truong Chinh", Gender = true, Birth = new DateTime(1960, 10, 26), Username = "usernameKH2", Password = "passwordKH2", Vip = true},
                new Customer{ IdPerson = "customer000003", NamePerson = "NVC", Phone = "0123125", Address = "50 Tran Duy Hung", Gender = true, Birth = new DateTime(2002, 2, 1), Username = "usernameKH3", Password = "passwordKH3", Vip = false},
                new Customer{ IdPerson = "customer000004", NamePerson = "NVD", Phone = "0123126", Address = "38 Nguyen Tat Thanh", Gender = false, Birth = new DateTime(1962, 12, 25), Username = "usernameKH4", Password = "passwordKH4", Vip = true},
                new Customer{ IdPerson = "customer000005", NamePerson = "NVE", Phone = "0123127", Address = "21 Pham Ngu Lao", Gender = false, Birth = new DateTime(2000, 12, 15), Username = "usernameKH5", Password = "passwordKH5", Vip = true},
                new Customer{ IdPerson = "customer000006", NamePerson = "NVF", Phone = "0123128", Address = "Nha Trang", Gender = true, Birth = new DateTime(1973, 12, 25), Username = "usernameKH6", Password = "passwordKH6", Vip = false},
            });
            context.Employees.AddRange(new[]
            {

                new Employee{ IdPerson = "employee000001", NamePerson = "NVA", Phone = "0123123", Address = "38 Do Anh Han", Gender = true, Birth = new DateTime(1999, 12, 25), Username = "usernameNV1", Password = "passwordNV1", Shift = 1, Wage = 5000000},
                new Employee{ IdPerson = "employee000002", NamePerson = "NVB", Phone = "0123124", Address = "12 Truong Chinh", Gender = true, Birth = new DateTime(1960, 10, 26), Username = "usernameNV2", Password = "passwordNV2", Shift = 1, Wage = 5000000},
                new Employee{ IdPerson = "employee000003", NamePerson = "NVC", Phone = "0123125", Address = "50 Tran Duy Hung", Gender = true, Birth = new DateTime(2002, 2, 1), Username = "usernameNV3", Password = "passwordNV3",  Shift = 1, Wage = 5000000},
                new Employee{ IdPerson = "employee000004", NamePerson = "NVD", Phone = "0123126", Address = "38 Nguyen Tat Thanh", Gender = false, Birth = new DateTime(1962, 12, 25), Username = "usernameNV4", Password = "passwordNV4",  Shift = 1, Wage = 5000000},
                new Employee{ IdPerson = "employee000005", NamePerson = "NVE", Phone = "0123127", Address = "21 Pham Ngu Lao", Gender = false, Birth = new DateTime(2000, 12, 15), Username = "usernameNV5", Password = "passwordNV5",  Shift = 2, Wage = 6000000},
                new Employee{ IdPerson = "employee000006", NamePerson = "NVF", Phone = "0123128", Address = "Nha Trang", Gender = true, Birth = new DateTime(1973, 12, 25), Username = "usernameNV6", Password = "passwordNV6", Shift = 2, Wage = 6000000},
            });
            context.Orders.AddRange(new[]
            {
                new Order{IdOrder = "order00000001", IdCustomer = "customer000001", TimeOrder = new DateTime(2015, 12, 25), Code = "sadad"},
                new Order{IdOrder = "order00000002", IdCustomer = "customer000002", TimeOrder = new DateTime(2015, 12, 25), Code = "sadafsq"},
                new Order{IdOrder = "order00000003", IdCustomer = "customer000003", TimeOrder = new DateTime(2015, 12, 25), Code = ""},
                new Order{IdOrder = "order00000004", IdCustomer = "customer000004", TimeOrder = new DateTime(2015, 12, 25), Code = ""},
                new Order{IdOrder = "order00000005", IdCustomer = "customer000005", TimeOrder = new DateTime(2015, 12, 25), Code = "werwet"},
            });
            context.PopcornDrinkOrders.AddRange(new[]
            {
                new PopcornDrinkOrder{IdPopcornDrinkOrder = "pdorder00000001", IdOrder = "order00000001", NamePopcornDrink = "Bap size S", PopcornDrinkPrice = 10000, Quantity = 2},
                new PopcornDrinkOrder{IdPopcornDrinkOrder = "pdorder00000002", IdOrder = "order00000001", NamePopcornDrink = "Pepsi size L", PopcornDrinkPrice = 20000, Quantity = 1},
                new PopcornDrinkOrder{IdPopcornDrinkOrder = "pdorder00000003", IdOrder = "order00000002", NamePopcornDrink = "Bap size L", PopcornDrinkPrice = 20000, Quantity = 2},
                new PopcornDrinkOrder{IdPopcornDrinkOrder = "pdorder00000004", IdOrder = "order00000002", NamePopcornDrink = "Pepsi size M", PopcornDrinkPrice = 18000, Quantity = 1},
                new PopcornDrinkOrder{IdPopcornDrinkOrder = "pdorder00000005", IdOrder = "order00000003", NamePopcornDrink = "Bap size S", PopcornDrinkPrice = 10000, Quantity = 2},
            });
            context.TicketOrders.AddRange(new[]
            {
                new TicketOrder{IdTicketOrder = "ticketorder00000001", IdOrder = "order00000001", IdRoom = "room01",Time = new DateTime(2022,7,1),SeatPurchased = "A1"},
                new TicketOrder{IdTicketOrder = "ticketorder00000002", IdOrder = "order00000002", IdRoom = "room02",Time = new DateTime(2022,7,1),SeatPurchased = "A1"},
                new TicketOrder{IdTicketOrder = "ticketorder00000003", IdOrder = "order00000003", IdRoom = "room03",Time = new DateTime(2022,7,1),SeatPurchased = "A1"},
                new TicketOrder{IdTicketOrder = "ticketorder00000004", IdOrder = "order00000004", IdRoom = "room04",Time = new DateTime(2022,7,1),SeatPurchased = "A1"},
                new TicketOrder{IdTicketOrder = "ticketorder00000005", IdOrder = "order00000005", IdRoom = "room05",Time = new DateTime(2022,7,1),SeatPurchased = "A1"},
            });
            context.ShowTimes.AddRange(new[]
            {
                new ShowTime{IdMovie = "movie000001", IdRoom = "room01", Seat = "10000000000000000000000000000000000000000000000000", Time = new DateTime(2022,7,1), TicketPrice = 50000},
                new ShowTime{IdMovie = "movie000002", IdRoom = "room02", Seat = "011000000000000000000000000000000000000011111", Time = new DateTime(2022,7,1), TicketPrice = 50000},
                new ShowTime{IdMovie = "movie000003", IdRoom = "room03", Seat = "00011100000000000000000000000000000000000000000000", Time = new DateTime(2022,7,1), TicketPrice = 50000},
                new ShowTime{IdMovie = "movie000004", IdRoom = "room04", Seat = "00000011110000000000000000000000000000000000000000", Time = new DateTime(2022,7,1), TicketPrice = 50000},
                new ShowTime{IdMovie = "movie000005", IdRoom = "room05", Seat = "00000000001111100000000000000000000000000000000000", Time = new DateTime(2022,7,1), TicketPrice = 50000},
            });
            context.Movies.AddRange(new[]
            {
                new Movie{IdMovie = "movie000001",NameMovie = "Sát Thủ Nhân Tạo 2: Mẫu Vật Còn Lại", Actor = "NVA1, NVA2, NVA3,...", Director = "NVD1", Description = "Noi dung phim 1", Category = "The loai 1, The loai 2", Duration = new TimeSpan(2, 30, 20), Rate = 5.0, ReleaseDate = new DateTime(2022,3,16), LinkTrailer = ""},
                new Movie{IdMovie = "movie000002",NameMovie = "Em và Trịnh", Actor = "NVA1, NVA2, NVA4,...", Director = "NVD2", Description = "Noi dung phim 2", Category = "The loai 4, The loai 2", Duration = new TimeSpan(3, 30, 20), Rate = 5.0, ReleaseDate = new DateTime(2022,3,16), LinkTrailer = ""},
                new Movie{IdMovie = "movie000003",NameMovie = "Điện Thoại Đen",Actor = "NVA1, NVA3, NVA5,...", Director = "NVD3", Description = "Noi dung phim 3", Category = "The loai 5", Duration = new TimeSpan(2, 10, 20), Rate = 5.0, ReleaseDate = new DateTime(2022,3,16), LinkTrailer = ""},
                new Movie{IdMovie = "movie000004",NameMovie = "Ma Gương 3",Actor = "NVA1, NVA4, NVA9,...", Director = "NVD1", Description = "Noi dung phim 4", Category = "The loai 1, The loai 3", Duration = new TimeSpan(1, 30, 20), Rate = 5.0, ReleaseDate = new DateTime(2022,3,16), LinkTrailer = ""},
                new Movie{IdMovie = "movie000005",NameMovie = "Người Môi Giới",Actor = "NVA3, NVA2, NVA10,...", Director = "NVD1", Description = "Noi dung phim 5", Category = "The loai 1, The loai 2", Duration = new TimeSpan(4, 30, 20), Rate = 5.0, ReleaseDate = new DateTime(2022,3,16), LinkTrailer = ""},
            });
            context.Rooms.AddRange(new[]
            {
                new Room{IdRoom = "room01", NameRoom = "Rap 1", NumberSeats = 50},
                new Room{IdRoom = "room02", NameRoom = "Rap 2", NumberSeats = 45},
                new Room{IdRoom = "room03", NameRoom = "Rap 3", NumberSeats = 50},
                new Room{IdRoom = "room04", NameRoom = "Rap 4", NumberSeats = 50},
                new Room{IdRoom = "room05", NameRoom = "Rap 5", NumberSeats = 50},
            });
            context.PopcornDrinks.AddRange(new[]
            {
                new PopcornDrink{IdPopcornDrink = "pd0001", NamePopcornDrink = "Bap size S", PricePopcornDrink = 10000},
                new PopcornDrink{IdPopcornDrink = "pd0002", NamePopcornDrink = "Bap size M", PricePopcornDrink = 18000},
                new PopcornDrink{IdPopcornDrink = "pd0003", NamePopcornDrink = "Bap size L", PricePopcornDrink = 20000},
                new PopcornDrink{IdPopcornDrink = "pd0004", NamePopcornDrink = "Pepsi size S", PricePopcornDrink = 10000},
                new PopcornDrink{IdPopcornDrink = "pd0005", NamePopcornDrink = "Pepsi size M", PricePopcornDrink = 18000},
                new PopcornDrink{IdPopcornDrink = "pd0006", NamePopcornDrink = "Pepsi size L", PricePopcornDrink = 20000},
            });
        }
    }
}
