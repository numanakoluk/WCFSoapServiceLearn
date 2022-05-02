using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WCFSoapServiceLearn.DAL;
using WCFSoapServiceLearn.Model;

namespace WCFSoapServiceLearn
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "EmployeeService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select EmployeeService.svc or EmployeeService.svc.cs at the Solution Explorer and start debugging.
    public class EmployeeService : IEmployeeService
    {
        EmployeeDbContext context = new EmployeeDbContext();
        public void Add(Employee e)
        {
            context.Employees.Add(e);
            context.SaveChanges();
        }

        public void Edit(Employee e)
        {
            context.Entry(e).State = EntityState.Modified;
            context.SaveChanges();
        }

        public Employee Get(int id)
        {
            return context.Employees.Find(id);
        }

        public List<Employee> GetAllEmployees()
        {
            return context.Employees.ToList();
        }

        public void Remove(int id)
        {
            Employee e = context.Employees.Find(id);
            if (e != null)
            {
                context.Employees.Remove(e);
                context.SaveChanges();
            }
        }
    }
}
