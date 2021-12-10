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
    public partial class Authorization : Form
    {
        public Authorization()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Form authForm;
            if (radioButtonUser.Checked)
                authForm = new UserAuth();
            else
                authForm = new AdminAuth();
            FormRunner.RunForm(this, authForm);
        }
    }
}
