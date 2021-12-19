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
    public partial class PriceForPhoneNumberForm : Form
    {
        ApplicationContext db;
        PhoneNumber phoneNumber;

        public PriceForPhoneNumberForm(PhoneNumber initPhoneNumber)
        {
            InitializeComponent();
            CenterToParent();

            this.dateTimePickerStartTime.Value = DateTime.Now.AddDays(-30);

            this.phoneNumber = initPhoneNumber;
            this.db = new ApplicationContext();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime startDate = this.dateTimePickerStartTime.Value.Date;
            DateTime endDate = this.dateTimePickerEndTime.Value.Date;

            Tariff tariff = this.phoneNumber.Tariff;

            IQueryable<Call> calls = db.Calls.Where(r =>
                r.OutgoingPhoneNumber.Num == this.phoneNumber.Num &&
                r.StartTime >= startDate &&
                r.EndTime <= endDate
            );

            List<Call> callList = calls.ToList();
            double seconds = 0;
            foreach (Call call in callList)
            {
                seconds += call.EndTime.Subtract(call.StartTime).TotalSeconds;
            }
            double price = seconds / 60 * tariff.Price;

            Msg.ShowInfoMessage($"За указанный период было соверешно {callList.Count} вызов(а).\n" +
                $"Для тарифа \"{tariff.Name}\" плата за минуту составляет {tariff.Price} руб.\n" +
                $"Общее время разговора {seconds} сек.\n\n" +
                $"Стоимость услуг за указанный период {price} руб.");
        }
    }
}
