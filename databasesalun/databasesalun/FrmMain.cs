using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace databasesalun
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (txtUsername.Tetx == "admin") && txtPassword.Text == "admin")

            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
        else 
        {
            MessageBox.Show("Anda salah")
        }


    }
}
