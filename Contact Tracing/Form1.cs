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
            file.WriteLine("Time: " + txtbox_time.Text);
            file.WriteLine("Gender: " + txtbox_gender.Text);
            file.WriteLine("Date of Birth: " + txtbox_dbirth.Text);
            file.WriteLine("Grade and Section: " + txtbox_gsection.Text);
            file.WriteLine("Name of Pupil: " + txtbox_pname.Text);
            file.WriteLine("Name of Parent/Guardian: " + txtbox_gname.Text);
            file.WriteLine("Address: " + txtbox_address.Text);
            file.WriteLine("Contact Number: " + txtbox_cnumber.Text);
            file.WriteLine("Temperature: " + txtbox_temp.Text);
            file.Close();
            MessageBox.Show("Thank You For Your Response!", "Contact Tracing", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }
    }
}