using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace AspnetCore2017_2.Models
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private List<Employee> _empList;

        public EmployeeRepository()
        {
            _empList = new List<Employee>()
            {
                new Employee() { ID =1, Name = "Nitin", Department = "IT", Email = "paulnitni@gmail.com"}
            };
        }

        public Employee GetEmployee(int Id)
        {
            return _empList.FirstOrDefault(x => x.ID == Id);
        }
    }
}
