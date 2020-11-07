using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PetSoreApp.Models;

namespace PetSoreApp.Data
{
    public class PetSoreAppContext : DbContext
    {
        public PetSoreAppContext (DbContextOptions<PetSoreAppContext> options)
            : base(options)
        {
           
        }

        public DbSet<PetSoreApp.Models.Owner> Owner { get; set; }

        public DbSet<PetSoreApp.Models.Pet> Pet { get; set; }
    }
}
