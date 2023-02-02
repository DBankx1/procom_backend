using System.Collections.Generic;
using procom_backend.Model;

namespace procom_backend.Infrastructure
{
    public class EmployeeRepository : IEmployeeRepository
    {
       
       private List<Employee> employees = new List<Employee>(){
        new Employee() {
            Id = 1,
            FirstName = "Dami",
            LastName = "Hundeyin",
            Email = "damihundeyin@gmail.com",
            PhoneNumber = "2268981036",
            Addresses = new List<Address>() {
                new Address(){
                    StreetName = "Gateshead",
                    ApartmentNumber = 1,
                    PostalCode = "ABC123",
                    State = "Ontario",
                    Country = "Canada"
                }
            }
        },
         new Employee() {
            Id = 2,
            FirstName = "Menro",
            LastName = "Lisca",
            Email = "menrolisca@gmail.com",
            PhoneNumber = "2268981037",
            Addresses = new List<Address>() {
                new Address(){
                    StreetName = "GatePop",
                    ApartmentNumber = 3,
                    PostalCode = "ABC144",
                    State = "Ontario",
                    Country = "Canada"
                }
            }
        }
       };

        public Employee CreateEmployee(Employee employee)
        {
            employees.Add(employee);
            return employee;
        }

        public void DeleteEmployee(Employee employee)
        {
            employees.Remove(employee);
        }

        public List<Employee> GetAllEmployees()
        {
            return employees;
        }

        public Employee GetEmployeeById(int id)
        {
             var employee = employees.Find(employee => employee.Id == id);
             return employee;
        }

        public Employee UpdateEmployee(int id, Employee employee)
        {
            var employee_found = employees.Find(employee => employee.Id == id);
            employee_found.Email = employee.Email;
            employee_found.FirstName = employee.FirstName;
            employee_found.LastName = employee.LastName;
            employee_found.PhoneNumber = employee.PhoneNumber;
            employee_found.Addresses = employee.Addresses;
            return employee;
        }
    }
}