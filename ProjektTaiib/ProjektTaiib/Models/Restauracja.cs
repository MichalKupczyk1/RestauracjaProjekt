using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjektTaiib.Models
{
    public class Restauracja:DbContext
    {
        public DbSet<KartaDan> kartaDan { set; get; }
        public DbSet<Kelner> kelner { set; get; }
        public DbSet<Stolik> stolik { set; get; }
        public DbSet<TypDania> typDania { set; get; }
        public DbSet<Zamowienie> zamowienie { set; get; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder 
               .UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=dbRestauracja;
                                Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;
                                ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }
    }
}
