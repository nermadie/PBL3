﻿using System;
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
    public class CreateDB : DropCreateDatabaseIfModelChanges<QLRapChieuPhim>
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
                new Customer{ IdPerson = "customer000006", NamePerson = "Don Key", Phone = "0437823389", Address = "Nha Trang", Gender = true, Birth = new DateTime(1973, 12, 25), Username = "usernameKH6", Password = "passwordKH6", Vip = false},
                new Customer{ IdPerson = "customer000007", NamePerson = "Victor Lee", Phone = "043782233895", Address = "Panama City Beach, FL(state),USA", Gender = true, Birth = new DateTime(2001,05,27), Username = "usernameKH7", Password = "passwordKH7", Vip = false},
                new Customer{ IdPerson = "customer000008", NamePerson = "Jennie Scott", Phone = "(415) 794-6284", Address = "Lincoln, Delaware(DE), 19960", Gender = true, Birth = new DateTime(2010,5,16), Username = "usernameKH8", Password = "passwordKH8", Vip = true},
                new Customer{ IdPerson = "customer000009", NamePerson = "Casey Curry", Phone = "(973) 947-7885", Address = "Middlebury, Vermont(VT), 05753", Gender = false, Birth = new DateTime(2007,11,1), Username = "usernameKH9", Password = "passwordKH9", Vip = false},
                new Customer{ IdPerson = "customer000010", NamePerson = "Melanie Briggs", Phone = "(958) 894-6684", Address = "Millbrook, Alabama(AL), 36054", Gender = false, Birth = new DateTime(2017,9,12), Username = "usernameKH10", Password = "passwordKH10", Vip = true},
                new Customer{ IdPerson = "customer000011", NamePerson = "Nathan Griffin", Phone = "(304) 307-5544", Address = "Algona, Iowa(IA), 50511", Gender = false, Birth = new DateTime(1990,2,26), Username = "usernameKH11", Password = "passwordKH11", Vip = true},
                new Customer{ IdPerson = "customer000012", NamePerson = "Lela Collins", Phone = "(594) 798-6701", Address = "Ann Arbor, Michigan(MI), 48108", Gender = false, Birth = new DateTime(2014,6,18), Username = "usernameKH12", Password = "passwordKH12", Vip = false},
                new Customer{ IdPerson = "customer000013", NamePerson = "Bessie Cox", Phone = "(843) 916-1418", Address = "Ann Arbor, Michigan(MI), 48108", Gender = true, Birth = new DateTime(2014,2,26), Username = "usernameKH13", Password = "passwordKH13", Vip = true},
                new Customer{ IdPerson = "customer000014", NamePerson = "Erick Day", Phone = "(529) 283-9804", Address = "Hoschton, Georgia(GA), 30548", Gender = true, Birth = new DateTime(2005,1,30), Username = "usernameKH14", Password = "passwordKH14", Vip = false},
                new Customer{ IdPerson = "customer000015", NamePerson = "Homer Bates", Phone = "(643) 703-6750", Address = "Stinson Beach, California(CA), 94970", Gender = true, Birth = new DateTime(2011,10,1), Username = "usernameKH15", Password = "passwordKH15", Vip = false},
                new Customer{ IdPerson = "customer000016", NamePerson = "Whitney Delgado", Phone = "(298) 877-3592", Address = "Revere, Massachusetts(MA), 02151", Gender = false, Birth = new DateTime(1990,6,12), Username = "usernameKH16", Password = "passwordKH16", Vip = false},
                new Customer{ IdPerson = "customer000017", NamePerson = "Lillian Peterson", Phone = "(227) 908-6229", Address = "Bemidji, Minnesota(MN), 56601", Gender = false, Birth = new DateTime(1994,11,1), Username = "usernameKH17", Password = "passwordKH17", Vip = false},
                new Customer{ IdPerson = "customer000018", NamePerson = "Wanda Reed", Phone = "(677) 513-1514", Address = "Ogden, Utah(UT), 84404", Gender = true, Birth = new DateTime(2017,9,30), Username = "usernameKH18", Password = "passwordKH18", Vip = true},
                new Customer{ IdPerson = "customer000019", NamePerson = "Juan Henderson", Phone = "(965) 969-9605", Address = "Brevard, North Carolina(NC), 28712", Gender = true, Birth = new DateTime(1990,2,3), Username = "usernameKH19", Password = "passwordKH19", Vip = false},
                new Customer{ IdPerson = "customer000020", NamePerson = "Theresa Stewart", Phone = "(499) 355-9635", Address = "Redondo Beach, California(CA), 90277", Gender = true, Birth = new DateTime(2009,3,12), Username = "usernameKH20", Password = "passwordKH20", Vip = false},
                new Customer{ IdPerson = "customer000021", NamePerson = "Betty Jackson", Phone = "(658) 224-4781", Address = "Garden City, Michigan(MI), 48135", Gender = true, Birth = new DateTime(2008,5,10), Username = "usernameKH21", Password = "passwordKH21", Vip = false},
                new Customer{ IdPerson = "customer000022", NamePerson = "William Murphy", Phone = "(200) 641-5757", Address = "Canutillo, Texas(TX), 79835", Gender = false, Birth = new DateTime(1997,4,1), Username = "usernameKH22", Password = "passwordKH22", Vip = false},
                new Customer{ IdPerson = "customer000023", NamePerson = "Nancy White", Phone = "(286) 767-3117", Address = "Springport, Michigan(MI), 49284", Gender = false, Birth = new DateTime(2018,11,2), Username = "usernameKH23", Password = "passwordKH23", Vip = false},
                new Customer{ IdPerson = "customer000024", NamePerson = "Marie Thomas", Phone = "(892) 978-9901", Address = "Ewa Beach, Hawaii(HI), 96706", Gender = false, Birth = new DateTime(2018,7,18), Username = "usernameKH24", Password = "passwordKH24", Vip = true},
                new Customer{ IdPerson = "customer000025", NamePerson = "Tina Morgan", Phone = "(789) 255-3648", Address = "Ottawa, Ohio(OH), 45875", Gender = true, Birth = new DateTime(2018,9,29), Username = "usernameKH25", Password = "passwordKH25", Vip = true},
                new Customer{ IdPerson = "customer000026", NamePerson = "Sandra Morris", Phone = "(544) 613-3653", Address = "Hutto, Texas(TX), 78634", Gender = true, Birth = new DateTime(2006,8,8), Username = "usernameKH26", Password = "passwordKH26", Vip = true},
                new Customer{ IdPerson = "customer000027", NamePerson = "Nicole Campbell", Phone = "(311) 812-4122", Address = "Crandon, Wisconsin(WI), 54520", Gender = true, Birth = new DateTime(1997,7,18), Username = "usernameKH27", Password = "passwordKH27", Vip = true},
                new Customer{ IdPerson = "customer000028", NamePerson = "Kenneth Murphy", Phone = "(257) 882-2915", Address = "Burlington, Iowa(IA), 52601", Gender = true, Birth = new DateTime(2020,11,11), Username = "usernameKH28", Password = "passwordKH28", Vip = true},
                new Customer{ IdPerson = "customer000029", NamePerson = "Pamela Walker", Phone = "(651) 545-2725", Address = "Black River Falls, Wisconsin(WI), 54615", Gender = false, Birth = new DateTime(2016,6,27), Username = "usernameKH29", Password = "passwordKH29", Vip = false},
                new Customer{ IdPerson = "customer000030", NamePerson = "Michelle Ward", Phone = "(610) 351-4869", Address = "Byram, Mississippi(MS), 39272", Gender = true, Birth = new DateTime(2012,7,9), Username = "usernameKH30", Password = "passwordKH30", Vip = false},
                new Customer{ IdPerson = "customer000031", NamePerson = "Jacqueline Collins", Phone = "(347) 553-8910", Address = "Bastrop, Louisiana(LA), 71220", Gender = true, Birth = new DateTime(2009,6,15), Username = "usernameKH31", Password = "passwordKH31", Vip = false},
                new Customer{ IdPerson = "customer000032", NamePerson = "Daniel King", Phone = "(473) 402-2554", Address = "Carmichael, California(CA), 95608", Gender = true, Birth = new DateTime(2006,11,4), Username = "usernameKH32", Password = "passwordKH32", Vip = false},
                new Customer{ IdPerson = "customer000033", NamePerson = "Roy Cox", Phone = "(833) 230-0367", Address = "Corunna, Michigan(MI), 48817", Gender = true, Birth = new DateTime(2014,4,17), Username = "usernameKH33", Password = "passwordKH33", Vip = false},
                new Customer{ IdPerson = "customer000034", NamePerson = "Jack Martin", Phone = "(627) 892-3474", Address = "York, South Carolina(SC), 29745", Gender = true, Birth = new DateTime(2006,5,26), Username = "usernameKH34", Password = "passwordKH34", Vip = false},
                new Customer{ IdPerson = "customer000035", NamePerson = "Carlos Perez", Phone = "(627) 892-3474", Address = "Farmland, Indiana(IN), 47340", Gender = true, Birth = new DateTime(2012,8,19), Username = "usernameKH35", Password = "passwordKH35", Vip = true},
                new Customer{ IdPerson = "customer000036", NamePerson = "Carolyn Jones", Phone = "(711) 840-4611", Address = "Forrest City, Arkansas(AR), 72335", Gender = true, Birth = new DateTime(1995,11,4), Username = "usernameKH36", Password = "passwordKH36", Vip = true},
                new Customer{ IdPerson = "customer000037", NamePerson = "Nicole Rivera", Phone = "(930) 893-7833", Address = "Lindsborg, Kansas(KS), 67456", Gender = true, Birth = new DateTime(2014,8,9), Username = "usernameKH37", Password = "passwordKH37", Vip = true},
                new Customer{ IdPerson = "customer000038", NamePerson = "Sandra Sanchez", Phone = "(462) 985-4537", Address = "San Benito, Texas(TX), 78586", Gender = true, Birth = new DateTime(2009,6,8), Username = "usernameKH38", Password = "passwordKH38", Vip = false},
                new Customer{ IdPerson = "customer000039", NamePerson = "Jack Patterson", Phone = "(604) 887-4768", Address = "Manning, South Carolina(SC), 29102", Gender = true, Birth = new DateTime(1994,12,30), Username = "usernameKH39", Password = "passwordKH39", Vip = true},
                new Customer{ IdPerson = "customer000040", NamePerson = "Frances Davis", Phone = "(394) 200-1908", Address = "Arthurdale, West Virginia(WV), 26520", Gender = true, Birth = new DateTime(2000,10,19), Username = "usernameKH40", Password = "passwordKH40", Vip = false},
                new Customer{ IdPerson = "customer000041", NamePerson = "Louise Turner", Phone = "(962) 268-3986", Address = "Wetumpka, Alabama(AL), 36092", Gender = true, Birth = new DateTime(1993,10,26), Username = "usernameKH41", Password = "passwordKH41", Vip = false},
                new Customer{ IdPerson = "customer000042", NamePerson = "Susan Murphy", Phone = "(450) 946-2777", Address = "Augusta, Georgia(GA), 30907", Gender = false, Birth = new DateTime(2012,4,8), Username = "usernameKH42", Password = "passwordKH42", Vip = false},
                new Customer{ IdPerson = "customer000043", NamePerson = "Carol Bryant", Phone = "(684) 535-0598", Address = "Van Alstyne, Texas(TX), 75495", Gender = false, Birth = new DateTime(1994,5,27), Username = "usernameKH43", Password = "passwordKH43", Vip = false},
                new Customer{ IdPerson = "customer000044", NamePerson = "Diana Rogers", Phone = "(709) 835-7739", Address = "Mound, Minnesota(MN), 55364", Gender = false, Birth = new DateTime(2017,8,25), Username = "usernameKH44", Password = "passwordKH44", Vip = true},
                new Customer{ IdPerson = "customer000045", NamePerson = "Jose Diaz", Phone = "(571) 379-0249", Address = "Ridgway, Pennsylvania(PA), 15853", Gender = false, Birth = new DateTime(2019,6,12), Username = "usernameKH45", Password = "passwordKH45", Vip = true},
                new Customer{ IdPerson = "customer000046", NamePerson = "Lori Parker", Phone = "(514) 712-7021", Address = "Stratford, Connecticut(CT), 06615", Gender = false, Birth = new DateTime(2012,4,28), Username = "usernameKH46", Password = "passwordKH46", Vip = true},
            });
            context.Employees.AddRange(new[]
            {
                new Employee{ IdPerson = "employee000001", NamePerson = "An Tuấn Chương", Phone = "0855553817", Address = "Camden, New Jersey(NJ)", Gender = true, Birth = new DateTime(1978, 12, 23), Username = "usernameNV1", Password = "passwordNV1", Shift = 1, Wage = 3500000},
                new Employee{ IdPerson = "employee000002", NamePerson = "Bành Ðức Kiên", Phone = "0146895622", Address = "Danbury, Connecticut(CT)", Gender = true, Birth = new DateTime(1970, 03, 03), Username = "usernameNV2", Password = "passwordNV2", Shift = 1, Wage = 2500000},
                new Employee{ IdPerson = "employee000003", NamePerson = "Khổng Hoàng Hiệp", Phone = "0229212537", Address = "Rainbow City, Alabama(AL)", Gender = true, Birth = new DateTime(1940, 08, 13), Username = "usernameNV3", Password = "passwordNV3",  Shift = 1, Wage = 1500000},
                new Employee{ IdPerson = "employee000004", NamePerson = "Cống Quang Huy", Phone = "0433745873", Address = "Taunton, Massachusetts(MA)", Gender = false, Birth = new DateTime(1983, 02, 25), Username = "usernameNV4", Password = "passwordNV4",  Shift = 1, Wage = 6000000},
                new Employee{ IdPerson = "employee000005", NamePerson = "Phùng Hải Nam", Phone = "0748609148", Address = "Freeburg, Illinois(IL)", Gender = false, Birth = new DateTime(1993, 03, 14), Username = "usernameNV5", Password = "passwordNV5",  Shift = 2, Wage = 6000000},
                new Employee{ IdPerson = "employee000006", NamePerson = "Ứng Huy Phong", Phone = "0311557546", Address = "Lutz, Florida(FL)", Gender = true, Birth = new DateTime(1977, 12, 25), Username = "usernameNV6", Password = "passwordNV6", Shift = 2, Wage = 1500000},
                new Employee{ IdPerson = "employee000007", NamePerson = "Amber Ho", Phone = "774-306-5874", Address = "Reno, Nevada(NV), 89521", Gender = true, Birth = new DateTime(2006,4,23), Username = "usernameNV7", Password = "passwordNV7", Shift = 2, Wage = 7500000},
                new Employee{ IdPerson = "employee000008", NamePerson = "Cecilia Underwood", Phone = "760-619-8315", Address = "Glen Ellyn, Illinois(IL), 60137", Gender = true, Birth = new DateTime(1992,1,5), Username = "usernameNV8", Password = "passwordNV8", Shift = 2, Wage = 1500000},
                new Employee{ IdPerson = "employee000009", NamePerson = "Marilyn Moses", Phone = "650-213-1423", Address = "Homer, Georgia(GA), 30547", Gender = true, Birth = new DateTime(2001,1,22), Username = "usernameNV9", Password = "passwordNV9", Shift = 1, Wage = 1500000},
                new Employee{ IdPerson = "employee000010", NamePerson = "Jared Buchanan", Phone = "440-503-2583", Address = "Hinesville, Georgia(GA), 31313", Gender = false, Birth = new DateTime(2007,2,12), Username = "usernameNV10", Password = "passwordNV10", Shift = 1, Wage = 6000000},
                new Employee{ IdPerson = "employee000011", NamePerson = "Kason Spencer", Phone = "860-873-1299", Address = "Winchester, Kansas(KS), 66097", Gender = false, Birth = new DateTime(2020,12,6), Username = "usernameNV11", Password = "passwordNV11", Shift = 1, Wage = 2500000},
                new Employee{ IdPerson = "employee000012", NamePerson = "Malcolm Smith", Phone = "626-297-7724", Address = "Fremont, North Carolina(NC), 27830", Gender = false, Birth = new DateTime(1992,7,1), Username = "usernameNV12", Password = "passwordNV12", Shift = 2, Wage = 7500000},
                new Employee{ IdPerson = "employee000013", NamePerson = "Isai Blanchard", Phone = "314-753-6326", Address = "Trumansburg, New York(NY), 14886", Gender = true, Birth = new DateTime(2006,11,27), Username = "usernameNV13", Password = "passwordNV13", Shift = 2, Wage = 7500000},
                new Employee{ IdPerson = "employee000014", NamePerson = "Paxton Braun", Phone = "408-696-4670", Address = "Warsaw, Kentucky(KY), 41095", Gender = true, Birth = new DateTime(2007,6,26), Username = "usernameNV14", Password = "passwordNV14", Shift = 1, Wage = 1500000},
                new Employee{ IdPerson = "employee000015", NamePerson = "Chana Cabrera", Phone = "570-233-8780", Address = "Decatur, Georgia(GA), 30032", Gender = false, Birth = new DateTime(2001,6,22), Username = "usernameNV15", Password = "passwordNV15", Shift = 2, Wage = 6000000},
            });
            context.Orders.AddRange(new[]
            {
                new Order{IdOrder = "order00000001", IdCustomer = "customer000001", TimeOrder = new DateTime(2022,2,7,14,25,00), Code = "awesome"},
                new Order{IdOrder = "order00000002", IdCustomer = "customer000002", TimeOrder = new DateTime(2022,2,7,16,25,00), Code = "blackday"},
                new Order{IdOrder = "order00000003", IdCustomer = "customer000003", TimeOrder = new DateTime(2022,2,7,12,30,00), Code = "standard"},
                new Order{IdOrder = "order00000004", IdCustomer = "customer000004", TimeOrder = new DateTime(2022,2,7,11,45,00), Code = "momo"},
                new Order{IdOrder = "order00000005", IdCustomer = "customer000005", TimeOrder = new DateTime(2022,2,7,18,30,00), Code = "shinan"},
                new Order{IdOrder = "order00000006", IdCustomer = "customer000006", TimeOrder = new DateTime(2022,2,7,19,45,00), Code = "badman"},
            });
            context.PopcornDrinkOrders.AddRange(new[]
            {
                new PopcornDrinkOrder{IdPopcornDrinkOrder = "pdorder00000001", IdOrder = "order00000001", NamePopcornDrink = "Bap size S", PopcornDrinkPrice = 10000, Quantity = 2},
                new PopcornDrinkOrder{IdPopcornDrinkOrder = "pdorder00000002", IdOrder = "order00000001", NamePopcornDrink = "Pepsi size L", PopcornDrinkPrice = 20000, Quantity = 1},
                new PopcornDrinkOrder{IdPopcornDrinkOrder = "pdorder00000003", IdOrder = "order00000002", NamePopcornDrink = "Bap size L", PopcornDrinkPrice = 20000, Quantity = 2},
                new PopcornDrinkOrder{IdPopcornDrinkOrder = "pdorder00000004", IdOrder = "order00000002", NamePopcornDrink = "Pepsi size M", PopcornDrinkPrice = 18000, Quantity = 1},
                new PopcornDrinkOrder{IdPopcornDrinkOrder = "pdorder00000005", IdOrder = "order00000003", NamePopcornDrink = "Bap size S", PopcornDrinkPrice = 10000, Quantity = 2},
                new PopcornDrinkOrder{IdPopcornDrinkOrder = "pdorder00000006", IdOrder = "order00000003", NamePopcornDrink = "Pepsi size M", PopcornDrinkPrice = 10000, Quantity = 1},
                new PopcornDrinkOrder{IdPopcornDrinkOrder = "pdorder00000007", IdOrder = "order00000004", NamePopcornDrink = "Bap size L", PopcornDrinkPrice = 10000, Quantity = 1},
                new PopcornDrinkOrder{IdPopcornDrinkOrder = "pdorder00000008", IdOrder = "order00000004", NamePopcornDrink = "Pepsi size S", PopcornDrinkPrice = 10000, Quantity = 1},
                new PopcornDrinkOrder{IdPopcornDrinkOrder = "pdorder00000009", IdOrder = "order00000005", NamePopcornDrink = "Bap size S", PopcornDrinkPrice = 10000, Quantity = 1},
                new PopcornDrinkOrder{IdPopcornDrinkOrder = "pdorder00000010", IdOrder = "order00000005", NamePopcornDrink = "Pepsi size S", PopcornDrinkPrice = 10000, Quantity = 2},
                new PopcornDrinkOrder{IdPopcornDrinkOrder = "pdorder00000011", IdOrder = "order00000006", NamePopcornDrink = "Bap size M", PopcornDrinkPrice = 10000, Quantity = 2},
                new PopcornDrinkOrder{IdPopcornDrinkOrder = "pdorder00000012", IdOrder = "order00000006", NamePopcornDrink = "Pepsi size M", PopcornDrinkPrice = 10000, Quantity = 1},
            });
            context.TicketOrders.AddRange(new[]
            {
                // 02072022
                new TicketOrder{IdTicketOrder = "ticketorder00000001", IdOrder = "order00000001", IdRoom = "room02",Time = new DateTime(2022,7,2,9,30,00),SeatPurchased = "A0"},
                new TicketOrder{IdTicketOrder = "ticketorder00000002", IdOrder = "order00000002", IdRoom = "room03",Time = new DateTime(2022,7,2,12,20,00),SeatPurchased = "A1"},
                new TicketOrder{IdTicketOrder = "ticketorder00000003", IdOrder = "order00000003", IdRoom = "room04",Time = new DateTime(2022,7,2,22,00,00),SeatPurchased = "B5"},
                new TicketOrder{IdTicketOrder = "ticketorder00000004", IdOrder = "order00000004", IdRoom = "room02",Time = new DateTime(2022,7,2,11,20,00),SeatPurchased = "C0"},
                new TicketOrder{IdTicketOrder = "ticketorder00000005", IdOrder = "order00000005", IdRoom = "room05",Time = new DateTime(2022,7,2,13,30,00),SeatPurchased = "C2"},
                new TicketOrder{IdTicketOrder = "ticketorder00000006", IdOrder = "order00000006", IdRoom = "room01",Time = new DateTime(2022,7,2,15,20,00),SeatPurchased = "C3"},
            });
            context.ShowTimes.AddRange(new[]
            {
                // 03/07/2022
                new ShowTime{IdMovie = "movie000001", IdRoom = "room02", Seat = "00000000000000000000000000000000000000000000000000000000000000000000000000000000", Time = new DateTime(2022,7,3,9,10,00), TicketPrice = 125000},
                new ShowTime{IdMovie = "movie000001", IdRoom = "room02", Seat = "00000000000000000000000000000000000000000000000000000000000000000000000000000000", Time = new DateTime(2022,7,3,11,00,00), TicketPrice = 125000},
                new ShowTime{IdMovie = "movie000001", IdRoom = "room02", Seat = "00000000000000000000000000000000000000000000000000000000000000000000000000000000", Time = new DateTime(2022,7,3,12,50,00), TicketPrice = 125000},
                new ShowTime{IdMovie = "movie000001", IdRoom = "room02", Seat = "00000000000000000000000000000000000000000000000000000000000000000000000000000000", Time = new DateTime(2022,7,3,14,45,00), TicketPrice = 125000},
                new ShowTime{IdMovie = "movie000001", IdRoom = "room02", Seat = "00000000000000000000000000000000000000000000000000000000000000000000000000000000", Time = new DateTime(2022,7,3,16,40,00), TicketPrice = 125000},
                new ShowTime{IdMovie = "movie000001", IdRoom = "room02", Seat = "00000000000000000000000000000000000000000000000000000000000000000000000000000000", Time = new DateTime(2022,7,3,18,30,00), TicketPrice = 125000},
                new ShowTime{IdMovie = "movie000001", IdRoom = "room03", Seat = "00000000000000000000000000000000000000000000000000000000000000000000000000000000", Time = new DateTime(2022,7,3,19,10,00), TicketPrice = 125000},
                new ShowTime{IdMovie = "movie000001", IdRoom = "room04", Seat = "00000000000000000000000000000000000000000000000000000000000000000000000000000000", Time = new DateTime(2022,7,3,10,10,00), TicketPrice = 125000},
                new ShowTime{IdMovie = "movie000001", IdRoom = "room04", Seat = "00000000000000000000000000000000000000000000000000000000000000000000000000000000", Time = new DateTime(2022,7,3,12,00,00), TicketPrice = 125000},
                new ShowTime{IdMovie = "movie000001", IdRoom = "room04", Seat = "00000000000000000000000000000000000000000000000000000000000000000000000000000000", Time = new DateTime(2022,7,3,13,50,00), TicketPrice = 125000},
                new ShowTime{IdMovie = "movie000001", IdRoom = "room04", Seat = "00000000000000000000000000000000000000000000000000000000000000000000000000000000", Time = new DateTime(2022,7,3,15,40,00), TicketPrice = 125000},
                new ShowTime{IdMovie = "movie000001", IdRoom = "room04", Seat = "00000000000000000000000000000000000000000000000000000000000000000000000000000000", Time = new DateTime(2022,7,3,17,30,00), TicketPrice = 125000},
                new ShowTime{IdMovie = "movie000001", IdRoom = "room02", Seat = "00000000000000000000000000000000000000000000000000000000000000000000000000000000", Time = new DateTime(2022,7,3,20,20,00), TicketPrice = 125000},
                new ShowTime{IdMovie = "movie000001", IdRoom = "room02", Seat = "00000000000000000000000000000000000000000000000000000000000000000000000000000000", Time = new DateTime(2022,7,3,22,10,00), TicketPrice = 125000},

                new ShowTime{IdMovie = "movie000002", IdRoom = "room01", Seat = "00000000000000000000000000000000000000000000000000000000000000000000000000000000", Time = new DateTime(2022,7,3,9,50,00), TicketPrice = 145000},
                new ShowTime{IdMovie = "movie000002", IdRoom = "room05", Seat = "00000000000000000000000000000000000000000000000000000000000000000000000000000000", Time = new DateTime(2022,7,3,10,45,00), TicketPrice = 145000},
                new ShowTime{IdMovie = "movie000002", IdRoom = "room01", Seat = "00000000000000000000000000000000000000000000000000000000000000000000000000000000", Time = new DateTime(2022,7,3,12,30,00), TicketPrice = 145000},
                new ShowTime{IdMovie = "movie000002", IdRoom = "room05", Seat = "00000000000000000000000000000000000000000000000000000000000000000000000000000000", Time = new DateTime(2022,7,3,13,30,00), TicketPrice = 145000},
                new ShowTime{IdMovie = "movie000002", IdRoom = "room01", Seat = "00000000000000000000000000000000000000000000000000000000000000000000000000000000", Time = new DateTime(2022,7,3,15,10,00), TicketPrice = 145000},
                new ShowTime{IdMovie = "movie000002", IdRoom = "room05", Seat = "00000000000000000000000000000000000000000000000000000000000000000000000000000000", Time = new DateTime(2022,7,3,16,10,00), TicketPrice = 145000},
                new ShowTime{IdMovie = "movie000002", IdRoom = "room01", Seat = "00000000000000000000000000000000000000000000000000000000000000000000000000000000", Time = new DateTime(2022,7,3,17,50,00), TicketPrice = 145000},
                new ShowTime{IdMovie = "movie000002", IdRoom = "room05", Seat = "00000000000000000000000000000000000000000000000000000000000000000000000000000000", Time = new DateTime(2022,7,3,18,50,00), TicketPrice = 145000},
                new ShowTime{IdMovie = "movie000002", IdRoom = "room04", Seat = "00000000000000000000000000000000000000000000000000000000000000000000000000000000", Time = new DateTime(2022,7,3,19,20,00), TicketPrice = 145000},
                new ShowTime{IdMovie = "movie000002", IdRoom = "room01", Seat = "00000000000000000000000000000000000000000000000000000000000000000000000000000000", Time = new DateTime(2022,7,3,20,30,00), TicketPrice = 145000},
                new ShowTime{IdMovie = "movie000002", IdRoom = "room05", Seat = "00000000000000000000000000000000000000000000000000000000000000000000000000000000", Time = new DateTime(2022,7,3,21,30,00), TicketPrice = 145000},

                new ShowTime{IdMovie = "movie000003", IdRoom = "room03", Seat = "00000000000000000000000000000000000000000000000000000000000000000000000000000000", Time = new DateTime(2022,7,3,9,30,00), TicketPrice = 110000},
                new ShowTime{IdMovie = "movie000003", IdRoom = "room03", Seat = "00000000000000000000000000000000000000000000000000000000000000000000000000000000", Time = new DateTime(2022,7,3,14,20,00), TicketPrice = 110000},
                new ShowTime{IdMovie = "movie000003", IdRoom = "room03", Seat = "00000000000000000000000000000000000000000000000000000000000000000000000000000000", Time = new DateTime(2022,7,3,21,10,00), TicketPrice = 110000},

                new ShowTime{IdMovie = "movie000004", IdRoom = "room03", Seat = "00000000000000000000000000000000000000000000000000000000000000000000000000000000", Time = new DateTime(2022,7,3,12,15,00), TicketPrice = 195000},
                new ShowTime{IdMovie = "movie000004", IdRoom = "room03", Seat = "00000000000000000000000000000000000000000000000000000000000000000000000000000000", Time = new DateTime(2022,7,3,17,00,00), TicketPrice = 195000},
                new ShowTime{IdMovie = "movie000004", IdRoom = "room04", Seat = "00000000000000000000000000000000000000000000000000000000000000000000000000000000", Time = new DateTime(2022,7,3,19,50,00), TicketPrice = 195000},

                new ShowTime{IdMovie = "movie000005", IdRoom = "room01", Seat = "00000000000000000000000000000000000000000000000000000000000000000000000000000000", Time = new DateTime(2022,7,3,5,30,00), TicketPrice = 170000},
                new ShowTime{IdMovie = "movie000005", IdRoom = "room03", Seat = "00000000000000000000000000000000000000000000000000000000000000000000000000000000", Time = new DateTime(2022,7,3,7,00,00), TicketPrice = 170000},
                new ShowTime{IdMovie = "movie000005", IdRoom = "room05", Seat = "00000000000000000000000000000000000000000000000000000000000000000000000000000000", Time = new DateTime(2022,7,3,6,20,00), TicketPrice = 170000},

                // 04/07/2022

                new ShowTime{IdMovie = "movie000001", IdRoom = "room02", Seat = "00000000000000000000000000000000000000000000000000000000000000000000000000000000", Time = new DateTime(2022,7,4,9,10,00), TicketPrice = 125000},
                new ShowTime{IdMovie = "movie000001", IdRoom = "room02", Seat = "00000000000000000000000000000000000000000000000000000000000000000000000000000000", Time = new DateTime(2022,7,4,11,00,00), TicketPrice = 125000},
                new ShowTime{IdMovie = "movie000001", IdRoom = "room03", Seat = "00000000000000000000000000000000000000000000000000000000000000000000000000000000", Time = new DateTime(2022,7,4,12,20,00), TicketPrice = 125000},
                new ShowTime{IdMovie = "movie000001", IdRoom = "room02", Seat = "00000000000000000000000000000000000000000000000000000000000000000000000000000000", Time = new DateTime(2022,7,4,12,50,00), TicketPrice = 125000},
                new ShowTime{IdMovie = "movie000001", IdRoom = "room02", Seat = "00000000000000000000000000000000000000000000000000000000000000000000000000000000", Time = new DateTime(2022,7,4,14,45,00), TicketPrice = 125000},
                new ShowTime{IdMovie = "movie000001", IdRoom = "room02", Seat = "00000000000000000000000000000000000000000000000000000000000000000000000000000000", Time = new DateTime(2022,7,4,16,40,00), TicketPrice = 125000},
                new ShowTime{IdMovie = "movie000001", IdRoom = "room02", Seat = "00000000000000000000000000000000000000000000000000000000000000000000000000000000", Time = new DateTime(2022,7,4,18,30,00), TicketPrice = 125000},
                new ShowTime{IdMovie = "movie000001", IdRoom = "room03", Seat = "00000000000000000000000000000000000000000000000000000000000000000000000000000000", Time = new DateTime(2022,7,4,19,15,00), TicketPrice = 125000},
                new ShowTime{IdMovie = "movie000001", IdRoom = "room04", Seat = "00000000000000000000000000000000000000000000000000000000000000000000000000000000", Time = new DateTime(2022,7,4,10,10,00), TicketPrice = 125000},
                new ShowTime{IdMovie = "movie000001", IdRoom = "room04", Seat = "00000000000000000000000000000000000000000000000000000000000000000000000000000000", Time = new DateTime(2022,7,4,12,00,00), TicketPrice = 125000},
                new ShowTime{IdMovie = "movie000001", IdRoom = "room04", Seat = "00000000000000000000000000000000000000000000000000000000000000000000000000000000", Time = new DateTime(2022,7,4,13,50,00), TicketPrice = 125000},
                new ShowTime{IdMovie = "movie000001", IdRoom = "room04", Seat = "00000000000000000000000000000000000000000000000000000000000000000000000000000000", Time = new DateTime(2022,7,4,15,40,00), TicketPrice = 125000},
                new ShowTime{IdMovie = "movie000001", IdRoom = "room04", Seat = "00000000000000000000000000000000000000000000000000000000000000000000000000000000", Time = new DateTime(2022,7,4,17,30,00), TicketPrice = 125000},
                new ShowTime{IdMovie = "movie000001", IdRoom = "room02", Seat = "00000000000000000000000000000000000000000000000000000000000000000000000000000000", Time = new DateTime(2022,7,4,20,20,00), TicketPrice = 125000},
                new ShowTime{IdMovie = "movie000001", IdRoom = "room02", Seat = "00000000000000000000000000000000000000000000000000000000000000000000000000000000", Time = new DateTime(2022,7,4,22,10,00), TicketPrice = 125000},

                new ShowTime{IdMovie = "movie000002", IdRoom = "room01", Seat = "00000000000000000000000000000000000000000000000000000000000000000000000000000000", Time = new DateTime(2022,7,4,9,50,00), TicketPrice = 145000},
                new ShowTime{IdMovie = "movie000002", IdRoom = "room05", Seat = "00000000000000000000000000000000000000000000000000000000000000000000000000000000", Time = new DateTime(2022,7,4,10,45,00), TicketPrice = 145000},
                new ShowTime{IdMovie = "movie000002", IdRoom = "room01", Seat = "00000000000000000000000000000000000000000000000000000000000000000000000000000000", Time = new DateTime(2022,7,4,12,30,00), TicketPrice = 145000},
                new ShowTime{IdMovie = "movie000002", IdRoom = "room05", Seat = "00000000000000000000000000000000000000000000000000000000000000000000000000000000", Time = new DateTime(2022,7,4,13,30,00), TicketPrice = 145000},
                new ShowTime{IdMovie = "movie000002", IdRoom = "room01", Seat = "00000000000000000000000000000000000000000000000000000000000000000000000000000000", Time = new DateTime(2022,7,4,15,10,00), TicketPrice = 145000},
                new ShowTime{IdMovie = "movie000002", IdRoom = "room05", Seat = "00000000000000000000000000000000000000000000000000000000000000000000000000000000", Time = new DateTime(2022,7,4,16,10,00), TicketPrice = 145000},
                new ShowTime{IdMovie = "movie000002", IdRoom = "room01", Seat = "00000000000000000000000000000000000000000000000000000000000000000000000000000000", Time = new DateTime(2022,7,4,17,50,00), TicketPrice = 145000},
                new ShowTime{IdMovie = "movie000002", IdRoom = "room05", Seat = "00000000000000000000000000000000000000000000000000000000000000000000000000000000", Time = new DateTime(2022,7,4,18,50,00), TicketPrice = 145000},
                new ShowTime{IdMovie = "movie000002", IdRoom = "room04", Seat = "00000000000000000000000000000000000000000000000000000000000000000000000000000000", Time = new DateTime(2022,7,4,19,20,00), TicketPrice = 145000},
                new ShowTime{IdMovie = "movie000002", IdRoom = "room01", Seat = "00000000000000000000000000000000000000000000000000000000000000000000000000000000", Time = new DateTime(2022,7,4,20,30,00), TicketPrice = 145000},
                new ShowTime{IdMovie = "movie000002", IdRoom = "room05", Seat = "00000000000000000000000000000000000000000000000000000000000000000000000000000000", Time = new DateTime(2022,7,4,21,30,00), TicketPrice = 145000},

                new ShowTime{IdMovie = "movie000003", IdRoom = "room03", Seat = "00000000000000000000000000000000000000000000000000000000000000000000000000000000", Time = new DateTime(2022,7,4,9,30,00), TicketPrice = 110000},
                new ShowTime{IdMovie = "movie000003", IdRoom = "room03", Seat = "00000000000000000000000000000000000000000000000000000000000000000000000000000000", Time = new DateTime(2022,7,4,14,20,00), TicketPrice = 110000},
                new ShowTime{IdMovie = "movie000003", IdRoom = "room03", Seat = "00000000000000000000000000000000000000000000000000000000000000000000000000000000", Time = new DateTime(2022,7,4,21,10,00), TicketPrice = 110000},

                new ShowTime{IdMovie = "movie000004", IdRoom = "room03", Seat = "00000000000000000000000000000000000000000000000000000000000000000000000000000000", Time = new DateTime(2022,7,4,17,00,00), TicketPrice = 195000},
                new ShowTime{IdMovie = "movie000004", IdRoom = "room04", Seat = "00000000000000000000000000000000000000000000000000000000000000000000000000000000", Time = new DateTime(2022,7,4,22,00,00), TicketPrice = 195000},

                new ShowTime{IdMovie = "movie000005", IdRoom = "room01", Seat = "00000000000000000000000000000000000000000000000000000000000000000000000000000000", Time = new DateTime(2022,7,4,5,30,00), TicketPrice = 170000},
                new ShowTime{IdMovie = "movie000005", IdRoom = "room03", Seat = "00000000000000000000000000000000000000000000000000000000000000000000000000000000", Time = new DateTime(2022,7,4,6,20,00), TicketPrice = 170000},
                new ShowTime{IdMovie = "movie000005", IdRoom = "room05", Seat = "00000000000000000000000000000000000000000000000000000000000000000000000000000000", Time = new DateTime(2022,7,4,7,00,00), TicketPrice = 170000},
                // 02/07/2022
                new ShowTime{IdMovie = "movie000001", IdRoom = "room02", Seat = "10000000000000000000000000000000000000000000000000000000000000000000000000000000", Time = new DateTime(2022,7,2,9,30,00), TicketPrice = 125000},
                new ShowTime{IdMovie = "movie000001", IdRoom = "room03", Seat = "01000000000000000000000000000000000000000000000000000000000000000000000000000000", Time = new DateTime(2022,7,2,12,20,00), TicketPrice = 125000},
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
                new ShowTime{IdMovie = "movie000001", IdRoom = "room04", Seat = "00000000000001000000000000000000000000000000000000000000000000000000000000000000", Time = new DateTime(2022,7,2,22,00,00), TicketPrice = 125000},

                new ShowTime{IdMovie = "movie000002", IdRoom = "room01", Seat = "00000000000000000000000000000000000000000000000000000000000000000000000000000000", Time = new DateTime(2022,7,2,10,00,00), TicketPrice = 145000},
                new ShowTime{IdMovie = "movie000002", IdRoom = "room05", Seat = "00000000000000000000000000000000000000000000000000000000000000000000000000000000", Time = new DateTime(2022,7,2,10,45,00), TicketPrice = 145000},
                new ShowTime{IdMovie = "movie000002", IdRoom = "room02", Seat = "00000000000000001000000000000000000000000000000000000000000000000000000000000000", Time = new DateTime(2022,7,2,11,20,00), TicketPrice = 145000},
                new ShowTime{IdMovie = "movie000002", IdRoom = "room01", Seat = "00000000000000000000000000000000000000000000000000000000000000000000000000000000", Time = new DateTime(2022,7,2,12,40,00), TicketPrice = 145000},
                new ShowTime{IdMovie = "movie000002", IdRoom = "room05", Seat = "00000000000000000010000000000000000000000000000000000000000000000000000000000000", Time = new DateTime(2022,7,2,13,30,00), TicketPrice = 145000},
                new ShowTime{IdMovie = "movie000002", IdRoom = "room01", Seat = "00000000000000000001000000000000000000000000000000000000000000000000000000000000", Time = new DateTime(2022,7,2,15,20,00), TicketPrice = 145000},
                new ShowTime{IdMovie = "movie000002", IdRoom = "room05", Seat = "00000000000000000000000000000000000000000000000000000000000000000000000000000000", Time = new DateTime(2022,7,2,16,10,00), TicketPrice = 145000},
                new ShowTime{IdMovie = "movie000002", IdRoom = "room04", Seat = "00000000000000000000000000000000000000000000000000000000000000000000000000000000", Time = new DateTime(2022,7,2,17,30,00), TicketPrice = 145000},
                new ShowTime{IdMovie = "movie000002", IdRoom = "room01", Seat = "00000000000000000000000000000000000000000000000000000000000000000000000000000000", Time = new DateTime(2022,7,2,18,00,00), TicketPrice = 145000},
                new ShowTime{IdMovie = "movie000002", IdRoom = "room05", Seat = "00000000000000000000000000000000000000000000000000000000000000000000000000000000", Time = new DateTime(2022,7,2,18,50,00), TicketPrice = 145000},
                new ShowTime{IdMovie = "movie000002", IdRoom = "room01", Seat = "00000000000000000000000000000000000000000000000000000000000000000000000000000000", Time = new DateTime(2022,7,2,20,40,00), TicketPrice = 145000},
                new ShowTime{IdMovie = "movie000002", IdRoom = "room05", Seat = "00000000000000000000000000000000000000000000000000000000000000000000000000000000", Time = new DateTime(2022,7,2,21,30,00), TicketPrice = 145000},

                new ShowTime{IdMovie = "movie000003", IdRoom = "room03", Seat = "00000000000000000000000000000000000000000000000000000000000000000000000000000000", Time = new DateTime(2022,7,2,6,30,00), TicketPrice = 110000},
                new ShowTime{IdMovie = "movie000003", IdRoom = "room03", Seat = "00000000000000000000000000000000000000000000000000000000000000000000000000000000", Time = new DateTime(2022,7,2,9,30,00), TicketPrice = 110000},
                new ShowTime{IdMovie = "movie000003", IdRoom = "room03", Seat = "00000000000000000000000000000000000000000000000000000000000000000000000000000000", Time = new DateTime(2022,7,2,20,20,00), TicketPrice = 110000},

                new ShowTime{IdMovie = "movie000004", IdRoom = "room04", Seat = "00000000000000000000000000000000000000000000000000000000000000000000000000000000", Time = new DateTime(2022,7,2,5,25,00), TicketPrice = 195000},
                new ShowTime{IdMovie = "movie000004", IdRoom = "room04", Seat = "00000000000000000000000000000000000000000000000000000000000000000000000000000000", Time = new DateTime(2022,7,2,19,50,00), TicketPrice = 195000},

                new ShowTime{IdMovie = "movie000005", IdRoom = "room01", Seat = "00000000000000000000000000000000000000000000000000000000000000000000000000000000", Time = new DateTime(2022,7,2,07,15,00), TicketPrice = 170000},
                new ShowTime{IdMovie = "movie000005", IdRoom = "room02", Seat = "00000000000000000000000000000000000000000000000000000000000000000000000000000000", Time = new DateTime(2022,7,2,5,25,00), TicketPrice = 170000},
                new ShowTime{IdMovie = "movie000005", IdRoom = "room05", Seat = "00000000000000000000000000000000000000000000000000000000000000000000000000000000", Time = new DateTime(2022,7,2,6,30,00), TicketPrice = 170000},


                // 05/07/2022
                new ShowTime{IdMovie = "movie000001", IdRoom = "room02", Seat = "00000000000000000000000000000000000000000000000000000000000000000000000000000000", Time = new DateTime(2022,7,5,9,10,00), TicketPrice = 125000},
                new ShowTime{IdMovie = "movie000001", IdRoom = "room02", Seat = "00000000000000000000000000000000000000000000000000000000000000000000000000000000", Time = new DateTime(2022,7,5,11,00,00), TicketPrice = 125000},
                new ShowTime{IdMovie = "movie000001", IdRoom = "room02", Seat = "00000000000000000000000000000000000000000000000000000000000000000000000000000000", Time = new DateTime(2022,7,5,12,50,00), TicketPrice = 125000},
                new ShowTime{IdMovie = "movie000001", IdRoom = "room02", Seat = "00000000000000000000000000000000000000000000000000000000000000000000000000000000", Time = new DateTime(2022,7,5,14,45,00), TicketPrice = 125000},
                new ShowTime{IdMovie = "movie000001", IdRoom = "room02", Seat = "00000000000000000000000000000000000000000000000000000000000000000000000000000000", Time = new DateTime(2022,7,5,16,40,00), TicketPrice = 125000},
                new ShowTime{IdMovie = "movie000001", IdRoom = "room02", Seat = "00000000000000000000000000000000000000000000000000000000000000000000000000000000", Time = new DateTime(2022,7,5,18,30,00), TicketPrice = 125000},
                new ShowTime{IdMovie = "movie000001", IdRoom = "room03", Seat = "00000000000000000000000000000000000000000000000000000000000000000000000000000000", Time = new DateTime(2022,7,5,19,30,00), TicketPrice = 125000},
                new ShowTime{IdMovie = "movie000001", IdRoom = "room03", Seat = "00000000000000000000000000000000000000000000000000000000000000000000000000000000", Time = new DateTime(2022,7,5,10,00,00), TicketPrice = 125000},
                new ShowTime{IdMovie = "movie000001", IdRoom = "room04", Seat = "00000000000000000000000000000000000000000000000000000000000000000000000000000000", Time = new DateTime(2022,7,5,12,00,00), TicketPrice = 125000},
                new ShowTime{IdMovie = "movie000001", IdRoom = "room04", Seat = "00000000000000000000000000000000000000000000000000000000000000000000000000000000", Time = new DateTime(2022,7,5,13,50,00), TicketPrice = 125000},
                new ShowTime{IdMovie = "movie000001", IdRoom = "room04", Seat = "00000000000000000000000000000000000000000000000000000000000000000000000000000000", Time = new DateTime(2022,7,5,15,40,00), TicketPrice = 125000},
                new ShowTime{IdMovie = "movie000001", IdRoom = "room04", Seat = "00000000000000000000000000000000000000000000000000000000000000000000000000000000", Time = new DateTime(2022,7,5,17,30,00), TicketPrice = 125000},
                new ShowTime{IdMovie = "movie000001", IdRoom = "room02", Seat = "00000000000000000000000000000000000000000000000000000000000000000000000000000000", Time = new DateTime(2022,7,5,20,20,00), TicketPrice = 125000},
                new ShowTime{IdMovie = "movie000001", IdRoom = "room03", Seat = "00000000000000000000000000000000000000000000000000000000000000000000000000000000", Time = new DateTime(2022,7,5,21,20,00), TicketPrice = 125000},
                new ShowTime{IdMovie = "movie000001", IdRoom = "room02", Seat = "00000000000000000000000000000000000000000000000000000000000000000000000000000000", Time = new DateTime(2022,7,5,22,10,00), TicketPrice = 125000},

                new ShowTime{IdMovie = "movie000002", IdRoom = "room04", Seat = "00000000000000000000000000000000000000000000000000000000000000000000000000000000", Time = new DateTime(2022,7,5,9,15,00), TicketPrice = 145000},
                new ShowTime{IdMovie = "movie000002", IdRoom = "room01", Seat = "00000000000000000000000000000000000000000000000000000000000000000000000000000000", Time = new DateTime(2022,7,5,9,50,00), TicketPrice = 145000},
                new ShowTime{IdMovie = "movie000002", IdRoom = "room05", Seat = "00000000000000000000000000000000000000000000000000000000000000000000000000000000", Time = new DateTime(2022,7,5,10,45,00), TicketPrice = 145000},
                new ShowTime{IdMovie = "movie000002", IdRoom = "room01", Seat = "00000000000000000000000000000000000000000000000000000000000000000000000000000000", Time = new DateTime(2022,7,5,12,30,00), TicketPrice = 145000},
                new ShowTime{IdMovie = "movie000002", IdRoom = "room05", Seat = "00000000000000000000000000000000000000000000000000000000000000000000000000000000", Time = new DateTime(2022,7,5,13,30,00), TicketPrice = 145000},
                new ShowTime{IdMovie = "movie000002", IdRoom = "room01", Seat = "00000000000000000000000000000000000000000000000000000000000000000000000000000000", Time = new DateTime(2022,7,5,15,10,00), TicketPrice = 145000},
                new ShowTime{IdMovie = "movie000002", IdRoom = "room05", Seat = "00000000000000000000000000000000000000000000000000000000000000000000000000000000", Time = new DateTime(2022,7,5,16,10,00), TicketPrice = 145000},
                new ShowTime{IdMovie = "movie000002", IdRoom = "room01", Seat = "00000000000000000000000000000000000000000000000000000000000000000000000000000000", Time = new DateTime(2022,7,5,17,50,00), TicketPrice = 145000},
                new ShowTime{IdMovie = "movie000002", IdRoom = "room05", Seat = "00000000000000000000000000000000000000000000000000000000000000000000000000000000", Time = new DateTime(2022,7,5,18,50,00), TicketPrice = 145000},
                new ShowTime{IdMovie = "movie000002", IdRoom = "room04", Seat = "00000000000000000000000000000000000000000000000000000000000000000000000000000000", Time = new DateTime(2022,7,5,19,20,00), TicketPrice = 145000},
                new ShowTime{IdMovie = "movie000002", IdRoom = "room01", Seat = "00000000000000000000000000000000000000000000000000000000000000000000000000000000", Time = new DateTime(2022,7,5,20,30,00), TicketPrice = 145000},
                new ShowTime{IdMovie = "movie000002", IdRoom = "room05", Seat = "00000000000000000000000000000000000000000000000000000000000000000000000000000000", Time = new DateTime(2022,7,5,21,30,00), TicketPrice = 145000},

                new ShowTime{IdMovie = "movie000003", IdRoom = "room03", Seat = "00000000000000000000000000000000000000000000000000000000000000000000000000000000", Time = new DateTime(2022,7,5,11,50,00), TicketPrice = 110000},
                new ShowTime{IdMovie = "movie000003", IdRoom = "room03", Seat = "00000000000000000000000000000000000000000000000000000000000000000000000000000000", Time = new DateTime(2022,7,5,16,45,00), TicketPrice = 110000},

                new ShowTime{IdMovie = "movie000004", IdRoom = "room04", Seat = "00000000000000000000000000000000000000000000000000000000000000000000000000000000", Time = new DateTime(2022,7,5,6,30,00), TicketPrice = 195000},
                new ShowTime{IdMovie = "movie000004", IdRoom = "room03", Seat = "00000000000000000000000000000000000000000000000000000000000000000000000000000000", Time = new DateTime(2022,7,5,14,30,00), TicketPrice = 195000},

                new ShowTime{IdMovie = "movie000005", IdRoom = "room04", Seat = "00000000000000000000000000000000000000000000000000000000000000000000000000000000", Time = new DateTime(2022,7,5,22,00,00), TicketPrice = 170000},
            });
            context.Movies.AddRange(new[]
            {
                new Movie{IdMovie = "movie000001",NameMovie = "MINIONS: SỰ TRỖI DẬY CỦA GRU", Actor = "Steve Carell, Pierre Coffin, Russell Brand, Alan Arkin, Taraji P. Henson", Director = "Kyle Balda", Description = "Rất lâu trước khi trở thành một phản diện chuyên nghiệp, Gru chỉ là một cậu bé 12 tuổi sống ở vùng ngoại ô vào những năm 1970, với ước mơ một ngày sẽ làm “bá chủ” thế giới. Và 3 “quả chuối” vàng biết đi từ trên trời rơi xuống đã là những đồng đội đầu tiên của Gru, bên cạnh ủng hộ cậu bé, cùng nhau thiết kế những vũ khí đầu tiên, thực hiện những phi vụ đầu tiên.", Category = "Comedy, Action, Adventure, Animation, Family", Duration = new TimeSpan(2, 30, 20), Rate = 5.0, ReleaseDate = DateTime.Now, LinkTrailer = "https://www.youtube.com/watch?v=_12FEKaq2Vw"},
                new Movie{IdMovie = "movie000002",NameMovie = "Sát Thủ Nhân Tạo 2: Mẫu Vật Còn Lại", Actor = "Shin Si-a, Park Eun-bin, Seo Eun-su, Jin Goo, Seong Yu-bin", Director = "Park Hoon-Jung", Description = "Lợi dụng sự cố kinh hoàng tại cơ sở thí nghiệm, cô nàng 17 tuổi mang bí danh ARK-ADP1, một nữ sát thủ nhân tạo có siêu năng lực, đã thoát được ra ngoài. Cô bị những người tạo ra mình lẫn các thế lực bí ẩn khác truy bắt gắt gao.", Category = "Action, Mystery, Thriller", Duration = new TimeSpan(2, 30, 20), Rate = 3.5, ReleaseDate = DateTime.Now, LinkTrailer = "https://www.youtube.com/watch?v=Xl3ccrJBvSs"},
                new Movie{IdMovie = "movie000003",NameMovie = "Em và Trịnh", Actor = "Trần Lực, Avin Lu, Lan Thy, Hoàng Hà, Bùi Lan Hương", Director = "Phan Gia Nhật Linh", Description = "Phim điện ảnh Em và Trịnh kể về cuộc đời của nhạc sĩ Trịnh Công Sơn từ khi còn trẻ đến tuổi trung niên, khi ông hoài niệm về những nàng thơ trong cuộc đời mình: Bích Diễm, Dao Ánh, Khánh Ly, Hồng Nhung...", Category = "Drama, Musical", Duration = new TimeSpan(3, 30, 20), Rate = 4.0, ReleaseDate = DateTime.Now, LinkTrailer = "https://www.youtube.com/watch?v=IosqnBOkk2I"},
                new Movie{IdMovie = "movie000004",NameMovie = "Điện Thoại Đen",Actor = "Mason Thames, Madeleine McGraw, Jeremy Davies, Ethan Hawke, James Ransone", Director = "Scott Derrickson", Description = "Siêu phẩm kinh dị mới nhất của nhà Blumhouse hợp tác sản xuất cùng đạo diễn \"Doctor Strange\". Dựa trên tác phẩm truyện ngắn cùng tên của Joe Hill, bộ phim theo chân Finney Shaw, một cậu bé 13 tuổi dù rất thông minh nhưng lại có tính cách nhút nhát, hay sợ người lạ. Vào một ngày nọ, Finney bị một kẻ giết người tàn bạo bắt cóc và bị mắc kẹt trong tầng hầm cách âm. Trong lúc cậu nhóc tìm mọi cách kêu cứu nhưng không thể, bỗng một chiếc điện thoại vốn đã bị ngắt kết nối từ lâu bắt đầu đổ chuông, Finney phát hiện ra rằng cậu có thể nghe thấy giọng nói của những \"nạn nhân\" trước đó. Và dường như họ đang cố gắng giúp Finney để những gì đã xảy ra với họ sẽ không xảy ra với cậu bé.", Category = "Horror", Duration = new TimeSpan(2, 10, 20), Rate = 3.5, ReleaseDate = DateTime.Now, LinkTrailer = "https://www.youtube.com/watch?v=A-iDBvW7SdY"},
                new Movie{IdMovie = "movie000005",NameMovie = "Ma Gương 3",Actor = "Nicole Rossi, Andryan Bima, Ali Fikry, Ciara Nadine Brosnan, Adlu Fahrezy", Director = "Rizal Mantovani", Description = "Dinda sau khi cùng gia đình mình đánh đuổi quỷ dữ về địa ngục, sức mạnh của cô bé dần trở nên mất kiểm soát gây tổn thương cho mọi người. Liệu con quỷ thực sự đã biến mất hay trú ẩn bên trong cô bé đợi ngày trở lại?", Category = "Horror", Duration = new TimeSpan(1, 30, 20), Rate = 2.9, ReleaseDate = DateTime.Now, LinkTrailer = "https://www.youtube.com/watch?v=q_qhLbD5oo8"},
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
