using Hotel_Domain.Commons;
using Hotel_Domain.Enums;
using Hotel_Domain.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Domain.Models.Rooms
{
    public class Room : Auditable
    {
        public int? Number { get; set; }

        public StatusRoom  Status { get; set; }

        public decimal? Price { get; set; }

       
        public Order? Order { get; set; }

    }
}
