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
    public partial class OperatorAuth : Form
    {
        public OperatorAuth()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string password = this.textBoxPassword.Text;
            if (password == "operator")
                FormRunner.RunForm(this, new OperatorWindow());
            else
                Msg.ShowErrorMessage("Неверный пароль");
        }
    }
}
