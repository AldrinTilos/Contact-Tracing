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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            var Search_List = Directory.GetFiles(@"F:\Contact Tracing List\Search List\");
            foreach (string file in Search_List)
            {
                string List = File.ReadAllText(file);
                lbl_search.Text = lbl_search.Text + List + "\n";
            }
        }
    }
}
