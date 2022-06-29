using System;
using System.Data.Entity;
using System.Linq;
using PBL3.DTO.DTO_Order;
using PBL3.DTO.DTO_Person;
using PBL3.DTO.DTO_PopcornDrink;
using PBL3.DTO.DTO_ShowTime;

namespace PBL3.EntityFramework
{
    public class QLRapChieuPhim : DbContext
    {
        public QLRapChieuPhim()
            : base("name=QLRapChieuPhim")
        {
            Database.SetInitializer<QLRapChieuPhim>(new CreateDB());
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
        public virtual DbSet<Admin> Admins { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<PopcornDrinkOrder> PopcornDrinkOrders { get; set; }
        public virtual DbSet<TicketOrder> TicketOrders { get; set; }
        public virtual DbSet<PopcornDrink> PopcornDrinks { get; set; }
        public virtual DbSet<Movie> Movies { get; set; }
        public virtual DbSet<Room> Rooms { get; set; }
        public virtual DbSet<ShowTime> ShowTimes { get; set; }
    }
}