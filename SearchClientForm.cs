using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace cellular
{
    public partial class SearchClientForm : Form
    {
        private Client client;
<<<<<<< HEAD
=======
        ApplicationContext db;
>>>>>>> acb11c1 (ef6 and net472)

        public SearchClientForm()
        {
            InitializeComponent();
            CenterToScreen();

<<<<<<< HEAD
=======
            this.db = new ApplicationContext();
>>>>>>> acb11c1 (ef6 and net472)
            this.client = null;
        }

        private void buttonSearchClientOK_Click(object sender, EventArgs e)
        {
            if (this.radioButtonId.Checked)
            {
<<<<<<< HEAD
                int id = (int)this.numericUpDownId.Value;
                using (ApplicationContext db = new ApplicationContext())
                {
                    this.client = db.Clients.Where(r => r.Id == id).FirstOrDefault();
                }
=======
                string idText = this.textBoxId.Text;
                if (!(new Regex(@"^\d+$").IsMatch(idText)))
                {
                    Msg.ShowErrorMessage("Некорректный идентификатор");
                    return;
                }
                int id = int.Parse(idText);
                if (id < 0)
                {
                    Msg.ShowErrorMessage("Некорректный идентификатор");
                    return;
                }
                this.client = db.Clients.Where(r => r.Id == id).FirstOrDefault();
>>>>>>> acb11c1 (ef6 and net472)
            } 
            else if (this.radioButtonPassport.Checked)
            {
                string series = this.textBoxPassportSeries.Text;
<<<<<<< HEAD
                if (!(new Regex(@"\d{4}").IsMatch(series)))
=======
                if (!(new Regex(@"^\d{4}$").IsMatch(series)))
>>>>>>> acb11c1 (ef6 and net472)
                {
                    Msg.ShowErrorMessage("Серия паспорта должна состоять из 4-х цифр");
                    return;
                }

                string num = this.textBoxPassportNum.Text;
<<<<<<< HEAD
                if (!(new Regex(@"\d{6}").IsMatch(series)))
                {
                    Msg.ShowErrorMessage("Номер паспорта должн состоять из 6-х цифр");
                    return;
                }

                using (ApplicationContext db = new ApplicationContext())
                {
                    Passport passport = db.Passports.Where(r => r.Series == series && r.Num == num).FirstOrDefault();
                    if (passport is null)
                    {
                        Msg.ShowErrorMessage($"Паспорт {series} {num} не найден.");
                        return;
                    }
                    this.client = passport.Client;
                }
=======
                if (!(new Regex(@"^\d{6}$").IsMatch(num)))
                {
                    Msg.ShowErrorMessage("Номер паспорта должн состоять из 6 цифр");
                    return;
                }

                Passport passport = db.Passports.Where(r => r.Series == series && r.Num == num).FirstOrDefault();
                if (passport is null)
                {
                    Msg.ShowErrorMessage($"Паспорт {series} {num} не найден.");
                    return;
                }
                this.client = db.GetClientByPassport(passport);
>>>>>>> acb11c1 (ef6 and net472)
            } 
            else
            {
                string phoneNumber = this.textBoxPhoneNumber.Text;
                string validPhone;
                try
                {
                    validPhone = Utils.ValidatePhone(phoneNumber);
                }
                catch (ValidatePhoneException exc)
                {
                    Msg.ShowErrorMessage($"Некорректный номер телефона.\n{exc.Message}");
                    return;
                }
<<<<<<< HEAD
                PhoneNumber phone;
                using (ApplicationContext db = new ApplicationContext())
                {
                    phone = db.PhoneNumbers.Where(r => r.Num == validPhone).FirstOrDefault();
                }

                if (phone is not null)
=======
                PhoneNumber phone = db.PhoneNumbers.Where(r => r.Num == validPhone).FirstOrDefault();

                if (phone != null)
>>>>>>> acb11c1 (ef6 and net472)
                    this.client = phone.Client;
            }

            if (client is null)
            {
                Msg.ShowErrorMessage("Клиент не найден.");
                return;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        public Client GetClient()
        {
            return this.client;
        }
    }
}
