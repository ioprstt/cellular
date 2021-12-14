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
    public partial class PassportForm : Form
    {
        private bool create;
        private Passport currentPassport;

        public PassportForm(bool create = true)
        {
            InitializeComponent();
            CenterToScreen();

            this.create = create;
            this.currentPassport = null;
        }

        public string GetSeries() { return textBoxSeries.Text; }
        public string GetNum() { return textBoxNum.Text; }
        public DateTime GetDateOfIssue() { return dateTimePickerDateOfIssue.Value.Date; }
        public string GetIssuingAuthority() { return textBoxIssuingAuthority.Text; }
        public string GetSurname() { return textBoxSurname.Text; }
        public string GetName() { return textBoxName.Text; }
        public string GetPatronymic() { return textBoxPatronymic.Text; }
        public DateTime GetDateOfBirth() { return dateTimePickerDateOfBirth.Value.Date; }
        public string GetAddress() { return textBoxAddress.Text; }

        public bool Validate()
        {
            ValidateSeries();
            ValidateNum();
            ValidateDateOfIssue();
            ValidateIssuingAuthority();
            ValidateSurname();
            ValidateName();
            ValidateDateOfBirth();
            ValidateAddress();

            Dictionary<ErrorProvider, Control> items = new Dictionary<ErrorProvider, Control> 
            {
                { errorProviderSeries, textBoxSeries },
                { errorProviderNum, textBoxNum },
                { errorProviderIssuingAuthority, textBoxIssuingAuthority },
                { errorProviderDateOfIssue, dateTimePickerDateOfIssue },
                { errorProviderSurname, textBoxSurname },
                { errorProviderName, textBoxName },
                { errorProviderDateOfBirth, dateTimePickerDateOfBirth },
                { errorProviderAddress, textBoxAddress }
            };
            foreach (var item in items)
                if (item.Key.GetError(item.Value) != string.Empty)
                    return false;

            return true;
        }

        private void ValidateSeries()
        {
            if (!(new Regex(@"\d{4}").IsMatch(GetSeries())))
                errorProviderSeries.SetError(textBoxSeries, "Ожидаются 4 цифры");
            else
                errorProviderSeries.SetError(textBoxSeries, string.Empty);
        }

        private void ValidateNum()
        {
            if (!(new Regex(@"\d{6}").IsMatch(GetNum())))
                errorProviderNum.SetError(textBoxNum, "Ожидаются 6 цифр");
            else
                errorProviderNum.SetError(textBoxNum, string.Empty);
        }

        private void ValidateDateOfIssue()
        {
            if (GetDateOfIssue() > DateTime.Now)
                errorProviderDateOfIssue.SetError(dateTimePickerDateOfIssue, "Некорректная дата");
            else
                errorProviderDateOfIssue.SetError(dateTimePickerDateOfIssue, string.Empty);
        }

        private void ValidateIssuingAuthority()
        {
            CheckEmptyTextBox(textBoxIssuingAuthority, errorProviderIssuingAuthority, "Место выдачи не может быть пустым");
        }

        private void ValidateSurname()
        {
            CheckEmptyTextBox(textBoxSurname, errorProviderSurname, "Фамилия не может быть пустой");
        }

        private void ValidateName()
        {
            CheckEmptyTextBox(textBoxName, errorProviderName, "Имя не может быть пустым");
        }

        private void ValidateDateOfBirth()
        {
            if (GetDateOfBirth() > DateTime.Now)
                errorProviderDateOfBirth.SetError(dateTimePickerDateOfBirth, "Некорректная дата");
            else
                errorProviderDateOfBirth.SetError(dateTimePickerDateOfBirth, string.Empty);
        }

        private void ValidateAddress()
        {
            CheckEmptyTextBox(textBoxAddress, errorProviderAddress, "Адрес не может быть пустым");
        }

        private void CheckEmptyTextBox(TextBox textBox, ErrorProvider errorProvider, string errorMessage)
        {
            if (string.IsNullOrEmpty(textBox.Text))
                errorProvider.SetError(textBox, errorMessage);
            else
                errorProvider.SetError(textBox, string.Empty);
        }

        private void buttonPassprtOK_Click(object sender, EventArgs e)
        {
            if (this.create)
            {
                if (this.Validate())
                {
                    using (ApplicationContext db = new ApplicationContext())
                    {
                        db.Load();
                        Passport passport = new Passport {
                            Series = this.GetSeries(),
                            Num = this.GetNum(),
                            DateOfIssue = this.GetDateOfIssue(),
                            IssuingAuthority = this.GetIssuingAuthority(),
                            Surname = this.GetSurname(),
                            Name = this.GetName(),
                            Patronymic = string.IsNullOrEmpty(this.GetPatronymic()) ? null : this.GetPatronymic(),
                            DateOfBirth = this.GetDateOfBirth(),
                            Address = this.GetAddress()
                        };
                        db.Passports.Add(passport);
                        db.SaveChanges();
                        this.currentPassport = passport;
                    }
                }
                else
                {
                    return;
                }
            }
            else
            {

            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        public Passport GetCurrentPassport() { 
            return this.currentPassport; 
        }
    }
}
