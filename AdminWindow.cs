using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Linq;
using System.Data.Entity.Infrastructure;

namespace cellular
{
    public partial class AdminWindow : Form
    {
        private ApplicationContext db;

        public AdminWindow()
        {
            InitializeComponent();
            CenterToScreen();

            this.db = new ApplicationContext();

            this.dgvAdminPassport.AutoGenerateColumns = false;
            this.dgvAdminClient.AutoGenerateColumns = false;
            this.dgvAdminClient.AutoGenerateColumns = false;
            this.dgvTariff.AutoGenerateColumns = false;
            this.dgvAdminPhoneNumber.AutoGenerateColumns = false;
            this.dgvAdminCall.AutoGenerateColumns = false;

            this.Load();
        }

        private void Load()
        {
            this.dgvAdminPassport.DataSource = db.Passports.ToList();
            this.dgvAdminClient.DataSource = db.Clients.ToList();
            this.dgvTariff.DataSource = db.Tariffs.ToList();
            this.dgvAdminPhoneNumber.DataSource = db.PhoneNumbers.ToList();
            this.dgvAdminCall.DataSource = db.Calls.ToList();
        }

        private void buttonAdminUpdate_Click(object sender, EventArgs e)
        {
            this.Load();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TabPage selectePage = this.tabControlAdmin.SelectedTab;

            if (selectePage == this.tabPagePassport)
            {
                PassportForm form = new PassportForm();
                form.ShowDialog();
                if (form.DialogResult != DialogResult.OK)
                    return;
                this.db.Passports.Add(form.GetPassport());
                this.db.SaveChanges();
            }
            else if (selectePage == this.tabPageClient)
            {
                ClientForm form = new ClientForm();
                form.ShowDialog();
                if (form.DialogResult != DialogResult.OK)
                    return;
                this.db.Clients.Add(form.GetClient());
                this.db.SaveChanges();
            }
            else if (selectePage == this.tabPageTariff)
            {
                TariffForm form = new TariffForm();
                form.ShowDialog();
                if (form.DialogResult != DialogResult.OK)
                    return;
                this.db.Tariffs.Add(form.GetTariff());
                this.db.SaveChanges();
            }
            else if (selectePage == this.tabPagePhoneNumber)
            {
                PhoneNumberForm form = new PhoneNumberForm();
                form.ShowDialog();
                if (form.DialogResult != DialogResult.OK)
                    return;
                this.db.PhoneNumbers.Add(form.GetPhoneNumber());
                this.db.SaveChanges();
            }
            else if (selectePage == this.tabPageCall)
            {
                CallForm form = new CallForm();
                form.ShowDialog();
                if (form.DialogResult != DialogResult.OK)
                    return;
                this.db.Calls.Add(form.GetCall());
                this.db.SaveChanges();
            }
            else
            {
                throw new Exception("Неожиданное поведение");
            }
            this.Load(); // отобразить обновление
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {

        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {

        }

        private Form GetFormForSelected()
        {
            TabPage selectePage = this.tabControlAdmin.SelectedTab;
            Dictionary<TabPage, Form> dict = new Dictionary<TabPage, Form>
            {
                { this.tabPagePassport, new PassportForm() },
                { this.tabPageClient, new ClientForm() },
                { this.tabPageTariff, new TariffForm() },
                { this.tabPagePhoneNumber, new PhoneNumberForm() },
                { this.tabPageCall, new CallForm() }
            };
            Form form = dict[selectePage];
            return form;
        }
    }
}
