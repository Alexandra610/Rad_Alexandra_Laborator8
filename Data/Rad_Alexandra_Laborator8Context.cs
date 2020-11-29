using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Rad_Alexandra_Laborator8.Models;

namespace Rad_Alexandra_Laborator8.Data
{
    public class Rad_Alexandra_Laborator8Context : DbContext
    {
        public Rad_Alexandra_Laborator8Context (DbContextOptions<Rad_Alexandra_Laborator8Context> options)
            : base(options)
        {
        }

        public DbSet<Rad_Alexandra_Laborator8.Models.Book> Book { get; set; }

        public DbSet<Rad_Alexandra_Laborator8.Models.Publisher> Publisher { get; set; }

        public DbSet<Rad_Alexandra_Laborator8.Models.Category> Category { get; set; }
    }
}
