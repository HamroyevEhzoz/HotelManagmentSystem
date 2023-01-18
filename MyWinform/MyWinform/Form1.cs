using Hotel.Service;

namespace MyWinform
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }

       

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            Registr registr = new Registr();
            registr.Show();
        }

        private void EmailLabel_Click(object sender, EventArgs e)
        {

        }

        private void SignInButton_Click(object sender, EventArgs e)
        {
      
            var email = textBoxEmail.Text;
            var password = textBoxPassword.Text;

            if(string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Email yoki Password bo'sh!", "Xatolik", MessageBoxButtons.OK);
            }
            else
            {
               var user =  UserService.dbContext.Users.FirstOrDefault(x =>
                x.Password == password && x.Email == email);

                if(user is null)
                {
                    MessageBox.Show("Bu user tizimda mavjud emas , iltimos ro'yhatdan o'ting!", "NotFound", MessageBoxButtons.OK);
                }
                else
                {
                    ClassForId.Id = user.Id;
                    ClassForId.Role = user.UserRole;
                    SignIn signIn = new SignIn();
                    signIn.Show();
                    MessageBox.Show($"Siz tizimga {user.UserRole} sifatida muvafaqiyatli kirdingiz", "Succes", MessageBoxButtons.OK);
                   
                }
            }

            textBoxEmail.Clear();
            textBoxPassword.Clear();
        }
    }
}