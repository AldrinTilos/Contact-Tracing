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
            detail.WriteLine("Date: " + txtbox_mname.Text);
            detail.WriteLine("Time: " + txtbox_time.Text);
            detail.WriteLine("Gender: " + txtbox_gender.Text);
            detail.WriteLine("Date of Birth: " + txtbox_dbirth.Text);
            detail.WriteLine("Course and Year: " + txtbox_cyear.Text);
            detail.WriteLine("Name of Pupil: " + txtbox_fname.Text);
            detail.WriteLine("Name of Parent/Guardian: " + txtbox_lname.Text);
            detail.WriteLine("Address: " + txtbox_address.Text);
            detail.WriteLine("Contact Number: " + txtbox_cnumber.Text);
            detail.WriteLine("Temperature: " + txtbox_temp.Text);
            detail.Close();
            MessageBox.Show("Thank You For Your Response!: " + Environment.NewLine + "Date: " + txtbox_mname.Text + Environment.NewLine + "Time: " + txtbox_time.Text + Environment.NewLine + "Course and Year: " + txtbox_cyear.Text + Environment.NewLine + "Name of Pupil: " + txtbox_fname.Text + Environment.NewLine + "Name of Guardian: " + txtbox_lname.Text + Environment.NewLine + "Address: " + txtbox_address.Text + Environment.NewLine + "Contact Number: " + txtbox_cnumber.Text + Environment.NewLine + "Gender: " + txtbox_gender.Text + Environment.NewLine + "Date of Birth: " + txtbox_dbirth.Text + Environment.NewLine + "Temperature: " + txtbox_temp.Text);
            txtbox_mname.Text = txtbox_time.Text = txtbox_gender.Text = txtbox_dbirth.Text = txtbox_cyear.Text = txtbox_fname.Text = 
            txtbox_lname.Text = txtbox_address.Text = txtbox_cnumber.Text = txtbox_temp.Text = "";
        }
        
        private void txtbox_dbirth_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtbox_time_TextChanged(object sender, EventArgs e)
        {

        }
    }
}