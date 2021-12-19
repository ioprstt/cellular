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
    public partial class CallsForPhoneNumberForm : Form
    {
        private PhoneNumber phoneNumber;
        private ApplicationContext db;

        public CallsForPhoneNumberForm(PhoneNumber initPhoneNumber)
        {
            InitializeComponent();
            CenterToScreen();

            this.db = new ApplicationContext();
            this.phoneNumber = initPhoneNumber;

            this.dataGridViewOutgoing.AutoGenerateColumns = false;
            this.dataGridViewIncoming.AutoGenerateColumns = false;

            this.InitCalls();
        }

        private void InitCalls()
        {
            IQueryable<Call> outgoingCalls = this.db.Calls.Where(p => p.OutgoingPhoneNumber.Num == phoneNumber.Num);
            var outgoing = outgoingCalls.Select(
                p => new { p.StartTime, IncomingPhoneNumber = p.IncomingPhoneNumber.Num, Duration = DbFunctions.DiffSeconds(p.StartTime, p.EndTime) });
            dataGridViewOutgoing.DataSource = outgoing.ToList();

            IQueryable<Call> incomingCalls = this.db.Calls.Where(p => p.IncomingPhoneNumber.Num == phoneNumber.Num);
            var incoming = incomingCalls.Select(
                p => new { p.StartTime, OutgoingPhoneNumber = p.OutgoingPhoneNumber.Num, Duration = DbFunctions.DiffSeconds(p.StartTime, p.EndTime) });
            dataGridViewIncoming.DataSource = incoming.ToList();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            this.InitCalls();
        }
    }
}
