using Microsoft.EntityFrameworkCore;

using Models.Database;
using Models.AdminPanel.Database.Accounting;
using System;

namespace Database
{
    public class DataContext:DbContext
    {
      
        public DataContext()
        {
        }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
         
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
            

            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer("Data Source=DESKTOP-C64UM7J\\SQLEXPRESS;Database=Commercial;Integrated Security=True");
        }


        public DbSet<User> User { get; set; }
        public DbSet<Roles> Roles { get; set; }
        public DbSet<UserRoles> UserRoles { get; set; }
    }
}
