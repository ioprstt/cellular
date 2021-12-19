using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace cellular
{
    public partial class OperatorWindow : Form
    {
        private Client selectedClient = null;
        ApplicationContext db;
        static Random rand = new Random();

        public OperatorWindow()
        {
            InitializeComponent();
            CenterToScreen();
            this.db = new ApplicationContext();
        }

        private void linkLabelCreateClient_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Dictionary<int, string> passportsInfo = new Dictionary<int, string>();
            foreach (Passport passport in db.Passports.ToList())
            {
                PassportManager passportManager = new PassportManager(passport.Id);
                passportsInfo.Add(passport.Id, passportManager.GetNameAndPassport());
            }

            using (CreateClientForm form = new CreateClientForm(passportsInfo))
            {
                form.ShowDialog();
                if (form.DialogResult == DialogResult.OK)
                {
                    Client client = form.GetClient();
                    db.Clients.Add(client);
                    db.SaveChanges();
                    Msg.ShowInfoMessage($"Клиент с идентификатором {client.Id} успешно создан.");
                }
            }
        }

        private void linkLabelRemoveClient_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!(this.CheckSelectedClient())) { return; }
            int clientId = this.selectedClient.Id;
            if (Dialog.ConfirmDialog($"Уверены, что хотите удалить клиента {clientId}?") == DialogResult.Yes) {
                //db.Clients.Attach(this.selectedClient);
                Client client = db.Clients.Where(r => r.Id == this.selectedClient.Id).FirstOrDefault();
                db.Clients.Remove(client);
                db.SaveChanges();
                this.ResetClient();
                Msg.ShowInfoMessage($"Клиент {clientId} удалён.");
            }
        }

        private void linkLabelGetClientPassport_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!(this.CheckSelectedClient())) { return; }
            //db.Clients.Attach(this.selectedClient);
            Client client = db.Clients.Where(r => r.Id == this.selectedClient.Id).FirstOrDefault();
            PassportForm dlg = new PassportForm(client.Passport, true);
            dlg.ShowDialog();
        }

        private void linkLabelChangePassport_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!(this.CheckSelectedClient())) { return; }
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
        }

        private void linkLabelGetClientPhones_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!(this.CheckSelectedClient())) { return; }
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
        }

        private void linkLabelCreatePhone_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!(this.CheckSelectedClient())) { return; }

            // Выбираем тариф
            Tariff selectedTatif;
            SelectTariffForm form = new SelectTariffForm();
            form.ShowDialog();
            if (form.DialogResult == DialogResult.OK)
                selectedTatif = form.GetTariff();
            else
                return;

            // Генерируем номер
            string newPhoneStr = null;
            int k = 0;
            while (k < 100)
            {
                newPhoneStr = this.GeneratePhoneNumber();
                PhoneNumber phone = db.PhoneNumbers.Where(r => r.Num == newPhoneStr).FirstOrDefault();
                if (phone == null)
                {
                    PhoneNumber newPhoneNumber = new PhoneNumber {
                        ClientId = this.selectedClient.Id,
                        Num = newPhoneStr,
                        TariffId = selectedTatif.Id,
                        RegistrationDate = DateTime.Now.Date
                    };
                    db.PhoneNumbers.Add(newPhoneNumber);
                    db.SaveChanges();
                    break;
                }
                k++;
            }
            if (newPhoneStr != null)
                Msg.ShowInfoMessage($"Для клиента добавлен норме {newPhoneStr} с тарифом \"{selectedTatif.Name}\".");
            else
                Msg.ShowWarningMessage("Не удалось сгенерировать номер. Обратитесь к администратору.");
        }

        private void linkLabelRemovePhone_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!(this.CheckSelectedClient())) { return; }

            PhoneNumberForClientForm form = new PhoneNumberForClientForm(this.selectedClient);
            form.ShowDialog();
            if (form.DialogResult != DialogResult.OK)
                return;

            PhoneNumber phoneNumber = form.GetPhoneNumber();
            if (Dialog.ConfirmDialog($"Уверены, что хотите удалить номер {phoneNumber.Num}?") != DialogResult.Yes)
                return;
            
            PhoneNumber removedPhone = this.db.PhoneNumbers.Where(r => r.Id == phoneNumber.Id).First();
            this.db.PhoneNumbers.Remove(removedPhone);
            this.db.SaveChanges();
            Msg.ShowInfoMessage($"Номер {phoneNumber.Num} успешно удалён.");
        }

        private void linkLabelGetCalls_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!(this.CheckSelectedClient())) { return; }

            // Выбрать номер для которого показать
            PhoneNumberForClientForm form = new PhoneNumberForClientForm(this.selectedClient);
            form.ShowDialog();
            if (form.DialogResult != DialogResult.OK)
                return;
            PhoneNumber phoneNumber = form.GetPhoneNumber();

            // Показать информацию
            CallsForPhoneNumberForm callsForPhoneNumberForm = new CallsForPhoneNumberForm(phoneNumber);
            callsForPhoneNumberForm.ShowDialog();
        }

        private void linkLabelPrice_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!(this.CheckSelectedClient())) { return; }

            // Выбрать номер для которого показать
            PhoneNumberForClientForm form = new PhoneNumberForClientForm(this.selectedClient);
            form.ShowDialog();
            if (form.DialogResult != DialogResult.OK)
                return;
            PhoneNumber phoneNumber = form.GetPhoneNumber();

            // Показать информацию
            PriceForPhoneNumberForm priceForPhoneNumberForm = new PriceForPhoneNumberForm(phoneNumber);
            priceForPhoneNumberForm.ShowDialog();
        }

        private void buttonSelectClient_Click(object sender, EventArgs e)
        {
            using (SearchClientForm form = new SearchClientForm())
            {
                form.ShowDialog();
                if (form.DialogResult == DialogResult.OK)
                {
                    Client client = form.GetClient();
                    if (client != null)
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
            this.ResetClient();
        }

        private void ResetClient()
        {
            if (this.selectedClient != null)
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

        private string GeneratePhoneNumber()
        {
            string digits = "0123456789";
            List<string> resList = new List<string>();
            resList.Add("8");
            resList.Add("9");
            for (int i = 0; i < 9; i++)
            {
                resList.Add(rand.Next(0, 9).ToString());
            }
            string result = String.Join<string>("", resList);
            return Utils.ValidatePhone(result);
        }
    }
}
