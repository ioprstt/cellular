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
        Dictionary<int, string> passportsInfo;
        private ApplicationContext db;

        public ClientForm(Dictionary<int, string> passportsInfo)
        {
            InitializeComponent();
            CenterToScreen();

            this.db = new ApplicationContext();

            this.passportsInfo = passportsInfo;
            this.InitComboBoxClientFormPassports();
        }

        private void InitComboBoxClientFormPassports()
        {
            List<ComboBoxItem> comboBoxItems = new List<ComboBoxItem>();
            foreach (var info in this.passportsInfo)
            {
                ComboBoxItem item = new ComboBoxItem(info.Key, info.Value);
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
                
                this.passportsInfo.Add(passport.Id, passportManager.GetNameAndPassport());
                InitComboBoxClientFormPassports();
                this.comboBoxClientFormPassports.SelectedIndex = this.comboBoxClientFormPassports.Items.Count - 1;
            }
        }

        private void buttonClientOK_Click(object sender, EventArgs e)
        {
            int passportId = (int)this.comboBoxClientFormPassports.SelectedValue;
            Client client = db.Clients.Where(r => r.PassportId == passportId).FirstOrDefault();
            if (client != null)
            {
                Msg.ShowErrorMessage("Клиент для выбранного паспорта уже существует");
                return;
            }

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
