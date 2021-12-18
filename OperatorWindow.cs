using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
<<<<<<< HEAD
=======
using System.Data.Entity;
>>>>>>> acb11c1 (ef6 and net472)

namespace cellular
{
    public partial class OperatorWindow : Form
    {
        private Client selectedClient = null;
<<<<<<< HEAD
=======
        ApplicationContext db;
>>>>>>> acb11c1 (ef6 and net472)

        public OperatorWindow()
        {
            InitializeComponent();
            CenterToScreen();
<<<<<<< HEAD
=======
            this.db = new ApplicationContext();
>>>>>>> acb11c1 (ef6 and net472)
        }

        private void linkLabelCreateClient_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Dictionary<int, string> passportsInfo = new Dictionary<int, string>();
<<<<<<< HEAD
            using (ApplicationContext db = new ApplicationContext())
            {
                foreach (Passport passport in db.Passports.ToList())
                {
                    PassportManager passportManager = new PassportManager(passport.Id);
                    passportsInfo.Add(passport.Id, passportManager.GetNameAndPassport());
                }
=======
            foreach (Passport passport in db.Passports.ToList())
            {
                PassportManager passportManager = new PassportManager(passport.Id);
                passportsInfo.Add(passport.Id, passportManager.GetNameAndPassport());
>>>>>>> acb11c1 (ef6 and net472)
            }

            using (ClientForm form = new ClientForm(passportsInfo))
            {
                form.ShowDialog();
<<<<<<< HEAD
=======
                if (form.DialogResult == DialogResult.OK)
                {
                    Client client = form.GetClient();
                    db.Clients.Add(client);
                    db.SaveChanges();
                    Msg.ShowInfoMessage($"Клиент с идентификатором {client.Id} успешно создан.");
                }
>>>>>>> acb11c1 (ef6 and net472)
            }
        }

        private void linkLabelRemoveClient_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!(this.CheckSelectedClient())) { return; }
<<<<<<< HEAD
=======
            int clientId = this.selectedClient.Id;
            if (Dialog.ConfirmDialog($"Уверены, что хотите удалить клиента {clientId}?") == DialogResult.Yes) {
                //db.Clients.Attach(this.selectedClient);
                Client client = db.Clients.Where(r => r.Id == this.selectedClient.Id).FirstOrDefault();
                db.Clients.Remove(client);
                db.SaveChanges();
                this.ResetClient();
                Msg.ShowInfoMessage($"Клиент {clientId} удалён.");
            }
>>>>>>> acb11c1 (ef6 and net472)
        }

        private void linkLabelGetClientPassport_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!(this.CheckSelectedClient())) { return; }
<<<<<<< HEAD
=======
            //db.Clients.Attach(this.selectedClient);
            Client client = db.Clients.Where(r => r.Id == this.selectedClient.Id).FirstOrDefault();
            PassportForm dlg = new PassportForm(client.Passport, true);
            dlg.ShowDialog();
>>>>>>> acb11c1 (ef6 and net472)
        }

        private void linkLabelChangePassport_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!(this.CheckSelectedClient())) { return; }
<<<<<<< HEAD
=======
            //db.Clients.Attach(this.selectedClient);
            Client client = db.Clients.Where(r => r.Id == this.selectedClient.Id).FirstOrDefault();
            PassportForm dlg = new PassportForm(client.Passport, false);
            dlg.ShowDialog();
            if (dlg.DialogResult == DialogResult.OK)
            {
                client.Passport.Update(dlg.GetPassport());
                db.SaveChanges();
                Msg.ShowInfoMessage($"Паспортные данные клиента успешно обновлены.");
            }
>>>>>>> acb11c1 (ef6 and net472)
        }

        private void linkLabelGetClientPhones_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!(this.CheckSelectedClient())) { return; }
<<<<<<< HEAD
=======
            var numbers = db.PhoneNumbers.Where(r => r.ClientId == this.selectedClient.Id).ToList();
            if (numbers.Count > 0)
            {
                List<string> strnumber = new List<string>();
                foreach (var v in numbers)
                {
                    strnumber.Add(v.Num);
                }
                Msg.ShowList(strnumber, "Список номеров клиента");
            }
            else
            {
                Msg.ShowInfoMessage("У клиента нет номеров.");
            }
>>>>>>> acb11c1 (ef6 and net472)
        }

        private void linkLabelCreatePhone_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!(this.CheckSelectedClient())) { return; }
        }

        private void linkLabelRemovePhone_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkLabelGetCalls_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void buttonSelectClient_Click(object sender, EventArgs e)
        {
            using (SearchClientForm form = new SearchClientForm())
            {
                form.ShowDialog();
                if (form.DialogResult == DialogResult.OK)
                {
                    Client client = form.GetClient();
<<<<<<< HEAD
                    if (client is not null)
=======
                    if (client != null)
>>>>>>> acb11c1 (ef6 and net472)
                    {
                        this.selectedClient = client;
                        UserManager userManager = new UserManager(client.Id);
                        string fullPassport = userManager.GetFullPassport();
                        string fullName = userManager.GetFullName();
                        this.labelSelectedClient.Text = $"Клиент {client.Id} ({fullPassport}, {fullName})";
                    }
                }
            }
        }

        private void buttonResetClient_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            if (this.selectedClient is not null)
=======
            this.ResetClient();
        }

        private void ResetClient()
        {
            if (this.selectedClient != null)
>>>>>>> acb11c1 (ef6 and net472)
            {
                this.selectedClient = null;
                this.labelSelectedClient.Text = "Клиент не выбран";
            }
        }

        private bool CheckSelectedClient()
        {
            if (this.selectedClient is null)
            {
                Msg.ShowErrorMessage("Клиент не выбран!");
                return false;
            }
            return true;
        }
    }
}
