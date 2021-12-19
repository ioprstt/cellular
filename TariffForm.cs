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
    public partial class TariffForm : Form
    {
        private ApplicationContext db;
        private Tariff initTariff;

        public TariffForm(Tariff tariff = null)
        {
            InitializeComponent();
            CenterToScreen();

            this.db = new ApplicationContext();
            this.initTariff = tariff;

            if (tariff != null)
                this.InitValues(tariff);
        }

        private void InitValues(Tariff tariff)
        {
            this.textBoxName.Text = tariff.Name;
            this.numericUpDownPrice.Value = (decimal)tariff.Price;
        }

        private string GetName() { return this.textBoxName.Text; }
        private float GetPrice() { return (float)this.numericUpDownPrice.Value; }

        private bool Validate()
        {
            this.ValidateName();

            Dictionary<ErrorProvider, Control> items = new Dictionary<ErrorProvider, Control>
            {
                { this.errorProviderName, this.textBoxName },
            };
            foreach (var item in items)
                if (item.Key.GetError(item.Value) != string.Empty)
                    return false;

            return true;
        }

        private void ValidateName()
        {
            string name = this.textBoxName.Text;
            Tariff tariff = this.db.Tariffs.Where(r => r.Name == name).FirstOrDefault();
            if (tariff != null)
                this.errorProviderName.SetError(textBoxName, "Название тарифа уже используется.");
            else
                this.errorProviderName.SetError(textBoxName, string.Empty);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!(this.Validate()))
                return;
        }

        public Tariff GetTariff()
        {
            Tariff tariff = new Tariff
            {
                Name = this.GetName(),
                Price = this.GetPrice()
            };
            return tariff;
        }
    }
}
