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
    public partial class PhoneNumberForm : Form
    {
        private ApplicationContext db;
        private PhoneNumber initPhoneNumber;

        public PhoneNumberForm(PhoneNumber phoneNumber = null)
        {
            InitializeComponent();
            CenterToScreen();

            this.db = new ApplicationContext();
            this.initPhoneNumber = phoneNumber;

            this.InitWidgets();

            if (phoneNumber != null)
                this.InitValues(phoneNumber);
        }

        private void InitWidgets()
        {
            this.InitClientWidget();
            this.InitTariffWidget();
        }

        private void InitClientWidget()
        {
            List<ComboBoxItem> comboBoxItems = new List<ComboBoxItem>();
            IList<Client> clients = this.db.Clients.ToList();
            foreach (Client client in clients)
            {
                PassportManager manager = new PassportManager(client.Passport.Id);
                ComboBoxItem item = new ComboBoxItem(client.Id, manager.GetNameAndPassport());
                comboBoxItems.Add(item);
            }
            this.comboBoxClient.DataSource = comboBoxItems;
            this.comboBoxClient.ValueMember = "Key";
            this.comboBoxClient.DisplayMember = "Value";
        }

        private void InitTariffWidget()
        {
            List<ComboBoxItem> comboBoxItems = new List<ComboBoxItem>();
            IList<Tariff> tariffs = this.db.Tariffs.ToList();
            foreach (Tariff tariff in tariffs)
            {
                ComboBoxItem item = new ComboBoxItem(tariff.Id, tariff.Name);
                comboBoxItems.Add(item);
            }
            this.comboBoxTariff.DataSource = comboBoxItems;
            this.comboBoxTariff.ValueMember = "Key";
            this.comboBoxTariff.DisplayMember = "Value";
        }

        private void InitValues(PhoneNumber phoneNumber)
        {
            this.comboBoxClient.SelectedValue = phoneNumber.Client.Id;
            this.textBoxPhoneNumber.Text = phoneNumber.Num;
            this.comboBoxTariff.SelectedValue = phoneNumber.Tariff.Id;
            this.dateTimePickerRegistrationDate.Value = phoneNumber.RegistrationDate;
        }

        private int GetClient() { return (int)this.comboBoxClient.SelectedValue; }
        private string GetPhoneNum() { return textBoxPhoneNumber.Text; }
        private int GetTariff() { return (int)this.comboBoxTariff.SelectedValue; }
        private DateTime GetRegistrationDate() { return this.dateTimePickerRegistrationDate.Value.Date; }

        private bool Validate()
        {
            this.ValidatePhoneNumber();
            this.ValidateRegistrationDate();

            Dictionary<ErrorProvider, Control> items = new Dictionary<ErrorProvider, Control>
            {
                { errorProviderPhoneNumber, textBoxPhoneNumber },
                { errorProviderRegistrationDate, dateTimePickerRegistrationDate },
            };
            foreach (var item in items)
                if (item.Key.GetError(item.Value) != string.Empty)
                    return false;

            return true;
        }

        private void ValidatePhoneNumber()
        {
            string num = this.GetPhoneNum();
            PhoneNumber pn = db.PhoneNumbers.Where(r => r.Num == num).FirstOrDefault();
            if (pn != null)
                this.errorProviderPhoneNumber.SetError(this.textBoxPhoneNumber, "Номер уже существует");
            else
                this.errorProviderPhoneNumber.SetError(this.textBoxPhoneNumber, string.Empty);
        }

        private void ValidateRegistrationDate()
        {
            if (this.GetRegistrationDate() > DateTime.Now)
                this.errorProviderRegistrationDate.SetError(this.dateTimePickerRegistrationDate, "Некорректная дата");
            else
                this.errorProviderRegistrationDate.SetError(this.dateTimePickerRegistrationDate, string.Empty);
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (!(this.Validate()))
                return;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void linkLabelCreateClient_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ClientForm form = new ClientForm();
            form.ShowDialog();
            if (form.DialogResult != DialogResult.OK)
                return;
            Client client = form.GetClient();
            this.db.Clients.Add(client);
            this.db.SaveChanges();

            this.InitClientWidget();
        }

        private void linkLabelCreateTariff_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            TariffForm form = new TariffForm();
            form.ShowDialog();
            if (form.DialogResult != DialogResult.OK)
                return;
            Tariff tariff = form.GetTariff();
            this.db.Tariffs.Add(tariff);
            this.db.SaveChanges();

            this.InitTariffWidget();
        }

        public PhoneNumber GetPhoneNumber()
        {
            PhoneNumber phoneNumber = new PhoneNumber
            {
                ClientId = GetClient(),
                Num = GetPhoneNum(),
                TariffId = GetTariff(),
                RegistrationDate = GetRegistrationDate()
            };
            return phoneNumber;
        }        
    }
}
