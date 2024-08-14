using Microsoft.EntityFrameworkCore;
using MVCAssign2.Models;

namespace MVCAssign2.dataContext
{
    public class EmployeesDbContext : DbContext
    {

       public EmployeesDbContext() { }
            public EmployeesDbContext(DbContextOptions<EmployeesDbContext> options)
                : base(options) { }
            public DbSet<Employees> employees { get; set; }
            //protected override void OnConfiguring(DbContextOptionsBuilder builder)
            //{
            //    builder.UseSqlServer("server=ARJUN-LAPTOP43\\SQLEXPRESS ; Database=EmployeesList ; integrated security=true; TrustServerCertificate=True");

            //}




        }
    }

