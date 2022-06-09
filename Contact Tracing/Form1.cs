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
            StreamWriter file = new StreamWriter(@"F:\Contract_Tracing\test.txt", true);
        }
    }
}