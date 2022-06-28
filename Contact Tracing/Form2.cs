using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contact_Tracing
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btn_admin_Click(object sender, EventArgs e)
        {
            String user = txtbox_user.Text;
            String pass = txtbox_pass.Text;
            if (user == "admin")
                if (pass == "password")
                {
                    Form3 info = new Form3();
                    info.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Your User or Password is Incorrect Please Try Again", "Login Failed");
                }
            else
            {
                MessageBox.Show("Your User or Password is Incorrect Please Try Again", "Login Failed");
            }
            Environment.Exit(0);
        }
    }
}
