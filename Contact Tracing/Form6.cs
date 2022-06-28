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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
            var txt_all = Directory.GetFiles(@"F:\Contact Tracing List\List Name");
            foreach (string folder in txt_all)
            {
                string All = File.ReadAllText(folder);
                lbl_all.Text = lbl_all.Text + All + "\n";
            }
        }
    }
}
