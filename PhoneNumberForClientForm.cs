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
    public partial class PhoneNumberForClientForm : Form
    {
        ApplicationContext db;
        
        public PhoneNumberForClientForm(Client client)
        {
            InitializeComponent();
            CenterToScreen();

            this.db = new ApplicationContext();

            this.InitPhoneNumbers(client);
        }

        private void InitPhoneNumbers(Client client)
        {
            List<ComboBoxItem> comboBoxItems = new List<ComboBoxItem>();
            IList<PhoneNumber> phoneNumbers = this.db.PhoneNumbers.Where(r => r.ClientId == client.Id).ToList();
            foreach (var pn in phoneNumbers)
            {
                ComboBoxItem item = new ComboBoxItem(pn.Id, pn.Num);
                comboBoxItems.Add(item);
            }
            this.comboBoxPhoneNumbers.DataSource = comboBoxItems;
            this.comboBoxPhoneNumbers.ValueMember = "Key";
            this.comboBoxPhoneNumbers.DisplayMember = "Value";
        }

        public PhoneNumber GetPhoneNumber()
        {
            int id = (int)this.comboBoxPhoneNumbers.SelectedValue;
            return this.db.PhoneNumbers.Where(r => r.Id == id).FirstOrDefault();
        }
    }
}
