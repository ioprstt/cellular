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
<<<<<<< HEAD
=======
        private ApplicationContext db;
>>>>>>> acb11c1 (ef6 and net472)

        public ClientForm(Dictionary<int, string> passportsInfo)
        {
            InitializeComponent();
            CenterToScreen();

<<<<<<< HEAD
=======
            this.db = new ApplicationContext();

>>>>>>> acb11c1 (ef6 and net472)
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
<<<<<<< HEAD
            using (PassportForm form = new PassportForm())
            {
                form.ShowDialog();
                // если добавили паспорт, то обновляем комбобокс и выбираем последний добавленный элемент
                if (form.DialogResult == DialogResult.OK)
                {
                    Passport passport = form.GetCurrentPassport();
                    PassportManager passportManager = new PassportManager(passport.Id);
                    this.passportsInfo.Add(passport.Id, passportManager.GetNameAndPassport());
                    InitComboBoxClientFormPassports();
                    this.comboBoxClientFormPassports.SelectedIndex = this.comboBoxClientFormPassports.Items.Count - 1;
                }
=======
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
>>>>>>> acb11c1 (ef6 and net472)
            }
        }

        private void buttonClientOK_Click(object sender, EventArgs e)
        {
            int passportId = (int)this.comboBoxClientFormPassports.SelectedValue;
<<<<<<< HEAD

            using (ApplicationContext db = new ApplicationContext())
            {
                db.Load();
                Client client = new Client { 
                    PassportId = passportId 
                };
                db.Clients.Add(client);
                db.SaveChanges();
                Msg.ShowInfoMessage($"Клиент с идентификатором {client.Id} успешно создан.");
            }
=======
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
>>>>>>> acb11c1 (ef6 and net472)
        }
    }
}
