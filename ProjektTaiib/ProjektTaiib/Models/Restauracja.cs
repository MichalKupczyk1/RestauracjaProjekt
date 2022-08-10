using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjektTaiib.Models
{
    public class Restauracja:DbContext
    {
        private  Action<Restauracja, ModelBuilder> _modelCustomizer;
        public DbSet<KartaDan> kartaDan { set; get; }
        public DbSet<Kelner> kelner { set; get; }
        public DbSet<Stolik> stolik { set; get; }
        public DbSet<TypDania> typDania { set; get; }
        public DbSet<Zamowienie> zamowienie { set; get; }

        public Restauracja()
        {

        }
        public Restauracja(DbContextOptions<Restauracja> options) : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder
                   .UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Restauracja;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            }
        }
    }
}
