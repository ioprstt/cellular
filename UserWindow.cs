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

        public UserWindow(PhoneNumber phone)
        {
            InitializeComponent();
            CenterToScreen();
            dataGridViewOutgoing.AutoGenerateColumns = false;
            dataGridViewIncoming.AutoGenerateColumns = false;

            phoneNumber = phone.Num;

            userManager = new UserManager(phone.Client.Id);

            labelGreeting.Text = $"Добро пожаловать, {userManager.GetFullName()}";
            labelPhone.Text = $"Номер телефона: {phone}";

            UpdateCalls();
        }

        private void UserWindow_Shown(object sender, EventArgs e)
        {
            if (userManager.GetDateOfBirth() == DateTime.Now.Date)
                Msg.ShowInfoMessage($"Дорогой {userManager.GetFullName()}, поздравляем Вас с днём рождения!");
        }

        private void UpdateCalls()
        {
<<<<<<< HEAD
            using (ApplicationContext db = new ApplicationContext())
            {
                IQueryable<Call> outgoing = userManager.GetOutgoingCalls(phoneNumber, db);
                var result = outgoing.Select(
                    p => new { p.StartTime, OutgoingPhoneNumber = p.OutgoingPhoneNumber.Num, Duration = p.EndTime.Subtract(p.StartTime) });
                dataGridViewOutgoing.DataSource = result.ToList();

                IQueryable<Call> incoming = userManager.GetIncomingCalls(phoneNumber, db);
                result = incoming.Select(
                    p => new { p.StartTime, OutgoingPhoneNumber = p.OutgoingPhoneNumber.Num, Duration = p.EndTime.Subtract(p.StartTime) });
                dataGridViewIncoming.DataSource = result.ToList();
            }
=======
            IQueryable<Call> outgoing = userManager.GetOutgoingCalls(phoneNumber);
            var result = outgoing.Select(
                p => new { p.StartTime, OutgoingPhoneNumber = p.OutgoingPhoneNumber.Num, Duration = p.EndTime.Subtract(p.StartTime) });
            dataGridViewOutgoing.DataSource = result.ToList();

            IQueryable<Call> incoming = userManager.GetIncomingCalls(phoneNumber);
            result = incoming.Select(
                p => new { p.StartTime, OutgoingPhoneNumber = p.OutgoingPhoneNumber.Num, Duration = p.EndTime.Subtract(p.StartTime) });
            dataGridViewIncoming.DataSource = result.ToList();
>>>>>>> acb11c1 (ef6 and net472)
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            UpdateCalls();
        }
    }
}
