using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace procom_backend.Model
{
    public class Address
    {
        public string StreetName { get; set; }
        public string PostalCode { get; set; }
        public int ApartmentNumber { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
    }
}