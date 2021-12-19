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
    public partial class CallForm : Form
    {
        private ApplicationContext db;
        private Call initCall;

        public CallForm(Call call = null)
        {
            InitializeComponent();
            CenterToScreen();

            this.dateTimePickerStartTime.Format = DateTimePickerFormat.Custom;
            this.dateTimePickerStartTime.CustomFormat = "dd.MM.yyyy HH:mm:ss";

            this.dateTimePickerEndTime.Format = DateTimePickerFormat.Custom;
            this.dateTimePickerEndTime.CustomFormat = System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.ShortTimePattern;

            this.db = new ApplicationContext();
            this.initCall = call;

            this.InitWidgets();

            if (call != null)
                this.InitValues(call);
        }

        private void InitWidgets()
        {
            this.InitPhoneNumbers();
        }

        private void InitPhoneNumbers()
        {
            List<ComboBoxItem> comboBoxItems = new List<ComboBoxItem>();
            List<ComboBoxItem> comboBoxItems2 = new List<ComboBoxItem>();
            IList<PhoneNumber> phoneNumbers = this.db.PhoneNumbers.ToList();
            foreach (PhoneNumber phoneNumber in phoneNumbers)
            {
                ComboBoxItem item = new ComboBoxItem(phoneNumber.Id, phoneNumber.Num);
                comboBoxItems.Add(item);
                comboBoxItems2.Add(item);
            }

            this.comboBoxOutgoingPhoneNumber.DataSource = comboBoxItems;
            this.comboBoxOutgoingPhoneNumber.ValueMember = "Key";
            this.comboBoxOutgoingPhoneNumber.DisplayMember = "Value";

            this.comboBoxIncomingPhoneNumber.DataSource = comboBoxItems2;
            this.comboBoxIncomingPhoneNumber.ValueMember = "Key";
            this.comboBoxIncomingPhoneNumber.DisplayMember = "Value";
        }

        private void InitValues(Call call)
        {
            this.comboBoxIncomingPhoneNumber.SelectedValue = call.IncomingPhoneNumber.Id;
            this.comboBoxOutgoingPhoneNumber.SelectedValue = call.OutgoingPhoneNumber.Id;
            this.dateTimePickerStartTime.Value = call.StartTime;
            this.dateTimePickerEndTime.Value = call.EndTime;
        }

        private int GetIncomingPhoneNumber() { return (int)this.comboBoxIncomingPhoneNumber.SelectedValue; }
        private int GetOutgoingPhoneNumber() { return (int)this.comboBoxOutgoingPhoneNumber.SelectedValue; }
        private DateTime GetStartTime() { return this.dateTimePickerStartTime.Value.Date; }
        private DateTime GetEndTime() { return this.dateTimePickerEndTime.Value.Date; }

        private bool Validate()
        {
            this.ValidateIncomingPhoneNumber();
            this.ValidateOutgoingPhoneNumber();

            Dictionary<ErrorProvider, Control> items = new Dictionary<ErrorProvider, Control>
            {
                { errorProviderIncomingPhoneNumber, comboBoxIncomingPhoneNumber },
                { errorProviderOutgoingPhoneNumber, comboBoxOutgoingPhoneNumber },
                { errorProviderStartTime, dateTimePickerStartTime },
                { errorProviderEndTime, dateTimePickerEndTime },
            };
            foreach (var item in items)
                if (item.Key.GetError(item.Value) != string.Empty)
                    return false;

            return true;
        }

        private void ValidateIncomingPhoneNumber()
        {
            int incomingId = this.GetIncomingPhoneNumber();
            int outgoingId = this.GetOutgoingPhoneNumber();
            if (incomingId == outgoingId)
                this.errorProviderIncomingPhoneNumber.SetError(this.comboBoxIncomingPhoneNumber, "Исходящий номер совпадет с входящим");
            else
                this.errorProviderIncomingPhoneNumber.SetError(this.comboBoxIncomingPhoneNumber, string.Empty);
        }

        private void ValidateOutgoingPhoneNumber()
        {
            int incomingId = this.GetIncomingPhoneNumber();
            int outgoingId = this.GetOutgoingPhoneNumber();
            if (incomingId == outgoingId)
                this.errorProviderOutgoingPhoneNumber.SetError(this.comboBoxOutgoingPhoneNumber, "Исходящий номер совпадет с входящим");
            else
                this.errorProviderOutgoingPhoneNumber.SetError(this.comboBoxOutgoingPhoneNumber, string.Empty);
        }

        private void ValidateStartTime()
        {
            if (this.GetStartTime() > DateTime.Now)
                this.errorProviderStartTime.SetError(this.dateTimePickerStartTime, "Некорректная дата");
            else
                this.errorProviderStartTime.SetError(this.dateTimePickerStartTime, string.Empty);
        }

        private void ValidateEndTime()
        {
            if (this.GetEndTime() > DateTime.Now)
                this.errorProviderEndTime.SetError(this.dateTimePickerEndTime, "Некорректная дата");
            else
                this.errorProviderEndTime.SetError(this.dateTimePickerEndTime, string.Empty);
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (!(this.Validate()))
                return;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void linkLabelCreatePhoneNumber_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PhoneNumberForm form = new PhoneNumberForm();
            form.ShowDialog();
            if (form.DialogResult != DialogResult.OK)
                return;
            PhoneNumber phoneNumber = form.GetPhoneNumber();
            this.db.PhoneNumbers.Add(phoneNumber);
            this.db.SaveChanges();

            this.InitWidgets(); // отобразить новый номер в виджетах
        }

        public Call GetCall()
        {
            Call call = new Call
            {
                IncomingPhoneNumberId = GetIncomingPhoneNumber(),
                OutgoingPhoneNumberId = GetOutgoingPhoneNumber(),
                StartTime = GetStartTime(),
                EndTime = GetEndTime()
            };
            return call;
        }
    }
}
