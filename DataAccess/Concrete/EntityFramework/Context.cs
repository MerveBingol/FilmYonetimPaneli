using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
   public class Context:DbContext
    {
        // Context sınıfı oluşturulup, projenin kullanacağı Db belirtildi.
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=FilmYonetimPaneli;Trusted_Connection=true");
        }


        // Projedeki hangi class veri tabanındaki hangi tabloya bağlanacak onu belirliyoruz.
        public DbSet<Film> Filmler { get; set; }
        public DbSet<Salon> Salonlar { get; set; }
        public DbSet<Kullanici> Kullanicilar { get; set; }

    }
}
