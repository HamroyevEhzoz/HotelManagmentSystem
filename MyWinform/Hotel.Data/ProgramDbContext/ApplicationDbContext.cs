using Hotel.Data.Configurations;
using Hotel_Domain.Models.Orders;
using Hotel_Domain.Models.Rooms;
using Hotel_Domain.Models.Users;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Data.ProgramDbContext
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<User> Users => Set<User>();

        public DbSet<Room> Rooms => Set<Room>();

        public DbSet<Order> Orders => Set<Order>();



      /* protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
       {
            optionsBuilder.UseNpgsql("Server=127.0.0.1;Port=8888;Database=Hotel;User Id=postgres;Password=ehzoz9910;");
       }*/

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options){ }
       
       protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new OrderTypeConfiguration());
            modelBuilder.ApplyConfiguration(new UserTypeConfiguration());
            modelBuilder.ApplyConfiguration(new RoomTypeConfiguration());
        }




    }
}
