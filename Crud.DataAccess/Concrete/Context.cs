using System;
using Crud.Entities;
using Microsoft.EntityFrameworkCore;
 
namespace Crud.DataAccess.Concrete.Ef
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=tcp:crudtask.database.windows.net,1433;Initial Catalog=CrudTask;Persist Security Info=False;User ID=safayilmaz;Password=1470coder.;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        }

        public DbSet<Notes> Notes { get; set; }
    }
}