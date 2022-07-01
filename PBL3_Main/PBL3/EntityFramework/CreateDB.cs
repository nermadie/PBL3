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
                new Admin{IdPerson = "admin01", NamePerson = "Tran Nhat Minh", Phone = "0912135278", Address = "38 Do Anh Han", Gender = true, Birth = new DateTime(2002, 12, 25), Username = "admin1", Password = "admin1"},
                new Admin{IdPerson = "admin02", NamePerson = "Le Tien Dat", Phone = "0982369881", Address = "36 Thanh Hoa", Gender = true, Birth = new DateTime(2002, 11, 10), Username = "taed13", Password = "luongduthichatdoi13"},
                new Admin{IdPerson = "admin03", NamePerson = "Tran Dinh Gia Khiem", Phone = "0389772165", Address = "29 An Thuong 16", Gender = true, Birth = new DateTime(2002, 07, 29), Username = "admin3", Password = "admin3"}
            });
            context.Customers.AddRange(new[]
            {
                new Customer{ IdPerson = "customer000001", NamePerson = "Phan Tan Quynh", Phone = "0984476253", Address = "123 Hoang Dieu", Gender = true, Birth = new DateTime(2002, 03, 04), Username = "usernameKH1", Password = "passwordKH1", Vip = false},
                new Customer{ IdPerson = "customer000002", NamePerson = "Nguyen Van Khoa", Phone = "0376125328", Address = "12 Truong Chinh", Gender = true, Birth = new DateTime(1992, 05, 07), Username = "usernameKH2", Password = "passwordKH2", Vip = true},
                new Customer{ IdPerson = "customer000003", NamePerson = "Dang Ngoc Khanh", Phone = "0338382221", Address = "50 Tran Duy Hung", Gender = true, Birth = new DateTime(1951, 05, 31), Username = "usernameKH3", Password = "passwordKH3", Vip = false},
                new Customer{ IdPerson = "customer000004", NamePerson = "Tran Hong Duc", Phone = "0385653182", Address = "38 Nguyen Tat Thanh", Gender = false, Birth = new DateTime(1963, 01, 04), Username = "usernameKH4", Password = "passwordKH4", Vip = true},
                new Customer{ IdPerson = "customer000005", NamePerson = "Adam Zapel", Phone = "0436642866", Address = "21 Pham Ngu Lao", Gender = false, Birth = new DateTime(2000, 12, 15), Username = "usernameKH5", Password = "passwordKH5", Vip = true},
                new Customer{ IdPerson = "customer000006", NamePerson = "Don Key", Phone = "043782 3389 ", Address = "Nha Trang", Gender = true, Birth = new DateTime(1973, 12, 25), Username = "usernameKH6", Password = "passwordKH6", Vip = false},
            });
            context.Employees.AddRange(new[]
            {

                new Employee{ IdPerson = "employee000001", NamePerson = "An Tuấn Chương", Phone = "0855553817", Address = "Camden, New Jersey(NJ)", Gender = true, Birth = new DateTime(1978, 12, 23), Username = "usernameNV1", Password = "passwordNV1", Shift = 1, Wage = 5000000},
                new Employee{ IdPerson = "employee000002", NamePerson = "Bành Ðức Kiên", Phone = "0146895622", Address = "Danbury, Connecticut(CT)", Gender = true, Birth = new DateTime(1970, 03, 03), Username = "usernameNV2", Password = "passwordNV2", Shift = 1, Wage = 5000000},
                new Employee{ IdPerson = "employee000003", NamePerson = "Khổng Hoàng Hiệp", Phone = "0229212537", Address = "Rainbow City, Alabama(AL)", Gender = true, Birth = new DateTime(1940, 08, 13), Username = "usernameNV3", Password = "passwordNV3",  Shift = 1, Wage = 5000000},
                new Employee{ IdPerson = "employee000004", NamePerson = "Cống Quang Huy", Phone = "0433745873", Address = "Taunton, Massachusetts(MA)", Gender = false, Birth = new DateTime(1983, 02, 25), Username = "usernameNV4", Password = "passwordNV4",  Shift = 1, Wage = 5000000},
                new Employee{ IdPerson = "employee000005", NamePerson = "Phùng Hải Nam", Phone = "0748609148", Address = "Freeburg, Illinois(IL)", Gender = false, Birth = new DateTime(1993, 03, 14), Username = "usernameNV5", Password = "passwordNV5",  Shift = 2, Wage = 6000000},
                new Employee{ IdPerson = "employee000006", NamePerson = "Ứng Huy Phong", Phone = "0311557546", Address = "Lutz, Florida(FL)", Gender = true, Birth = new DateTime(1977, 12, 25), Username = "usernameNV6", Password = "passwordNV6", Shift = 2, Wage = 6000000},
            });
            context.Orders.AddRange(new[]
            {
                new Order{IdOrder = "order00000001", IdCustomer = "customer000001", TimeOrder = new DateTime(2015, 12, 25), Code = "awesome"},
                new Order{IdOrder = "order00000002", IdCustomer = "customer000002", TimeOrder = new DateTime(2015, 12, 25), Code = "blackday"},
                new Order{IdOrder = "order00000003", IdCustomer = "customer000003", TimeOrder = new DateTime(2015, 12, 25), Code = "standard"},
                new Order{IdOrder = "order00000004", IdCustomer = "customer000004", TimeOrder = new DateTime(2015, 12, 25), Code = "momo"},
                new Order{IdOrder = "order00000005", IdCustomer = "customer000005", TimeOrder = new DateTime(2015, 12, 25), Code = "shinan"},
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
                new TicketOrder{IdTicketOrder = "ticketorder00000001", IdOrder = "order00000001", IdRoom = "room02",Time = new DateTime(2022,6,30,09,10,00),SeatPurchased = "A1"},
                new TicketOrder{IdTicketOrder = "ticketorder00000002", IdOrder = "order00000002", IdRoom = "room02",Time = new DateTime(2022,6,30,11,00,00),SeatPurchased = "A2"},
                new TicketOrder{IdTicketOrder = "ticketorder00000003", IdOrder = "order00000003", IdRoom = "room02",Time = new DateTime(2022,6,30,12,50,00),SeatPurchased = "A3"},
                new TicketOrder{IdTicketOrder = "ticketorder00000004", IdOrder = "order00000004", IdRoom = "room02",Time = new DateTime(2022,6,30,14,45,00),SeatPurchased = "A4"},
                new TicketOrder{IdTicketOrder = "ticketorder00000005", IdOrder = "order00000005", IdRoom = "room02",Time = new DateTime(2022,6,30,16,40,00),SeatPurchased = "A5"},
            });
            context.ShowTimes.AddRange(new[]
            {
                // 30/06/2022
                new ShowTime{IdMovie = "movie000001", IdRoom = "room02", Seat = "10000000000000000000000000000000000000000000000000000000000000000000000000000000", Time = new DateTime(2022,6,30,09,10,00), TicketPrice = 125000},
                new ShowTime{IdMovie = "movie000001", IdRoom = "room02", Seat = "01000000000000000000000000000000000000000000000000000000000000000000000000000000", Time = new DateTime(2022,6,30,11,00,00), TicketPrice = 125000},
                new ShowTime{IdMovie = "movie000001", IdRoom = "room02", Seat = "00100000000000000000000000000000000000000000000000000000000000000000000000000000", Time = new DateTime(2022,6,30,12,50,00), TicketPrice = 125000},
                new ShowTime{IdMovie = "movie000001", IdRoom = "room02", Seat = "00010000000000000000000000000000000000000000000000000000000000000000000000000000", Time = new DateTime(2022,6,30,14,45,00), TicketPrice = 125000},
                new ShowTime{IdMovie = "movie000001", IdRoom = "room02", Seat = "00001000000000000000000000000000000000000000000000000000000000000000000000000000", Time = new DateTime(2022,6,30,16,40,00), TicketPrice = 125000},
                new ShowTime{IdMovie = "movie000001", IdRoom = "room02", Seat = "00000000000000000000000000000000000000000000000000000000000000000000000000000000", Time = new DateTime(2022,6,30,18,30,00), TicketPrice = 125000},
                new ShowTime{IdMovie = "movie000001", IdRoom = "room03", Seat = "00000000000000000000000000000000000000000000000000000000000000000000000000000000", Time = new DateTime(2022,6,30,19,10,00), TicketPrice = 125000},
                new ShowTime{IdMovie = "movie000001", IdRoom = "room04", Seat = "00000000000000000000000000000000000000000000000000000000000000000000000000000000", Time = new DateTime(2022,6,30,10,10,00), TicketPrice = 125000},
                new ShowTime{IdMovie = "movie000001", IdRoom = "room04", Seat = "00000000000000000000000000000000000000000000000000000000000000000000000000000000", Time = new DateTime(2022,6,30,12,00,00), TicketPrice = 125000},
                new ShowTime{IdMovie = "movie000001", IdRoom = "room04", Seat = "00000000000000000000000000000000000000000000000000000000000000000000000000000000", Time = new DateTime(2022,6,30,13,50,00), TicketPrice = 125000},
                new ShowTime{IdMovie = "movie000001", IdRoom = "room04", Seat = "00000000000000000000000000000000000000000000000000000000000000000000000000000000", Time = new DateTime(2022,6,30,15,40,00), TicketPrice = 125000},
                new ShowTime{IdMovie = "movie000001", IdRoom = "room04", Seat = "00000000000000000000000000000000000000000000000000000000000000000000000000000000", Time = new DateTime(2022,6,30,17,30,00), TicketPrice = 125000},
                new ShowTime{IdMovie = "movie000001", IdRoom = "room02", Seat = "00000000000000000000000000000000000000000000000000000000000000000000000000000000", Time = new DateTime(2022,6,30,20,20,00), TicketPrice = 125000},
                new ShowTime{IdMovie = "movie000001", IdRoom = "room02", Seat = "00000000000000000000000000000000000000000000000000000000000000000000000000000000", Time = new DateTime(2022,6,30,22,10,00), TicketPrice = 125000},

                new ShowTime{IdMovie = "movie000002", IdRoom = "room01", Seat = "00000000000000000000000000000000000000000000000000000000000000000000000000000000", Time = new DateTime(2022,6,30,09,50,00), TicketPrice = 145000},
                new ShowTime{IdMovie = "movie000002", IdRoom = "room05", Seat = "00000000000000000000000000000000000000000000000000000000000000000000000000000000", Time = new DateTime(2022,6,30,10,45,00), TicketPrice = 145000},
                new ShowTime{IdMovie = "movie000002", IdRoom = "room01", Seat = "00000000000000000000000000000000000000000000000000000000000000000000000000000000", Time = new DateTime(2022,6,30,12,30,00), TicketPrice = 145000},
                new ShowTime{IdMovie = "movie000002", IdRoom = "room05", Seat = "00000000000000000000000000000000000000000000000000000000000000000000000000000000", Time = new DateTime(2022,6,30,13,30,00), TicketPrice = 145000},
                new ShowTime{IdMovie = "movie000002", IdRoom = "room01", Seat = "00000000000000000000000000000000000000000000000000000000000000000000000000000000", Time = new DateTime(2022,6,30,15,10,00), TicketPrice = 145000},
                new ShowTime{IdMovie = "movie000002", IdRoom = "room05", Seat = "00000000000000000000000000000000000000000000000000000000000000000000000000000000", Time = new DateTime(2022,6,30,16,10,00), TicketPrice = 145000},
                new ShowTime{IdMovie = "movie000002", IdRoom = "room01", Seat = "00000000000000000000000000000000000000000000000000000000000000000000000000000000", Time = new DateTime(2022,6,30,17,50,00), TicketPrice = 145000},
                new ShowTime{IdMovie = "movie000002", IdRoom = "room05", Seat = "00000000000000000000000000000000000000000000000000000000000000000000000000000000", Time = new DateTime(2022,6,30,18,50,00), TicketPrice = 145000},
                new ShowTime{IdMovie = "movie000002", IdRoom = "room04", Seat = "00000000000000000000000000000000000000000000000000000000000000000000000000000000", Time = new DateTime(2022,6,30,19,20,00), TicketPrice = 145000},
                new ShowTime{IdMovie = "movie000002", IdRoom = "room01", Seat = "00000000000000000000000000000000000000000000000000000000000000000000000000000000", Time = new DateTime(2022,6,30,20,30,00), TicketPrice = 145000},
                new ShowTime{IdMovie = "movie000002", IdRoom = "room05", Seat = "00000000000000000000000000000000000000000000000000000000000000000000000000000000", Time = new DateTime(2022,6,30,21,30,00), TicketPrice = 145000},

                new ShowTime{IdMovie = "movie000003", IdRoom = "room03", Seat = "00000000000000000000000000000000000000000000000000000000000000000000000000000000", Time = new DateTime(2022,6,30,09,30,00), TicketPrice = 110000},
                new ShowTime{IdMovie = "movie000003", IdRoom = "room03", Seat = "00000000000000000000000000000000000000000000000000000000000000000000000000000000", Time = new DateTime(2022,6,30,14,20,00), TicketPrice = 110000},
                new ShowTime{IdMovie = "movie000003", IdRoom = "room03", Seat = "00000000000000000000000000000000000000000000000000000000000000000000000000000000", Time = new DateTime(2022,6,30,21,10,00), TicketPrice = 110000},

                new ShowTime{IdMovie = "movie000004", IdRoom = "room03", Seat = "00000000000000000000000000000000000000000000000000000000000000000000000000000000", Time = new DateTime(2022,6,30,12,15,00), TicketPrice = 195000},
                new ShowTime{IdMovie = "movie000004", IdRoom = "room03", Seat = "00000000000000000000000000000000000000000000000000000000000000000000000000000000", Time = new DateTime(2022,6,30,17,00,00), TicketPrice = 195000},
                new ShowTime{IdMovie = "movie000004", IdRoom = "room04", Seat = "00000000000000000000000000000000000000000000000000000000000000000000000000000000", Time = new DateTime(2022,6,30,19,50,00), TicketPrice = 195000},

                new ShowTime{IdMovie = "movie000005", IdRoom = "room01", Seat = "00000000000000000000000000000000000000000000000000000000000000000000000000000000", Time = new DateTime(2022,6,30,07,00,00), TicketPrice = 170000},
                new ShowTime{IdMovie = "movie000005", IdRoom = "room03", Seat = "00000000000000000000000000000000000000000000000000000000000000000000000000000000", Time = new DateTime(2022,6,30,07,00,00), TicketPrice = 170000},
                new ShowTime{IdMovie = "movie000005", IdRoom = "room05", Seat = "00000000000000000000000000000000000000000000000000000000000000000000000000000000", Time = new DateTime(2022,6,30,07,00,00), TicketPrice = 170000},

                // 01/07/2022

                new ShowTime{IdMovie = "movie000001", IdRoom = "room02", Seat = "00000000000000000000000000000000000000000000000000000000000000000000000000000000", Time = new DateTime(2022,7,1,09,10,00), TicketPrice = 125000},
                new ShowTime{IdMovie = "movie000001", IdRoom = "room02", Seat = "00000000000000000000000000000000000000000000000000000000000000000000000000000000", Time = new DateTime(2022,7,1,11,00,00), TicketPrice = 125000},
                new ShowTime{IdMovie = "movie000001", IdRoom = "room03", Seat = "00000000000000000000000000000000000000000000000000000000000000000000000000000000", Time = new DateTime(2022,7,1,12,20,00), TicketPrice = 125000},
                new ShowTime{IdMovie = "movie000001", IdRoom = "room02", Seat = "00000000000000000000000000000000000000000000000000000000000000000000000000000000", Time = new DateTime(2022,7,1,12,50,00), TicketPrice = 125000},
                new ShowTime{IdMovie = "movie000001", IdRoom = "room02", Seat = "00000000000000000000000000000000000000000000000000000000000000000000000000000000", Time = new DateTime(2022,7,1,14,45,00), TicketPrice = 125000},
                new ShowTime{IdMovie = "movie000001", IdRoom = "room02", Seat = "00000000000000000000000000000000000000000000000000000000000000000000000000000000", Time = new DateTime(2022,7,1,16,40,00), TicketPrice = 125000},
                new ShowTime{IdMovie = "movie000001", IdRoom = "room02", Seat = "00000000000000000000000000000000000000000000000000000000000000000000000000000000", Time = new DateTime(2022,7,1,18,30,00), TicketPrice = 125000},
                new ShowTime{IdMovie = "movie000001", IdRoom = "room03", Seat = "00000000000000000000000000000000000000000000000000000000000000000000000000000000", Time = new DateTime(2022,7,1,19,15,00), TicketPrice = 125000},
                new ShowTime{IdMovie = "movie000001", IdRoom = "room04", Seat = "00000000000000000000000000000000000000000000000000000000000000000000000000000000", Time = new DateTime(2022,7,1,10,10,00), TicketPrice = 125000},
                new ShowTime{IdMovie = "movie000001", IdRoom = "room04", Seat = "00000000000000000000000000000000000000000000000000000000000000000000000000000000", Time = new DateTime(2022,7,1,12,00,00), TicketPrice = 125000},
                new ShowTime{IdMovie = "movie000001", IdRoom = "room04", Seat = "00000000000000000000000000000000000000000000000000000000000000000000000000000000", Time = new DateTime(2022,7,1,13,50,00), TicketPrice = 125000},
                new ShowTime{IdMovie = "movie000001", IdRoom = "room04", Seat = "00000000000000000000000000000000000000000000000000000000000000000000000000000000", Time = new DateTime(2022,7,1,15,40,00), TicketPrice = 125000},
                new ShowTime{IdMovie = "movie000001", IdRoom = "room04", Seat = "00000000000000000000000000000000000000000000000000000000000000000000000000000000", Time = new DateTime(2022,7,1,17,30,00), TicketPrice = 125000},
                new ShowTime{IdMovie = "movie000001", IdRoom = "room02", Seat = "00000000000000000000000000000000000000000000000000000000000000000000000000000000", Time = new DateTime(2022,7,1,20,20,00), TicketPrice = 125000},
                new ShowTime{IdMovie = "movie000001", IdRoom = "room02", Seat = "00000000000000000000000000000000000000000000000000000000000000000000000000000000", Time = new DateTime(2022,7,1,22,10,00), TicketPrice = 125000},

                new ShowTime{IdMovie = "movie000002", IdRoom = "room01", Seat = "00000000000000000000000000000000000000000000000000000000000000000000000000000000", Time = new DateTime(2022,7,1,09,50,00), TicketPrice = 145000},
                new ShowTime{IdMovie = "movie000002", IdRoom = "room05", Seat = "00000000000000000000000000000000000000000000000000000000000000000000000000000000", Time = new DateTime(2022,7,1,10,45,00), TicketPrice = 145000},
                new ShowTime{IdMovie = "movie000002", IdRoom = "room01", Seat = "00000000000000000000000000000000000000000000000000000000000000000000000000000000", Time = new DateTime(2022,7,1,12,30,00), TicketPrice = 145000},
                new ShowTime{IdMovie = "movie000002", IdRoom = "room05", Seat = "00000000000000000000000000000000000000000000000000000000000000000000000000000000", Time = new DateTime(2022,7,1,13,30,00), TicketPrice = 145000},
                new ShowTime{IdMovie = "movie000002", IdRoom = "room01", Seat = "00000000000000000000000000000000000000000000000000000000000000000000000000000000", Time = new DateTime(2022,7,1,15,10,00), TicketPrice = 145000},
                new ShowTime{IdMovie = "movie000002", IdRoom = "room05", Seat = "00000000000000000000000000000000000000000000000000000000000000000000000000000000", Time = new DateTime(2022,7,1,16,10,00), TicketPrice = 145000},
                new ShowTime{IdMovie = "movie000002", IdRoom = "room01", Seat = "00000000000000000000000000000000000000000000000000000000000000000000000000000000", Time = new DateTime(2022,7,1,17,50,00), TicketPrice = 145000},
                new ShowTime{IdMovie = "movie000002", IdRoom = "room05", Seat = "00000000000000000000000000000000000000000000000000000000000000000000000000000000", Time = new DateTime(2022,7,1,18,50,00), TicketPrice = 145000},
                new ShowTime{IdMovie = "movie000002", IdRoom = "room04", Seat = "00000000000000000000000000000000000000000000000000000000000000000000000000000000", Time = new DateTime(2022,7,1,19,20,00), TicketPrice = 145000},
                new ShowTime{IdMovie = "movie000002", IdRoom = "room01", Seat = "00000000000000000000000000000000000000000000000000000000000000000000000000000000", Time = new DateTime(2022,7,1,20,30,00), TicketPrice = 145000},
                new ShowTime{IdMovie = "movie000002", IdRoom = "room05", Seat = "00000000000000000000000000000000000000000000000000000000000000000000000000000000", Time = new DateTime(2022,7,1,21,30,00), TicketPrice = 145000},

                new ShowTime{IdMovie = "movie000003", IdRoom = "room03", Seat = "00000000000000000000000000000000000000000000000000000000000000000000000000000000", Time = new DateTime(2022,7,1,09,30,00), TicketPrice = 110000},
                new ShowTime{IdMovie = "movie000003", IdRoom = "room03", Seat = "00000000000000000000000000000000000000000000000000000000000000000000000000000000", Time = new DateTime(2022,7,1,14,20,00), TicketPrice = 110000},
                new ShowTime{IdMovie = "movie000003", IdRoom = "room03", Seat = "00000000000000000000000000000000000000000000000000000000000000000000000000000000", Time = new DateTime(2022,7,1,21,10,00), TicketPrice = 110000},

                new ShowTime{IdMovie = "movie000004", IdRoom = "room03", Seat = "00000000000000000000000000000000000000000000000000000000000000000000000000000000", Time = new DateTime(2022,7,1,17,00,00), TicketPrice = 195000},
                new ShowTime{IdMovie = "movie000004", IdRoom = "room04", Seat = "00000000000000000000000000000000000000000000000000000000000000000000000000000000", Time = new DateTime(2022,7,1,22,00,00), TicketPrice = 195000},

                new ShowTime{IdMovie = "movie000005", IdRoom = "room01", Seat = "00000000000000000000000000000000000000000000000000000000000000000000000000000000", Time = new DateTime(2022,7,1,07,00,00), TicketPrice = 170000},
                new ShowTime{IdMovie = "movie000005", IdRoom = "room03", Seat = "00000000000000000000000000000000000000000000000000000000000000000000000000000000", Time = new DateTime(2022,7,1,07,00,00), TicketPrice = 170000},
                new ShowTime{IdMovie = "movie000005", IdRoom = "room05", Seat = "00000000000000000000000000000000000000000000000000000000000000000000000000000000", Time = new DateTime(2022,7,1,07,00,00), TicketPrice = 170000},
                // 02/07/2022
                new ShowTime{IdMovie = "movie000001", IdRoom = "room02", Seat = "00000000000000000000000000000000000000000000000000000000000000000000000000000000", Time = new DateTime(2022,7,2,09,30,00), TicketPrice = 125000},
                new ShowTime{IdMovie = "movie000001", IdRoom = "room03", Seat = "00000000000000000000000000000000000000000000000000000000000000000000000000000000", Time = new DateTime(2022,7,2,12,20,00), TicketPrice = 125000},
                new ShowTime{IdMovie = "movie000001", IdRoom = "room03", Seat = "00000000000000000000000000000000000000000000000000000000000000000000000000000000", Time = new DateTime(2022,7,2,14,20,00), TicketPrice = 125000},
                new ShowTime{IdMovie = "movie000001", IdRoom = "room03", Seat = "00000000000000000000000000000000000000000000000000000000000000000000000000000000", Time = new DateTime(2022,7,2,16,20,00), TicketPrice = 125000},
                new ShowTime{IdMovie = "movie000001", IdRoom = "room02", Seat = "00000000000000000000000000000000000000000000000000000000000000000000000000000000", Time = new DateTime(2022,7,2,17,20,00), TicketPrice = 125000},
                new ShowTime{IdMovie = "movie000001", IdRoom = "room03", Seat = "00000000000000000000000000000000000000000000000000000000000000000000000000000000", Time = new DateTime(2022,7,2,18,20,00), TicketPrice = 125000},
                new ShowTime{IdMovie = "movie000001", IdRoom = "room02", Seat = "00000000000000000000000000000000000000000000000000000000000000000000000000000000", Time = new DateTime(2022,7,2,19,10,00), TicketPrice = 125000},
                new ShowTime{IdMovie = "movie000001", IdRoom = "room04", Seat = "00000000000000000000000000000000000000000000000000000000000000000000000000000000", Time = new DateTime(2022,7,2,10,10,00), TicketPrice = 125000},
                new ShowTime{IdMovie = "movie000001", IdRoom = "room04", Seat = "00000000000000000000000000000000000000000000000000000000000000000000000000000000", Time = new DateTime(2022,7,2,11,50,00), TicketPrice = 125000},
                new ShowTime{IdMovie = "movie000001", IdRoom = "room04", Seat = "00000000000000000000000000000000000000000000000000000000000000000000000000000000", Time = new DateTime(2022,7,2,13,50,00), TicketPrice = 125000},
                new ShowTime{IdMovie = "movie000001", IdRoom = "room04", Seat = "00000000000000000000000000000000000000000000000000000000000000000000000000000000", Time = new DateTime(2022,7,2,15,40,00), TicketPrice = 125000},
                new ShowTime{IdMovie = "movie000001", IdRoom = "room04", Seat = "00000000000000000000000000000000000000000000000000000000000000000000000000000000", Time = new DateTime(2022,7,2,20,10,00), TicketPrice = 125000},
                new ShowTime{IdMovie = "movie000001", IdRoom = "room02", Seat = "00000000000000000000000000000000000000000000000000000000000000000000000000000000", Time = new DateTime(2022,7,2,21,10,00), TicketPrice = 125000},
                new ShowTime{IdMovie = "movie000001", IdRoom = "room04", Seat = "00000000000000000000000000000000000000000000000000000000000000000000000000000000", Time = new DateTime(2022,7,2,22,00,00), TicketPrice = 125000},

                new ShowTime{IdMovie = "movie000002", IdRoom = "room01", Seat = "00000000000000000000000000000000000000000000000000000000000000000000000000000000", Time = new DateTime(2022,7,2,10,00,00), TicketPrice = 145000},
                new ShowTime{IdMovie = "movie000002", IdRoom = "room05", Seat = "00000000000000000000000000000000000000000000000000000000000000000000000000000000", Time = new DateTime(2022,7,2,10,45,00), TicketPrice = 145000},
                new ShowTime{IdMovie = "movie000002", IdRoom = "room02", Seat = "00000000000000000000000000000000000000000000000000000000000000000000000000000000", Time = new DateTime(2022,7,2,11,20,00), TicketPrice = 145000},
                new ShowTime{IdMovie = "movie000002", IdRoom = "room01", Seat = "00000000000000000000000000000000000000000000000000000000000000000000000000000000", Time = new DateTime(2022,7,2,12,40,00), TicketPrice = 145000},
                new ShowTime{IdMovie = "movie000002", IdRoom = "room05", Seat = "00000000000000000000000000000000000000000000000000000000000000000000000000000000", Time = new DateTime(2022,7,2,13,30,00), TicketPrice = 145000},
                new ShowTime{IdMovie = "movie000002", IdRoom = "room01", Seat = "00000000000000000000000000000000000000000000000000000000000000000000000000000000", Time = new DateTime(2022,7,2,15,20,00), TicketPrice = 145000},
                new ShowTime{IdMovie = "movie000002", IdRoom = "room05", Seat = "00000000000000000000000000000000000000000000000000000000000000000000000000000000", Time = new DateTime(2022,7,2,16,10,00), TicketPrice = 145000},
                new ShowTime{IdMovie = "movie000002", IdRoom = "room04", Seat = "00000000000000000000000000000000000000000000000000000000000000000000000000000000", Time = new DateTime(2022,7,2,17,30,00), TicketPrice = 145000},
                new ShowTime{IdMovie = "movie000002", IdRoom = "room01", Seat = "00000000000000000000000000000000000000000000000000000000000000000000000000000000", Time = new DateTime(2022,7,2,18,00,00), TicketPrice = 145000},
                new ShowTime{IdMovie = "movie000002", IdRoom = "room05", Seat = "00000000000000000000000000000000000000000000000000000000000000000000000000000000", Time = new DateTime(2022,7,2,18,50,00), TicketPrice = 145000},
                new ShowTime{IdMovie = "movie000002", IdRoom = "room01", Seat = "00000000000000000000000000000000000000000000000000000000000000000000000000000000", Time = new DateTime(2022,7,2,20,40,00), TicketPrice = 145000},
                new ShowTime{IdMovie = "movie000002", IdRoom = "room05", Seat = "00000000000000000000000000000000000000000000000000000000000000000000000000000000", Time = new DateTime(2022,7,2,21,30,00), TicketPrice = 145000},

                new ShowTime{IdMovie = "movie000003", IdRoom = "room03", Seat = "00000000000000000000000000000000000000000000000000000000000000000000000000000000", Time = new DateTime(2022,7,2,07,00,00), TicketPrice = 110000},
                new ShowTime{IdMovie = "movie000003", IdRoom = "room03", Seat = "00000000000000000000000000000000000000000000000000000000000000000000000000000000", Time = new DateTime(2022,7,2,09,30,00), TicketPrice = 110000},
                new ShowTime{IdMovie = "movie000003", IdRoom = "room03", Seat = "00000000000000000000000000000000000000000000000000000000000000000000000000000000", Time = new DateTime(2022,7,2,20,20,00), TicketPrice = 110000},

                new ShowTime{IdMovie = "movie000004", IdRoom = "room04", Seat = "00000000000000000000000000000000000000000000000000000000000000000000000000000000", Time = new DateTime(2022,7,2,07,00,00), TicketPrice = 195000},
                new ShowTime{IdMovie = "movie000004", IdRoom = "room04", Seat = "00000000000000000000000000000000000000000000000000000000000000000000000000000000", Time = new DateTime(2022,7,2,19,50,00), TicketPrice = 195000},

                new ShowTime{IdMovie = "movie000005", IdRoom = "room01", Seat = "00000000000000000000000000000000000000000000000000000000000000000000000000000000", Time = new DateTime(2022,7,2,07,00,00), TicketPrice = 170000},
                new ShowTime{IdMovie = "movie000005", IdRoom = "room02", Seat = "00000000000000000000000000000000000000000000000000000000000000000000000000000000", Time = new DateTime(2022,7,2,07,00,00), TicketPrice = 170000},
                new ShowTime{IdMovie = "movie000005", IdRoom = "room05", Seat = "00000000000000000000000000000000000000000000000000000000000000000000000000000000", Time = new DateTime(2022,7,2,07,00,00), TicketPrice = 170000},
            });
            context.Movies.AddRange(new[]
            {
                new Movie{IdMovie = "movie000001",NameMovie = "MINIONS: SỰ TRỖI DẬY CỦA GRU", Actor = "Steve Carell, Pierre Coffin, Russell Brand, Alan Arkin, Taraji P. Henson", Director = "Kyle Balda", Description = "Rất lâu trước khi trở thành một phản diện chuyên nghiệp, Gru chỉ là một cậu bé 12 tuổi sống ở vùng ngoại ô vào những năm 1970, với ước mơ một ngày sẽ làm “bá chủ” thế giới. Và 3 “quả chuối” vàng biết đi từ trên trời rơi xuống đã là những đồng đội đầu tiên của Gru, bên cạnh ủng hộ cậu bé, cùng nhau thiết kế những vũ khí đầu tiên, thực hiện những phi vụ đầu tiên.", Category = "Comedy, Action, Adventure, Animation, Family", Duration = new TimeSpan(2, 30, 20), Rate = 5.0, ReleaseDate = DateTime.Now, LinkTrailer = "https://www.youtube.com/watch?v=_12FEKaq2Vw"},
                new Movie{IdMovie = "movie000002",NameMovie = "Sát Thủ Nhân Tạo 2: Mẫu Vật Còn Lại", Actor = "Shin Si-a, Park Eun-bin, Seo Eun-su, Jin Goo, Seong Yu-bin", Director = "Park Hoon-Jung", Description = "Lợi dụng sự cố kinh hoàng tại cơ sở thí nghiệm, cô nàng 17 tuổi mang bí danh ARK-ADP1, một nữ sát thủ nhân tạo có siêu năng lực, đã thoát được ra ngoài. Cô bị những người tạo ra mình lẫn các thế lực bí ẩn khác truy bắt gắt gao.", Category = "Action, Mystery, Thriller", Duration = new TimeSpan(2, 30, 20), Rate = 5.0, ReleaseDate = DateTime.Now, LinkTrailer = "https://www.youtube.com/watch?v=Xl3ccrJBvSs"},
                new Movie{IdMovie = "movie000003",NameMovie = "Em và Trịnh", Actor = "Trần Lực, Avin Lu, Lan Thy, Hoàng Hà, Bùi Lan Hương", Director = "Phan Gia Nhật Linh", Description = "Phim điện ảnh Em và Trịnh kể về cuộc đời của nhạc sĩ Trịnh Công Sơn từ khi còn trẻ đến tuổi trung niên, khi ông hoài niệm về những nàng thơ trong cuộc đời mình: Bích Diễm, Dao Ánh, Khánh Ly, Hồng Nhung...", Category = "Drama, Musical", Duration = new TimeSpan(3, 30, 20), Rate = 5.0, ReleaseDate = DateTime.Now, LinkTrailer = "https://www.youtube.com/watch?v=IosqnBOkk2I"},
                new Movie{IdMovie = "movie000004",NameMovie = "Điện Thoại Đen",Actor = "Mason Thames, Madeleine McGraw, Jeremy Davies, Ethan Hawke, James Ransone", Director = "Scott Derrickson", Description = "Siêu phẩm kinh dị mới nhất của nhà Blumhouse hợp tác sản xuất cùng đạo diễn \"Doctor Strange\". Dựa trên tác phẩm truyện ngắn cùng tên của Joe Hill, bộ phim theo chân Finney Shaw, một cậu bé 13 tuổi dù rất thông minh nhưng lại có tính cách nhút nhát, hay sợ người lạ. Vào một ngày nọ, Finney bị một kẻ giết người tàn bạo bắt cóc và bị mắc kẹt trong tầng hầm cách âm. Trong lúc cậu nhóc tìm mọi cách kêu cứu nhưng không thể, bỗng một chiếc điện thoại vốn đã bị ngắt kết nối từ lâu bắt đầu đổ chuông, Finney phát hiện ra rằng cậu có thể nghe thấy giọng nói của những \"nạn nhân\" trước đó. Và dường như họ đang cố gắng giúp Finney để những gì đã xảy ra với họ sẽ không xảy ra với cậu bé.", Category = "Horror", Duration = new TimeSpan(2, 10, 20), Rate = 5.0, ReleaseDate = DateTime.Now, LinkTrailer = "https://www.youtube.com/watch?v=A-iDBvW7SdY"},
                new Movie{IdMovie = "movie000005",NameMovie = "Ma Gương 3",Actor = "Nicole Rossi, Andryan Bima, Ali Fikry, Ciara Nadine Brosnan, Adlu Fahrezy", Director = "Rizal Mantovani", Description = "Dinda sau khi cùng gia đình mình đánh đuổi quỷ dữ về địa ngục, sức mạnh của cô bé dần trở nên mất kiểm soát gây tổn thương cho mọi người. Liệu con quỷ thực sự đã biến mất hay trú ẩn bên trong cô bé đợi ngày trở lại?", Category = "Horror", Duration = new TimeSpan(1, 30, 20), Rate = 5.0, ReleaseDate = DateTime.Now, LinkTrailer = "https://www.youtube.com/watch?v=q_qhLbD5oo8"},
            });
            context.Rooms.AddRange(new[]
            {
                new Room{IdRoom = "room01", NameRoom = "Screen 01", NumberSeats = 80},
                new Room{IdRoom = "room02", NameRoom = "Screen 02", NumberSeats = 80},
                new Room{IdRoom = "room03", NameRoom = "Screen 03", NumberSeats = 80},
                new Room{IdRoom = "room04", NameRoom = "Screen 04", NumberSeats = 80},
                new Room{IdRoom = "room05", NameRoom = "Screen 05", NumberSeats = 80},
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
