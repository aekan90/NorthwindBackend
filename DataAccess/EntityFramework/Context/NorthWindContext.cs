using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System.Data.Common;

namespace DataAccess.EntityFramework.Context
{
    public class NorthWindContext : Microsoft.EntityFrameworkCore.DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Northwind;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
        }
         
        // DB - Entity Bağlamı
        public DbSet<Product> Products { get; set; }
    }
}
