
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Beolvasas.Models;
using Microsoft.EntityFrameworkCore;

namespace Beolvasas.Data
{
    public class PersonContext : DbContext
    {
        public PersonContext()
        {
        }

        public DbSet<Person> Persons { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MsSqlLocalDb;Database=People;Trusted_Connection=True;");
        }

    }
}
