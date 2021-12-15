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
    public partial class OperatorWindow : Form
    {
        private Client selectedClient = null;

        public OperatorWindow()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void linkLabelCreateClient_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Dictionary<int, string> passportsInfo = new Dictionary<int, string>();
            using (ApplicationContext db = new ApplicationContext())
            {
                foreach (Passport passport in db.Passports.ToList())
                {
                    PassportManager passportManager = new PassportManager(passport.Id);
                    passportsInfo.Add(passport.Id, passportManager.GetNameAndPassport());
                }
            }

            using (ClientForm form = new ClientForm(passportsInfo))
            {
                form.ShowDialog();
            }
        }

        private void linkLabelRemoveClient_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!(this.CheckSelectedClient())) { return; }
        }

        private void linkLabelGetClientPassport_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!(this.CheckSelectedClient())) { return; }
        }

        private void linkLabelChangePassport_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!(this.CheckSelectedClient())) { return; }
        }

        private void linkLabelGetClientPhones_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!(this.CheckSelectedClient())) { return; }
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
                    if (client is not null)
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
            if (this.selectedClient is not null)
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
