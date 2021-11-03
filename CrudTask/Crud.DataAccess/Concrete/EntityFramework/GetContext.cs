using System;
using Crud.Entities;
using Microsoft.EntityFrameworkCore;

namespace Crud.DataAccess.Concrete.EntityFramework
{
    public class GetContext:DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Database string");
        }

        public DbSet<Notes> Notes { get; set; }
    }
}
