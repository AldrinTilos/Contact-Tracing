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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            var date_list = Directory.GetFiles(@"F:\Contact Tracing List\Date List\");
            foreach (string folder in date_list)
            {
                string Date = File.ReadAllText(folder);
                lbl_date.Text = lbl_date.Text + Date + "\n";
            }
        }
    }
}
