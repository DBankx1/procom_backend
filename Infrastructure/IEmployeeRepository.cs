using System.Collections.Generic;
using procom_backend.Model;

namespace procom_backend.Infrastructure
{
    public interface IEmployeeRepository
    {
        List<Employee> GetAllEmployees();
        Employee CreateEmployee(Employee employee);
        Employee GetEmployeeById(int id);
        void DeleteEmployee(Employee employee);
        Employee UpdateEmployee(int id, Employee employee);
    }
}