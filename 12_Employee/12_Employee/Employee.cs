using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Employee
{

    public class Employee
    {


        public Employee(int id, string name, string type)
        {
            Id = id;
            Name = name;
            Type = type;
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public string Type { get; set; }



        public override bool Equals(Object o)
        {
            if (this == o) return true;
            if (!(o is Employee)) return false;

            Employee employee = (Employee)o;

            if (Id != employee.Id) return false;
            if (Name != null ? !Name.Equals(employee.Name) : employee.Name != null) return false;
            if (Type != null ? !Type.Equals(employee.Type) : employee.Type != null) return false;

            return true;
        }
        public override int GetHashCode()
        {
            int result;
            result = Id;
            result = 29 * result + (Name != null ? Name.GetHashCode() : 0);
            result = 29 * result + (Type != null ? Type.GetHashCode() : 0);
            return result;
        }

        public override string ToString()
        {
            return "Employee[id=" + Id + ",name=" + Name + ",type=" + Type + "]";
        }
    }
}
