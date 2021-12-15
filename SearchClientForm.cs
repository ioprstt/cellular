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

        public SearchClientForm()
        {
            InitializeComponent();
            CenterToScreen();

            this.client = null;
        }

        private void buttonSearchClientOK_Click(object sender, EventArgs e)
        {
            if (this.radioButtonId.Checked)
            {
                int id = (int)this.numericUpDownId.Value;
                using (ApplicationContext db = new ApplicationContext())
                {
                    this.client = db.Clients.Where(r => r.Id == id).FirstOrDefault();
                }
            } 
            else if (this.radioButtonPassport.Checked)
            {
                string series = this.textBoxPassportSeries.Text;
                if (!(new Regex(@"\d{4}").IsMatch(series)))
                {
                    Msg.ShowErrorMessage("Серия паспорта должна состоять из 4-х цифр");
                    return;
                }

                string num = this.textBoxPassportNum.Text;
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
                PhoneNumber phone;
                using (ApplicationContext db = new ApplicationContext())
                {
                    phone = db.PhoneNumbers.Where(r => r.Num == validPhone).FirstOrDefault();
                }

                if (phone is not null)
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
