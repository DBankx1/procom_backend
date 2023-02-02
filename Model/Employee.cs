using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace procom_backend.Model
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public List<Address> Addresses {get; set;}
    }
}