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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            List<string> Name = new List<string>();
            string AllName = txtbox_search.Text;
            int ListName = 0;
            var txtList = Directory.EnumerateFiles(@"F:\Contact Tracing List\List Name");
            foreach (string folder in txtList)
            {
                string List = File.ReadAllText(folder);
                if (List.Contains(AllName))
                {
                    var Allname = List.Substring(List.IndexOf("=") + 1);
                    ListName++;
                    Name.Add(List);
                    continue;
                }
            }
            if (ListName == 0)
            {
                MessageBox.Show("No Records Found");
            }
            else
            {
                StreamWriter folder = new StreamWriter(@"F:\Contact Tracing List\Search List\Search_Name.txt");
                foreach (string list in Name)
                {
                    _ = Name.LastOrDefault();
                    folder.WriteLine(list);
                }
                folder.Close();
                MessageBox.Show("Found " + ListName + " Record/s on the List");
                MessageBox.Show("This File Will be Saved in Search List Folder");
                Form4 Allname = new Form4();
                Allname.ShowDialog();
            }
        }

        private void btn_date_Click(object sender, EventArgs e)
        {
            List<string> DateName = new List<string>();
            string dates = dtp_date.Text;
            int ListDate = 0;
            var txtdate = Directory.EnumerateFiles(@"F:\Contact Tracing List\List Name");
            foreach (string folder in txtdate)
            {
                string List = File.ReadAllText(folder);
                if (List.Contains(dates))
                {
                    var date = List.Substring(List.IndexOf("=") + 1);
                    ListDate++;
                    DateName.Add(List);
                    continue;
                }
            }
            if (ListDate == 0)
            {
                MessageBox.Show("No records found on the selected date");
            }
            else
            {
                StreamWriter folder = new StreamWriter(@"F:\Contact Tracing List\Date List\Date_List.txt");
                foreach (string List in DateName)
                {
                    _ = DateName.LastOrDefault();
                    folder.WriteLine(List);
                }
                folder.Close();
                MessageBox.Show("Found " + ListDate + " record(s) on the selected date");
                MessageBox.Show("This file will be saved in the Date folder");
                Form5 date = new Form5();
                date.ShowDialog();
            }
        }
    }
}
