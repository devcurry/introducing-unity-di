using MVC4_Using_Unity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MVC4_Using_Unity.ServicesRepository
{
    public interface IEmployeeInfoService
    {
        IEnumerable<EmployeeInfo> GetEmployees();
        void AddEmployee(EmployeeInfo Emp);
    }
}
