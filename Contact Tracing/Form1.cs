namespace Contact_Tracing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lbl_ctracing_Click(object sender, EventArgs e)
        {
            

        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            StreamWriter file = new StreamWriter(@"F:\Contract_Tracing\Contact_Tracing.txt", true);
            file.WriteLine("Date: " + txtbox_date.Text);
            file.Close();
            MessageBox.Show("Thank You For Your Response!", "Contact Tracing", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}