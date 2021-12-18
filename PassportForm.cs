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
        ApplicationContext db;
        Passport initPassport;

        public PassportForm(Passport passport = null, bool readonly_ = false)
        {
            InitializeComponent();
            CenterToScreen();

            db = new ApplicationContext();
            initPassport = passport;

            if (passport != null)
                InitValues(passport);

            if (readonly_)
                SetReadonly();
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

        private void InitValues(Passport passport)
        {
            textBoxSeries.Text = passport.Series;
            textBoxNum.Text = passport.Num;
            dateTimePickerDateOfIssue.Value = passport.DateOfIssue;
            textBoxIssuingAuthority.Text = passport.IssuingAuthority;
            textBoxSurname.Text = passport.Surname;
            textBoxName.Text = passport.Name;
            textBoxPatronymic.Text = passport.Patronymic;
            dateTimePickerDateOfBirth.Value = passport.DateOfBirth;
            textBoxAddress.Text = passport.Address;
        }

        private void SetReadonly()
        {
            textBoxSeries.ReadOnly = true;
            textBoxNum.ReadOnly = true;
            textBoxIssuingAuthority.ReadOnly = true;
            textBoxSurname.ReadOnly = true;
            textBoxName.ReadOnly = true;
            textBoxPatronymic.ReadOnly = true;
            textBoxAddress.ReadOnly = true;

            // пикер не имеет свойство ReadOnly => перхватываем событие изменения даты и откатываем его
            DateTime dateOfIssue = dateTimePickerDateOfIssue.Value;
            dateTimePickerDateOfIssue.ValueChanged += (s, args) => dateTimePickerDateOfIssue.Value = dateOfIssue;

            DateTime dateOfBirth = dateTimePickerDateOfBirth.Value;
            dateTimePickerDateOfBirth.ValueChanged += (s, args) => dateTimePickerDateOfBirth.Value = dateOfBirth;
        }

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

            string series = this.GetSeries();
            string num = this.GetNum();
            // Проверяем повторение паспорта только если серия и номер не совпадает с паспортом из инициализации
            if (series != this.initPassport.Series || num != this.initPassport.Num)
            {
                Passport passport = db.Passports.Where(r => r.Series == series && r.Num == num).FirstOrDefault();
                if (passport != null)
                {
                    Msg.ShowErrorMessage($"Паспорт {this.GetSeries()} {this.GetNum()} уже существует!");
                    return false;
                }
            }

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
            if (!(this.Validate()))
                return;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        public Passport GetPassport()
        {
            Passport passport = new Passport
            {
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
            return passport;
        }
    }
}
