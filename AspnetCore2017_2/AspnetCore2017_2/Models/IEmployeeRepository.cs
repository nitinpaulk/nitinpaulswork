using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspnetCore2017_2.Models
{
    public interface IEmployeeRepository
    {
        Employee GetEmployee(int Id);
    }
}
