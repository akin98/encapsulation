using _22._07.soru4.classes;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22._07.soru4
{
    public class OkulDbContext : DbContext
    {
        public DbSet<Ogretmen> Ogretmen { get; set; }
        public DbSet<Ders> Ders { get; set; }
    }
}
