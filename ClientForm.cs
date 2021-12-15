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

        public ClientForm(Dictionary<int, string> passportsInfo)
        {
            InitializeComponent();
            CenterToScreen();

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
            }
        }

        private void buttonClientOK_Click(object sender, EventArgs e)
        {
            int passportId = (int)this.comboBoxClientFormPassports.SelectedValue;

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
        }
    }
}
