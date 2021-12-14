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
                    PassportManager passportManager = new PassportManager(passport);
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

        }

        private void linkLabelGetClientPassport_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkLabelChangePassport_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkLabelGetClientPhones_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkLabelCreatePhone_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkLabelRemovePhone_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkLabelGetCalls_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
