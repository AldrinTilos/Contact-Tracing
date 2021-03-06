using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using QRCoder;
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;
using ZXing.Aztec;
using ZXing.Windows.Compatibility;
namespace Contact_Tracing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice captureDevice;
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
            StreamWriter detail = new StreamWriter(@"F:\Contact Tracing List\List Name\" + txtbox_lname.Text + txtbox_fname.Text + ".txt", true);
            detail.WriteLine("Date: " + dtp_date.Text);
            detail.WriteLine("Time: " + txtbox_time.Text);
            detail.WriteLine("");
            detail.WriteLine("First Name: " + txtbox_fname.Text);
            detail.WriteLine("Middle Name: " + txtbox_mname.Text);
            detail.WriteLine("Last Name: " + txtbox_lname.Text);
            detail.WriteLine("Course and Year: " + txtbox_cyear.Text);
            detail.WriteLine("Address: " + txtbox_address.Text);
            detail.WriteLine("Contact Number: " + txtbox_cnumber.Text);
            detail.WriteLine("Gender: " + txtbox_gender.Text);
            detail.WriteLine("Date of Birth: " + txtbox_dbirth.Text);
            detail.WriteLine("Temperature: " + txtbox_temp.Text);
            MessageBox.Show("Thank You For Your Response!: " + Environment.NewLine + "Date: " + dtp_date.Text + Environment.NewLine + "Time: " + txtbox_time.Text + Environment.NewLine + "" + 
            Environment.NewLine + "First Name: " + txtbox_fname.Text + Environment.NewLine + "Middle Name: " + txtbox_mname.Text + Environment.NewLine + "Last Name: " + txtbox_lname.Text + 
            Environment.NewLine + "Course and Year: " + txtbox_cyear.Text + Environment.NewLine + "Address: " + txtbox_address.Text + Environment.NewLine + "Contact Number: " + txtbox_cnumber.Text + 
            Environment.NewLine + "Gender: " + txtbox_gender.Text + Environment.NewLine + "Date of Birth: " + txtbox_dbirth.Text + Environment.NewLine + "Temperature: " + txtbox_temp.Text);
            txtbox_mname.Text = txtbox_time.Text = txtbox_gender.Text = txtbox_dbirth.Text = txtbox_cyear.Text = txtbox_fname.Text = 
            txtbox_lname.Text = txtbox_address.Text = txtbox_cnumber.Text = txtbox_temp.Text = "";
            detail.Close();
            Application.Restart();
        }
        
        private void txtbox_dbirth_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtbox_time_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_admin_Click(object sender, EventArgs e)
        {
            Form2 info = new Form2();
            info.ShowDialog();
        }

        private void btn_generate_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Info will Generated into QR Code");
            QRCodeGenerator QRCode = new QRCodeGenerator();
            QRCodeData Generate = QRCode.CreateQrCode(Environment.NewLine + "Date: " + dtp_date.Text + Environment.NewLine + "Time: " + txtbox_time.Text + Environment.NewLine + "" +
            Environment.NewLine + "First Name: " + txtbox_fname.Text + Environment.NewLine + "Middle Name: " + txtbox_mname.Text + Environment.NewLine + "Last Name: " + txtbox_lname.Text +
            Environment.NewLine + "Course and Year: " + txtbox_cyear.Text + Environment.NewLine + "Address: " + txtbox_address.Text + Environment.NewLine + "Contact Number: " + txtbox_cnumber.Text +
            Environment.NewLine + "Gender: " + txtbox_gender.Text + Environment.NewLine + "Date of Birth: " + txtbox_dbirth.Text + Environment.NewLine + "Temperature: " + txtbox_temp.Text, QRCodeGenerator.ECCLevel.Q);
            QRCode code = new QRCode(Generate);
            pcb_generate.Image = code.GetGraphic(4);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filterInfo in filterInfoCollection)
                cb_camera.Items.Add(filterInfo.Name);
            cb_camera.SelectedIndex = 0;
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            captureDevice = new VideoCaptureDevice(filterInfoCollection[cb_camera.SelectedIndex].MonikerString);
            captureDevice.NewFrame += CaptureDevice_NewFrame;
            captureDevice.Start();
            timer_scanner.Start();
        }

        private void CaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pcb_scanner.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
            Environment.Exit(0);
        }

        private void timer_scanner_Tick(object sender, EventArgs e)
        {
            if (pcb_scanner.Image != null)
            {
                BarcodeReader barcodeReader = new BarcodeReader();
                Result effect = barcodeReader.Decode((Bitmap)pcb_scanner.Image);
                if (effect != null)
                {
                    timer_scanner.Stop();
                    MessageBox.Show("Thank You For Your Response!");
                    string Info = effect.ToString();
                    StringBuilder builder = new StringBuilder(Info);
                    Info = effect.ToString();
                    string Shown = Info;
                    MessageBox.Show(Shown);
                    StreamWriter list = new StreamWriter(@"F:\Contact Tracing List\QRCode List\QRCode_Name.txt");
                    list.WriteLine(Info);
                    list.Close();
                    MessageBox.Show("This File Will be Saved in QRCode List Folder");
                    MessageBox.Show("This Application will now Restart");
                    Application.Restart();
                    {
                        
                    }
                }

                
            }
        }
    }
}