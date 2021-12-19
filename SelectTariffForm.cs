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
    public partial class SelectTariffForm : Form
    {
        private ApplicationContext db;

        public SelectTariffForm()
        {
            InitializeComponent();
            CenterToScreen();

            this.db = new ApplicationContext();

            InitTariffs();
        }

        private void InitTariffs()
        {
            List<ComboBoxItem> comboBoxItems = new List<ComboBoxItem>();
            IList<Tariff> tariffs = this.db.Tariffs.ToList();
            foreach (var tariff in tariffs)
            {
                ComboBoxItem item = new ComboBoxItem(tariff.Id, tariff.Name);
                comboBoxItems.Add(item);
            }
            this.comboBoxTariffs.DataSource = comboBoxItems;
            this.comboBoxTariffs.ValueMember = "Key";
            this.comboBoxTariffs.DisplayMember = "Value";
        }

        public Tariff GetTariff()
        {
            int id = (int)this.comboBoxTariffs.SelectedValue;
            return this.db.Tariffs.Where(r => r.Id == id).FirstOrDefault();
        }
    }
}
