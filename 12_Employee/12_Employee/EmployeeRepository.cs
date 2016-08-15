using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Employee
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly List<Employee> employees;
        private int nextId = 0;

        public EmployeeRepository()
        {
            employees = new List<Employee>();
        }

        public void Clear()
        {
            employees.Clear();
            nextId = 0;
        }



        public int CountEmployees()
        {
            return employees.Count();
        }

        public Employee CreateEmployee(string name, string type)
        {
            Employee e = new Employee(NextId(), name, type);
            SaveEmployee(e);
            return e;
        }

        private int NextId()
        {
            return ++nextId;
        }


        public List<Employee> FindAllEmployees()
        {
            return employees;
        }

        public Employee LoadEmployee(int id)
        {
            return employees.Where(employee => employee.Id == id).FirstOrDefault();
        }

        public void SaveEmployee(Employee employee)
        {
            if (!employees.Contains(employee))
            employees.Add(employee);
        }
    }
}
