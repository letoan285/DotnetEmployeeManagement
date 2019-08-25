using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Models
{
    public class MockEmployeeRepository : IEmployeeRepository
    {
        private List<Employee> _employeeList;

        public MockEmployeeRepository()
        {
            _employeeList = new List<Employee>()
            {
                new Employee() { Id = 1, Name = "Marry", Department = "HR", Email = "marry@gmail.com"},
                new Employee() { Id = 2, Name = "John", Department = "HR", Email = "john@gmail.com"},
                new Employee() { Id = 3, Name = "Samsung", Department = "IT", Email = "samsung@gmail.com"}
            };
        }
        public Employee GetEmployee(int Id)
        {
            return _employeeList.FirstOrDefault(e => e.Id == Id);
        }
    }
}
