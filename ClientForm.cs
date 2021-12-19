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
    public partial class ClientForm : Form
    {
        private ApplicationContext db;
        Client initClient;

        public ClientForm(Client client = null)
        {
            InitializeComponent();
            CenterToScreen();

            this.initClient = client;
            if (client != null)
                this.InitValues(client);

            this.db = new ApplicationContext();

            this.InitWidgets();
        }

        private void InitValues(Client client)
        {
            this.comboBoxClientFormPassports.SelectedValue = client.Id;
        }

        private void InitWidgets()
        {
            this.InitComboBoxClientFormPassports();
        }

        private void InitComboBoxClientFormPassports()
        {
            List<ComboBoxItem> comboBoxItems = new List<ComboBoxItem>();
            IList<Passport> passports = this.db.Passports.ToList();
            foreach (Passport passport in passports)
            {
                PassportManager manager = new PassportManager(passport.Id);
                ComboBoxItem item = new ComboBoxItem(passport.Id, manager.GetNameAndPassport());
                comboBoxItems.Add(item);
            }
            this.comboBoxClientFormPassports.DataSource = comboBoxItems;
            this.comboBoxClientFormPassports.ValueMember = "Key";
            this.comboBoxClientFormPassports.DisplayMember = "Value";
        }

        private void linkLabelAddPassport_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PassportForm form = new PassportForm();
            form.ShowDialog();
            // если добавили паспорт, то обновляем комбобокс и выбираем последний добавленный элемент
            if (form.DialogResult == DialogResult.OK)
            {
                Passport passport = form.GetPassport();
                db.Passports.Add(passport);
                db.SaveChanges();

                PassportManager passportManager = new PassportManager(passport.Id);
                Msg.ShowInfoMessage($"Паспорт {passportManager.GetFullPassport()} успешно создан.");
                
                InitComboBoxClientFormPassports();
                this.comboBoxClientFormPassports.SelectedIndex = this.comboBoxClientFormPassports.Items.Count - 1;
            }
        }

        private bool Validate()
        {
            this.ValidatePassport();

            Dictionary<ErrorProvider, Control> items = new Dictionary<ErrorProvider, Control>
            {
                { errorProviderPassport, comboBoxClientFormPassports },
            };
            foreach (var item in items)
                if (item.Key.GetError(item.Value) != string.Empty)
                    return false;

            return true;
        }

        private void ValidatePassport()
        {
            int passportId = (int)this.comboBoxClientFormPassports.SelectedValue;
            Client client = db.Clients.Where(r => r.PassportId == passportId).FirstOrDefault();
            if (client != null)
                this.errorProviderPassport.SetError(comboBoxClientFormPassports, "Клиент для выбранного паспорта уже существует.");
            else
                this.errorProviderPassport.SetError(comboBoxClientFormPassports, string.Empty);
        }

        private void buttonClientOK_Click(object sender, EventArgs e)
        {
            if (!(this.Validate()))
                return;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        public Client GetClient()
        {
            int passportId = (int)this.comboBoxClientFormPassports.SelectedValue;

            Client client = new Client
            {
                PassportId = passportId
            };
            return client;
        }
    }
}
