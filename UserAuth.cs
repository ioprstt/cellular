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
<<<<<<< HEAD
            string password = textBoxPassword.Text;
=======
>>>>>>> acb11c1 (ef6 and net472)
            Client client = null;

            string validPhone;
            try
            {
                validPhone = Utils.ValidatePhone(login);
            }
            catch (ValidatePhoneException exc)
            {
<<<<<<< HEAD
                Msg.ShowErrorMessage($"Некорректный идентификатор.\n{exc.Message}");
=======
                Msg.ShowErrorMessage($"Некорректный номер.\n{exc.Message}");
>>>>>>> acb11c1 (ef6 and net472)
                return;
            }
            PhoneNumber phone = db.PhoneNumbers.Where(r => r.Num == validPhone).FirstOrDefault();

<<<<<<< HEAD
            if (phone is not null)
=======
            if (phone != null)
>>>>>>> acb11c1 (ef6 and net472)
                FormRunner.RunForm(this, new UserWindow(phone));
            else
                Msg.ShowErrorMessage("Клиент не найден");
        }
    }
}
