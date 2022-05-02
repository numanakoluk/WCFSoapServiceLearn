using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;
using WCFSoapServiceLearn.Model;

namespace WCFSoapServiceLearn.DAL
{
    public class EmployeeDbContext : DbContext
    {
        public EmployeeDbContext() : base("EmployeeDbContext")
        {
        }
        public DbSet<Employee> Employees { get; set; }
    }

    public class EmployeeDbInitilaizer: DropCreateDatabaseIfModelChanges<EmployeeDbContext>
    {
        protected override void Seed(EmployeeDbContext context)
        {
            context.Employees.Add(new Employee() {
            Name="Numan",
            Adress ="Şişli",
           
            

            });
            context.SaveChanges();
        }
    }
}