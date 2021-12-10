using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cellular
{
    public partial class UserWindow : Form
    {
        private UserManager userManager;

        public UserWindow(PhoneNumber phone)
        {
            InitializeComponent();
            CenterToScreen();

            userManager = new UserManager(phone.Client);

            labelGreeting.Text = $"Добро пожаловать, {userManager.GetFullName()}";
            labelPhone.Text = $"Номер телефона: {phone}";

            using (ApplicationContext db = new ApplicationContext())
            {
                dataGridView1.DataSource = db.Passports.ToList();
            }
        }

        private void UserWindow_Shown(object sender, EventArgs e)
        {
            if (userManager.GetDateOfBirth() == DateTime.Now.Date)
                Msg.ShowInfoMessage($"Дорогой {userManager.GetFullName()}, поздравляем Вас с днём рождения!");
        }
    }

    public class UserManager
    {
        private Client user;

        public UserManager(Client client)
        {
            user = client;
        }

        public string GetFullName()
        {
            Passport pasport = user.Passport;
            string fullName = $"{pasport.Surname} {pasport.Name}";
            if (pasport.Patronymic is not null)
                fullName = $"{fullName} {pasport.Patronymic}";
            return fullName;
        }

        public DateTime GetDateOfBirth()
        {
            return user.Passport.DateOfBirth;
        }
    }
}
