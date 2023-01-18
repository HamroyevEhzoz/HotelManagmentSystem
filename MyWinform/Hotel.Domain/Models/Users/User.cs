
using Hotel_Domain.Commons;
using Hotel_Domain.Enums;
using Hotel_Domain.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Domain.Models.Users
{
    public class User : Auditable
    {
        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        public string?  PhoneNumber { get; set; }

        public string? Password { get; set; }

        public string? Email { get; set; }

        public UserRole UserRole { get; set; }

        public Order?  Order { get; set; }
    }
}
