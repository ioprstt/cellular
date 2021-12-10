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
    public partial class AdminAuth : Form
    {
        public AdminAuth()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string password = textBoxPassword.Text;
            if (password == "admin")
                FormRunner.RunForm(this, new AdminWindow());
            else
                Msg.ShowErrorMessage("Неверный пароль");
        }
    }
}
