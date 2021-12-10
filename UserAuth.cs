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
    public partial class UserAuth : Form
    {
        public UserAuth()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            ApplicationContext db = new ApplicationContext();
            string login = textBoxLogin.Text;
            string password = textBoxPassword.Text;
            Client client = null;

            string validPhone;
            try
            {
                validPhone = Utils.ValidatePhone(login);
            }
            catch (ValidatePhoneException exc)
            {
                Msg.ShowErrorMessage($"Некорректный идентификатор.\n{exc.Message}");
                return;
            }
            PhoneNumber phone = db.PhoneNumbers.Where(r => r.Num == validPhone).FirstOrDefault();

            if (phone is not null)
                FormRunner.RunForm(this, new UserWindow(phone));
            else
                Msg.ShowErrorMessage("Клиент не найден");
        }
    }
}
