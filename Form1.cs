using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace part3b_getting_input
{
    public partial class MainForm : Form
    {
        string name;
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            name = txtInput.Text;
            lblMessage.Text = "Greetings " + name;
        }
    }
}
