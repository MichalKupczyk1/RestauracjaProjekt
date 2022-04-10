using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace ProjektTaiib.Models
{
    public class InMemoryTest
    {
        private DbContextOptions<Restauracja> _contextOptions;

        [Fact]
        public void testInMemoryAddKelnerToTheDatabaseShouldBeEqual()
        {
            _contextOptions = new DbContextOptionsBuilder<Restauracja>()
        .UseInMemoryDatabase("BloggingControllerTest")
        .ConfigureWarnings(b => b.Ignore(InMemoryEventId.TransactionIgnoredWarning))
        .Options;

            using var context = new Restauracja(_contextOptions);

            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();

            context.AddRange(
                new Kelner { nazwisko="Szary", id=1, imie="Adrian", zamowienia=null},
                new Kelner { nazwisko="Lewandowski", id=2, imie="Robert", zamowienia=null},
                new Kelner { nazwisko="Ronaldo", id=3, imie="Cristiano", zamowienia=null}
                );
            context.SaveChanges();

            Kelner test = context.kelner.Where(e => e.nazwisko == "Ronaldo").FirstOrDefault();

            Assert.Equal("Ronaldo",test.nazwisko);
        }
    }
}
