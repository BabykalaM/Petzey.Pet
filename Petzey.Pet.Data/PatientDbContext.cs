using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Petzey.Pet.Domain.Entities;

namespace Petzey.Pet.Data
{
    public class PatientDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\mssqllocaldb;Initial Catalog=PatientDb;Integrated Security=True");
        }
        public DbSet<Patient> Pets { get; set; }

        public DbSet<PetOwner> PetOwners { get; set; }
    }
}
