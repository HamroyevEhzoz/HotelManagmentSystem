using Hotel.Service;
using Hotel_Data.ProgramDbContext;
using Hotel_Domain.Models.Users;
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
    public partial class Registr : Form
    {
        public Registr()
        {
            InitializeComponent();
        }

        

        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            var firstName = textBoxFirstName.Text;
            var lastName = textBoxLastName.Text;
            var phoneNumber = textBoxPhoneNumber.Text;
            var password = textBoxPassword.Text;
            var email = textBoxEmail.Text;

            if (firstName == string.Empty || password == string.Empty || email == string.Empty)
            {
                MessageBox.Show("Ma'lumotlarni to'liq to'ldiring!", "Warning!", MessageBoxButtons.OK);
            }
            else
            {
                User user = new User
                {
                    FirstName = firstName,
                    LastName = lastName,
                    PhoneNumber = phoneNumber,
                    Password = password,
                    Email = email,
                    UserRole = Hotel_Domain.Enums.UserRole.User
                };

                UserService.AddUser(user);



                this.Close();

                MessageBox.Show("You Signed up successful!", "Ok", MessageBoxButtons.OK);
            }
        }
    }
}
