using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextBase_Adventure.Models;

namespace TextBase_Adventure.Utility
{
    internal class DataContextUtility : DbContext
    {
        public DbSet<Save> saves {  get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlite("Filename=MyDatabase.sqlite");
            }
        }
    }
}
