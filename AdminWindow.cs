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
    public partial class AdminWindow : Form
    {
        public AdminWindow()
        {
            InitializeComponent();
            CenterToScreen();

            this.dgvAdminPassport.AutoGenerateColumns = false;
            this.dgvAdminClient.AutoGenerateColumns = false;
            this.dgvAdminPhoneNumber.AutoGenerateColumns = false;
            this.dgvAdminCall.AutoGenerateColumns = false;

            this.Load();
        }

        private void Load()
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                this.dgvAdminPassport.DataSource = db.Passports.ToList();
                this.dgvAdminClient.DataSource = db.Clients.ToList();
                this.dgvAdminPhoneNumber.DataSource = db.PhoneNumbers.ToList();
                this.dgvAdminCall.DataSource = db.Calls.ToList();
            }
        }

        private void buttonAdminUpdate_Click(object sender, EventArgs e)
        {
            this.Load();
        }
    }
}
