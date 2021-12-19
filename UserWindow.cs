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
        private string phoneNumber;
        private UserManager userManager;
        private ApplicationContext db;

        public UserWindow(PhoneNumber phone)
        {
            InitializeComponent();
            CenterToScreen();

            this.db = new ApplicationContext();

            phoneNumber = phone.Num;

            userManager = new UserManager(phone.Client.Id);

            labelGreeting.Text = $"Добро пожаловать, {userManager.GetFullName()}";
            labelPhone.Text = $"Номер телефона: {phone}";
            labelTariff.Text = $"Тариф: {phone.Tariff.Name}";
        }

        private void UserWindow_Shown(object sender, EventArgs e)
        {
            if (userManager.GetDateOfBirth() == DateTime.Now.Date)
                Msg.ShowInfoMessage($"Дорогой {userManager.GetFullName()}, поздравляем Вас с днём рождения!");
        }

        private void linkLabelShowCalls_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PhoneNumber phoneNumber = this.db.PhoneNumbers.Where(r => r.Num == this.phoneNumber).First();
            CallsForPhoneNumberForm form = new CallsForPhoneNumberForm(phoneNumber);
            form.ShowDialog();
        }

        private void linkLabelShowPrice_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
