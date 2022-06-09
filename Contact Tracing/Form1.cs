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
            StreamWriter detail = new StreamWriter(@"F:\Contract_Tracing\Contact_Tracing.txt", true);
            detail.WriteLine("Date: " + txtbox_date.Text);
            detail.WriteLine("Time: " + txtbox_time.Text);
            detail.WriteLine("Gender: " + txtbox_gender.Text);
            detail.WriteLine("Date of Birth: " + txtbox_dbirth.Text);
            detail.WriteLine("Course and Year: " + txtbox_cyear.Text);
            detail.WriteLine("Name of Pupil: " + txtbox_pname.Text);
            detail.WriteLine("Name of Parent/Guardian: " + txtbox_gname.Text);
            detail.WriteLine("Address: " + txtbox_address.Text);
            detail.WriteLine("Contact Number: " + txtbox_cnumber.Text);
            detail.WriteLine("Temperature: " + txtbox_temp.Text);
            detail.Close();
            MessageBox.Show("Thank You For Your Response!", "Contact Tracing", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtbox_date.Text = txtbox_time.Text = txtbox_gender.Text = txtbox_dbirth.Text = txtbox_cyear.Text = txtbox_pname.Text = 
            txtbox_gname.Text = txtbox_address.Text = txtbox_cnumber.Text = txtbox_temp.Text = "";
        }

        private void txtbox_dbirth_TextChanged(object sender, EventArgs e)
        {

        }
    }
}