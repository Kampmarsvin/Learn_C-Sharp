using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Employee
{
    interface IEmployeeRepository
    {
         void Clear();
         int CountEmployees();
         Employee CreateEmployee(String name, String type);
         void SaveEmployee(Employee employee);
         Employee LoadEmployee(int id);
         List<Employee> FindAllEmployees();
       
    }
}
