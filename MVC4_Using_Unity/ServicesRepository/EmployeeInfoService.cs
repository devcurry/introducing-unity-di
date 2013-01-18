using MVC4_Using_Unity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC4_Using_Unity.ServicesRepository
{
    public class EmployeeInfoService :IEmployeeInfoService
    {
        CompanyEntities objContext;

        public EmployeeInfoService()
        {
            objContext = new CompanyEntities();
        }

        public IEnumerable<EmployeeInfo> GetEmployees()
        {
            return objContext.EmployeeInfoes.ToList(); 
        }

        public void AddEmployee(EmployeeInfo Emp)
        {
            objContext.AddToEmployeeInfoes(Emp);
            objContext.SaveChanges(); 
        }
    }
}