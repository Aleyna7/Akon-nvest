using EntityLayer.Entities;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder )
        {
            base.OnModelCreating(modelBuilder); // IdentityDbContext'in OnModelCreating metodunu çağırın

            // IdentityUserLogin sınıfının birincil anahtarı olmadığını belirtme
            modelBuilder.Entity<IdentityUserLogin>().HasNoKey();

            // Diğer konfigürasyonları ekleyebilirsiniz
            // ...

            // Özel bir konfigürasyon örneği:
            // modelBuilder.Entity<Advert>().Property(a => a.Price).HasColumnType("decimal(18, 2)");
        }

        public DbSet<Advert> Adverts { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<District> Districts { get; set; }
        public DbSet<GeneralSettings> GeneralSettings { get; set; }
        public DbSet<Images> Images { get; set; }
        public DbSet<Neighbourhood> Neighbourhoods { get; set; }
        public DbSet<Situation> Situations { get; set; }
        public DbSet<EntityLayer.Entities.Type> Types { get; set; }
        public DbSet<UserAdmin> UserAdmins { get; set; }
        public DbSet<IdentityUserLogin> IdentityUserLogins { get; set; }
    }
}