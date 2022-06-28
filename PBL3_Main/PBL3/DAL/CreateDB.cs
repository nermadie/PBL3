using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL3.DAL;
using PBL3.DTO.DTO_Order;
using PBL3.DTO.DTO_Person;
using PBL3.DTO.DTO_PopcornDrink;
using PBL3.DTO.DTO_ShowTime;

namespace PBL3.DAL
{
    public class CreateDB : DropCreateDatabaseIfModelChanges<QLRapChieuPhim>
    {
        protected override void Seed(QLRapChieuPhim context)
        {
            context.Customers.AddRange(new[]
            {
                new Customer{ IdPerson = 1, NamePerson = "NVA", Phone = "0123123", Address = "38 Do Anh Han", Gender = true, Birth = new DateTime(1999, 12, 25), Username = "a", Password = "a", Vip = false},
                new Customer{ IdPerson = 2, NamePerson = "NVB", Phone = "0123124", Address = "12 Truong Chinh", Gender = true, Birth = new DateTime(1960, 10, 26), Username = "usernameKH2", Password = "passwordKH2", Vip = true},
                new Customer{ IdPerson = 3, NamePerson = "NVC", Phone = "0123125", Address = "50 Tran Duy Hung", Gender = true, Birth = new DateTime(2002, 2, 1), Username = "usernameKH3", Password = "passwordKH3", Vip = false},
                new Customer{ IdPerson = 4, NamePerson = "NVD", Phone = "0123126", Address = "38 Nguyen Tat Thanh", Gender = false, Birth = new DateTime(1962, 12, 25), Username = "usernameKH4", Password = "passwordKH4", Vip = true},
                new Customer{ IdPerson = 5, NamePerson = "NVE", Phone = "0123127", Address = "21 Pham Ngu Lao", Gender = false, Birth = new DateTime(2000, 12, 15), Username = "usernameKH5", Password = "passwordKH5", Vip = true},
                new Customer{ IdPerson = 6, NamePerson = "NVF", Phone = "0123128", Address = "Nha Trang", Gender = true, Birth = new DateTime(1973, 12, 25), Username = "usernameKH6", Password = "passwordKH6", Vip = false},
            });
            context.Employees.AddRange(new[]
            {

                new Employee{ IdPerson = 1, NamePerson = "NVA", Phone = "0123123", Address = "38 Do Anh Han", Gender = true, Birth = new DateTime(1999, 12, 25), Username = "usernameNV1", Password = "passwordNV1", Shift = 1, Wage = 5000000},
                new Employee{ IdPerson = 2, NamePerson = "NVB", Phone = "0123124", Address = "12 Truong Chinh", Gender = true, Birth = new DateTime(1960, 10, 26), Username = "usernameNV2", Password = "passwordNV2", Shift = 1, Wage = 5000000},
                new Employee{ IdPerson = 3, NamePerson = "NVC", Phone = "0123125", Address = "50 Tran Duy Hung", Gender = true, Birth = new DateTime(2002, 2, 1), Username = "usernameNV3", Password = "passwordNV3",  Shift = 1, Wage = 5000000},
                new Employee{ IdPerson = 4, NamePerson = "NVD", Phone = "0123126", Address = "38 Nguyen Tat Thanh", Gender = false, Birth = new DateTime(1962, 12, 25), Username = "usernameNV4", Password = "passwordNV4",  Shift = 1, Wage = 5000000},
                new Employee{ IdPerson = 5, NamePerson = "NVE", Phone = "0123127", Address = "21 Pham Ngu Lao", Gender = false, Birth = new DateTime(2000, 12, 15), Username = "usernameNV5", Password = "passwordNV5",  Shift = 2, Wage = 6000000},
                new Employee{ IdPerson = 6, NamePerson = "NVF", Phone = "0123128", Address = "Nha Trang", Gender = true, Birth = new DateTime(1973, 12, 25), Username = "usernameNV6", Password = "passwordNV6", Shift = 2, Wage = 6000000},
            });
            context.Orders.AddRange(new[]
            {
                new Order{IdOrder = 1, IdCustomer = 1, TimeOrder = new DateTime(2015, 12, 25), Code = "sadad"},
                new Order{IdOrder = 2, IdCustomer = 2, TimeOrder = new DateTime(2015, 12, 25), Code = "sadafsq"},
                new Order{IdOrder = 3, IdCustomer = 3, TimeOrder = new DateTime(2015, 12, 25), Code = ""},
                new Order{IdOrder = 4, IdCustomer = 4, TimeOrder = new DateTime(2015, 12, 25), Code = ""},
                new Order{IdOrder = 5, IdCustomer = 5, TimeOrder = new DateTime(2015, 12, 25), Code = "werwet"},
            });
            context.PopcornDrinkOrders.AddRange(new[]
            {
                new PopcornDrinkOrder{IdPopcornDrinkOrder = 1, IdOrder = 1, NamePopcornDrink = "Bap size S", PopcornDrinkPrice = 10000, Quantity = 2},
                new PopcornDrinkOrder{IdPopcornDrinkOrder = 2, IdOrder = 1, NamePopcornDrink = "Pepsi size L", PopcornDrinkPrice = 20000, Quantity = 1},
                new PopcornDrinkOrder{IdPopcornDrinkOrder =3, IdOrder = 2, NamePopcornDrink = "Bap size L", PopcornDrinkPrice = 20000, Quantity = 2},
                new PopcornDrinkOrder{IdPopcornDrinkOrder =4, IdOrder = 2, NamePopcornDrink = "Pepsi size M", PopcornDrinkPrice = 18000, Quantity = 1},
                new PopcornDrinkOrder{IdPopcornDrinkOrder =5, IdOrder = 3, NamePopcornDrink = "Bap size S", PopcornDrinkPrice = 10000, Quantity = 2},
            });
            context.TicketOrders.AddRange(new[]
            {
                new TicketOrder{IdTicketOrder = 1, IdOrder = 1, IdRoom = 1,Time = new DateTime(2022, 5, 1, 15, 30, 0) ,SeatPurchased = "A1"},
                new TicketOrder{IdTicketOrder = 2, IdOrder = 2, IdRoom = 2,Time = new DateTime(2022, 5, 1, 15, 30, 0) ,SeatPurchased = "A1"},
                new TicketOrder{IdTicketOrder = 3, IdOrder = 3, IdRoom = 3,Time = new DateTime(2022, 5, 1, 15, 30, 0) ,SeatPurchased = "A1"},
                new TicketOrder{IdTicketOrder = 4, IdOrder = 4, IdRoom = 4,Time = new DateTime(2022, 5, 1, 15, 30, 0) ,SeatPurchased = "A1"},
                new TicketOrder{IdTicketOrder = 5, IdOrder = 5, IdRoom = 5,Time = new DateTime(2022, 5, 1, 15, 30, 0) ,SeatPurchased = "A1"},
            });
            context.ShowTimes.AddRange(new[]
            {
                new ShowTime{IdMovie = 1, IdRoom = 1, Seat = "1000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000", Time = new DateTime(2022, 5, 1, 15, 30, 0), TicketPrice = 50000},
                new ShowTime{IdMovie = 2, IdRoom = 2, Seat = "0110000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000", Time = new DateTime(2022, 5, 1, 15, 30, 0), TicketPrice = 50000},
                new ShowTime{IdMovie = 3, IdRoom = 3, Seat = "0001110000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000", Time = new DateTime(2022, 5, 1, 15, 30, 0), TicketPrice = 50000},
                new ShowTime{IdMovie = 4, IdRoom = 4, Seat = "0000001111000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000", Time = new DateTime(2022, 5, 1, 15, 30, 0), TicketPrice = 50000},
                new ShowTime{IdMovie = 5, IdRoom = 5, Seat = "0000000000111110000000000000000000000000000000000000000000000000000000000000000000000000000000000000", Time = new DateTime(2022, 5, 1, 15, 30, 0), TicketPrice = 50000},
            });
            context.Movies.AddRange(new[]
            {
                new Movie{IdMovie = 1,NameMovie = "Sát Thủ Nhân Tạo 2: Mẫu Vật Còn Lại",Actor = "NVA1, NVA2, NVA3,...", Director = "NVD1", Description = "Noi dung phim 1", Category = "The loai 1, The loai 2", Duration = new TimeSpan(2, 30, 20), Rate = 5.0},
                new Movie{IdMovie = 2,NameMovie = "Em và Trịnh",Actor = "NVA1, NVA2, NVA4,...", Director = "NVD2", Description = "Noi dung phim 2", Category = "The loai 4, The loai 2", Duration = new TimeSpan(3, 30, 20), Rate = 5.0},
                new Movie{IdMovie = 3,NameMovie = "Điện Thoại Đen", Actor = "NVA1, NVA3, NVA5,...", Director = "NVD3", Description = "Noi dung phim 3", Category = "The loai 5", Duration = new TimeSpan(2, 10, 20), Rate = 5.0},
                new Movie{IdMovie = 4,NameMovie = "Ma Gương 3", Actor = "NVA1, NVA4, NVA9,...", Director = "NVD1", Description = "Noi dung phim 4", Category = "The loai 1, The loai 3", Duration = new TimeSpan(1, 30, 20), Rate = 5.0},
                new Movie{IdMovie = 5,NameMovie = "Người Môi Giới",Actor = "NVA3, NVA2, NVA10,...", Director = "NVD1", Description = "Noi dung phim 5", Category = "The loai 1, The loai 2", Duration = new TimeSpan(4, 30, 20), Rate = 5.0},

            });
            context.Rooms.AddRange(new[]
            {
                new Room{IdRoom = 1, NameRoom = "Rap 1", NumberSeats = 100},
                new Room{IdRoom = 2, NameRoom = "Rap 2", NumberSeats = 100},
                new Room{IdRoom = 3, NameRoom = "Rap 3", NumberSeats = 100},
                new Room{IdRoom = 4, NameRoom = "Rap 4", NumberSeats = 100},
                new Room{IdRoom = 5, NameRoom = "Rap 5", NumberSeats = 100},
            });
            context.PopcornDrinks.AddRange(new[]
            {
                new PopcornDrink{IdPopcornDrink = 1, NamePopcornDrink = "Bap size S", PricePopcornDrink = 10000},
                new PopcornDrink{IdPopcornDrink = 2, NamePopcornDrink = "Bap size M", PricePopcornDrink = 18000},
                new PopcornDrink{IdPopcornDrink = 3, NamePopcornDrink = "Bap size L", PricePopcornDrink = 20000},
                new PopcornDrink{IdPopcornDrink = 4, NamePopcornDrink = "Pepsi size S", PricePopcornDrink = 10000},
                new PopcornDrink{IdPopcornDrink = 5, NamePopcornDrink = "Pepsi size M", PricePopcornDrink = 18000},
                new PopcornDrink{IdPopcornDrink = 6, NamePopcornDrink = "Pepsi size L", PricePopcornDrink = 20000},
            });
        }
    }
}
