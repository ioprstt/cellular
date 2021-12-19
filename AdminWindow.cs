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
            this.dgvAdminTariff.AutoGenerateColumns = false;
            this.dgvAdminPhoneNumber.AutoGenerateColumns = false;
            this.dgvAdminCall.AutoGenerateColumns = false;

            this.Load();
        }

        private void Load()
        {
            this.dgvAdminPassport.DataSource = db.Passports.ToList();
            this.dgvAdminClient.DataSource = db.Clients.ToList();
            this.dgvAdminTariff.DataSource = db.Tariffs.ToList();
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

        private int GetId(DataGridView dgv)
        {
            int row = dgv.SelectedRows[0].Index;
            int id = (int)dgv.Rows[row].Cells[0].Value;
            return id;
        }

        private bool RowSelected(DataGridView dgv)
        {
            return dgv.SelectedRows.Count > 0;
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            TabPage selectePage = this.tabControlAdmin.SelectedTab;

            if (selectePage == this.tabPagePassport)
            {
                if (this.RowSelected(this.dgvAdminPassport))
                {
                    int id = this.GetId(this.dgvAdminPassport);
                    Passport passport = this.db.Passports.Where(r => r.Id == id).First();
                    PassportForm form = new PassportForm(passport);
                    form.ShowDialog();
                    if (form.DialogResult != DialogResult.OK)
                        return;
                    passport.Update(form.GetPassport());
                    this.db.SaveChanges();
                }
                else
                {
                    Msg.ShowErrorMessage("Выберите строку для редактирования");
                }
            }
            else if (selectePage == this.tabPageClient)
            {
                if (this.RowSelected(this.dgvAdminClient))
                {
                    int id = this.GetId(this.dgvAdminClient);
                    Client client = this.db.Clients.Where(r => r.Id == id).First();
                    ClientForm form = new ClientForm(client);
                    form.ShowDialog();
                    if (form.DialogResult != DialogResult.OK)
                        return;
                    client.Update(form.GetClient());
                    this.db.SaveChanges();
                }
                else
                {
                    Msg.ShowErrorMessage("Выберите строку для редактирования");
                }
            }
            else if (selectePage == this.tabPageTariff)
            {
                if (this.RowSelected(this.dgvAdminTariff))
                {
                    int id = this.GetId(this.dgvAdminTariff);
                    Tariff tariff = this.db.Tariffs.Where(r => r.Id == id).First();
                    TariffForm form = new TariffForm(tariff);
                    form.ShowDialog();
                    if (form.DialogResult != DialogResult.OK)
                        return;
                    tariff.Update(form.GetTariff());
                    this.db.SaveChanges();
                }
            }
            else if (selectePage == this.tabPagePhoneNumber)
            {
                if (this.RowSelected(this.dgvAdminPhoneNumber))
                {
                    int id = this.GetId(this.dgvAdminPhoneNumber);
                    PhoneNumber phoneNumber = this.db.PhoneNumbers.Where(r => r.Id == id).First();
                    PhoneNumberForm form = new PhoneNumberForm(phoneNumber);
                    form.ShowDialog();
                    if (form.DialogResult != DialogResult.OK)
                        return;
                    phoneNumber.Update(form.GetPhoneNumber());
                    this.db.SaveChanges();
                }
            }
            else if (selectePage == this.tabPageCall)
            {
                if (this.RowSelected(this.dgvAdminCall))
                {
                    int id = this.GetId(this.dgvAdminCall);
                    Call call = this.db.Calls.Where(r => r.Id == id).First();
                    CallForm form = new CallForm(call);
                    form.ShowDialog();
                    if (form.DialogResult != DialogResult.OK)
                        return;
                    call.Update(form.GetCall());
                    this.db.SaveChanges();
                }
            }
            else
            {
                throw new Exception("Неожиданное поведение");
            }
            this.Load(); // отобразить обновление
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            TabPage selectePage = this.tabControlAdmin.SelectedTab;

            if (selectePage == this.tabPagePassport)
            {
                if (this.RowSelected(this.dgvAdminPassport))
                {
                    int id = this.GetId(this.dgvAdminPassport);
                    Passport passport = this.db.Passports.Where(r => r.Id == id).First();
                    if (Dialog.ConfirmDialog("Уверены, что хотите безвозвратно удалить паспорт?") != DialogResult.Yes)
                        return;
                    this.db.Passports.Remove(passport);
                    this.db.SaveChanges();
                }
                else
                {
                    Msg.ShowErrorMessage("Выберите строку для редактирования");
                }
            }
            else if (selectePage == this.tabPageClient)
            {
                if (this.RowSelected(this.dgvAdminClient))
                {
                    int id = this.GetId(this.dgvAdminClient);
                    Client client = this.db.Clients.Where(r => r.Id == id).First();
                    if (Dialog.ConfirmDialog("Уверены, что хотите безвозвратно удалить клиента?") != DialogResult.Yes)
                        return;
                    this.db.Clients.Remove(client);
                    this.db.SaveChanges();
                }
                else
                {
                    Msg.ShowErrorMessage("Выберите строку для редактирования");
                }
            }
            else if (selectePage == this.tabPageTariff)
            {
                if (this.RowSelected(this.dgvAdminTariff))
                {
                    int id = this.GetId(this.dgvAdminTariff);
                    Tariff tariff = this.db.Tariffs.Where(r => r.Id == id).First();
                    if (Dialog.ConfirmDialog("Уверены, что хотите безвозвратно удалить тариф?") != DialogResult.Yes)
                        return;
                    this.db.Tariffs.Remove(tariff);
                    this.db.SaveChanges();
                }
            }
            else if (selectePage == this.tabPagePhoneNumber)
            {
                if (this.RowSelected(this.dgvAdminPhoneNumber))
                {
                    int id = this.GetId(this.dgvAdminPhoneNumber);
                    PhoneNumber phoneNumber = this.db.PhoneNumbers.Where(r => r.Id == id).First();
                    if (Dialog.ConfirmDialog("Уверены, что хотите безвозвратно удалить номер телефона?") != DialogResult.Yes)
                        return;
                    this.db.PhoneNumbers.Remove(phoneNumber);
                    this.db.SaveChanges();
                }
            }
            else if (selectePage == this.tabPageCall)
            {
                if (this.RowSelected(this.dgvAdminCall))
                {
                    int id = this.GetId(this.dgvAdminCall);
                    Call call = this.db.Calls.Where(r => r.Id == id).First();
                    if (Dialog.ConfirmDialog("Уверены, что хотите безвозвратно удалить звонок?") != DialogResult.Yes)
                        return;
                    this.db.Calls.Remove(call);
                    this.db.SaveChanges();
                }
            }
            else
            {
                throw new Exception("Неожиданное поведение");
            }
            this.Load(); // отобразить обновление
        }

        private void dgvAdminPassport_SelectionChanged(object sender, EventArgs e)
        {
            //int row = this.dgvAdminPassport.SelectedCells[0].RowIndex;
            //this.dgvAdminPassport.Rows[0].Selected = true;
        }
    }
}
