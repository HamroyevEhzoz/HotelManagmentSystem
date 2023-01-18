using Hotel.Service;
using Hotel_Domain.Models.Orders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyWinform
{
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
        }

        int userId;

        private void buttonSearchRooms_Click(object sender, EventArgs e)
        {
            listBoxRooms.Items.Clear();
            textBoxBronDate.Clear();
            textBoxBronLimit.Clear();
            textBoxRoomNumber.Clear();

            var DateNow = DateTime.UtcNow;

            var orders = OrderService.GetAllOrders().ToList();

            foreach (var order in orders)
            {

                DateTime orderesTime = order.OrderDate;
                orderesTime = orderesTime.AddDays(Convert.ToDouble(order.BookingDay));
                if (orderesTime < DateNow)
                {
                    OrderService.DeleteOrder(order.Id);
                }
            }
            var rooms = RoomService.dbContext.Rooms.Include(x => x.Order).ToList();
            
            foreach (var room in rooms)
            {
                if(room.Order == null )
                {

                    string text = room.Number + " -xona " + room.Status.ToString() + " Narxi : " + room.Price.ToString();
                    listBoxRooms.Items.Add(text);
                }
                
            }
        }

      

        private void buttonBookingRoom_Click(object sender, EventArgs e)
        {
            var number = Convert.ToInt32(textBoxRoomNumber.Text);

            var userId = ClassForId.Id;


            var findOrder = UserService.GetUser(userId);

            if (findOrder is not null)
            {
                MessageBox.Show("Sizni nomingizda bron qilingan xona mavjud!", "Warning", MessageBoxButtons.OK);
            }
            else
            {
                var room = UserService.dbContext.Rooms.FirstOrDefault(x => x.Number == number);

                var roomId = room.Id;
                var price = room.Price;

                DateTime bronTime = Convert.ToDateTime(textBoxBronDate.Text).ToUniversalTime();

                int limit = Convert.ToInt32(textBoxBronLimit.Text);

                var order = new Order
                {
                    RoomId = roomId,
                    UserId = userId,
                    OrderDate = bronTime,
                    BookingDay = limit,
                    TotalPrice = price * limit

                };

                OrderService.AddOrder(order);

                MessageBox.Show($"Xona muvafaqiyatli {limit} kunga band qilindi!", "Succes", MessageBoxButtons.OK);

            }
        }

        
    }
}
