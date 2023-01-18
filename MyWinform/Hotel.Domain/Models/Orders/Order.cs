using Hotel_Domain.Commons;
using Hotel_Domain.Models.Rooms;
using Hotel_Domain.Models.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Domain.Models.Orders
{
    public class Order : Auditable
    {
        public int? UserId { get; set; }

        public int? RoomId { get; set; }

        public DateTime OrderDate { get; set; }

        public int? BookingDay { get; set; }

        public decimal? TotalPrice { get; set; }

     
        public User User { get; set; }

      
        public Room Room { get; set; }

    }
}
