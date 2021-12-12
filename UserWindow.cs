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
        private ApplicationContext db = new ApplicationContext();

        public UserWindow(PhoneNumber phone)
        {
            InitializeComponent();
            CenterToScreen();
            dataGridViewOutgoing.AutoGenerateColumns = false;
            dataGridViewIncoming.AutoGenerateColumns = false;

            phoneNumber = phone.Num;

            userManager = new UserManager(phone.Client);

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
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            UpdateCalls();
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

        public IQueryable<Call> GetOutgoingCalls(string phoneNumber, ApplicationContext db)
        {
            return db.Calls.Where(p => p.OutgoingPhoneNumber.Num == phoneNumber);
        }

        public IQueryable<Call> GetIncomingCalls(string phoneNumber, ApplicationContext db)
        {
            return db.Calls.Where(p => p.IncomingPhoneNumber.Num == phoneNumber);
        }
    }
}
