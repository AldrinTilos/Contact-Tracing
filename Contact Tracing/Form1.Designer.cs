namespace Contact_Tracing
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbl_ctracing = new System.Windows.Forms.Label();
            this.lbl_date = new System.Windows.Forms.Label();
            this.lbl_time = new System.Windows.Forms.Label();
            this.lbl_gsection = new System.Windows.Forms.Label();
            this.lbl_pname = new System.Windows.Forms.Label();
            this.lbl_gname = new System.Windows.Forms.Label();
            this.lbl_address = new System.Windows.Forms.Label();
            this.lbl_cnumber = new System.Windows.Forms.Label();
            this.lbl_temp = new System.Windows.Forms.Label();
            this.lbl_gender = new System.Windows.Forms.Label();
            this.lbl_dbirth = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.btn_submit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_ctracing
            // 
            this.lbl_ctracing.AutoSize = true;
            this.lbl_ctracing.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lbl_ctracing.Font = new System.Drawing.Font("Verdana", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.lbl_ctracing.Location = new System.Drawing.Point(336, 134);
            this.lbl_ctracing.Name = "lbl_ctracing";
            this.lbl_ctracing.Size = new System.Drawing.Size(269, 29);
            this.lbl_ctracing.TabIndex = 1;
            this.lbl_ctracing.Text = "CONTACT TRACING";
            this.lbl_ctracing.Click += new System.EventHandler(this.lbl_ctracing_Click);
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lbl_date.Location = new System.Drawing.Point(108, 187);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(34, 15);
            this.lbl_date.TabIndex = 2;
            this.lbl_date.Text = "Date:";
            // 
            // lbl_time
            // 
            this.lbl_time.AutoSize = true;
            this.lbl_time.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lbl_time.Location = new System.Drawing.Point(108, 218);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(36, 15);
            this.lbl_time.TabIndex = 3;
            this.lbl_time.Text = "Time:";
            // 
            // lbl_gsection
            // 
            this.lbl_gsection.AutoSize = true;
            this.lbl_gsection.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lbl_gsection.Location = new System.Drawing.Point(36, 245);
            this.lbl_gsection.Name = "lbl_gsection";
            this.lbl_gsection.Size = new System.Drawing.Size(106, 15);
            this.lbl_gsection.TabIndex = 4;
            this.lbl_gsection.Text = "Grade and Section:";
            // 
            // lbl_pname
            // 
            this.lbl_pname.AutoSize = true;
            this.lbl_pname.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lbl_pname.Location = new System.Drawing.Point(56, 272);
            this.lbl_pname.Name = "lbl_pname";
            this.lbl_pname.Size = new System.Drawing.Size(86, 15);
            this.lbl_pname.TabIndex = 5;
            this.lbl_pname.Text = "Name of Pupil:";
            // 
            // lbl_gname
            // 
            this.lbl_gname.AutoSize = true;
            this.lbl_gname.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lbl_gname.Location = new System.Drawing.Point(26, 301);
            this.lbl_gname.Name = "lbl_gname";
            this.lbl_gname.Size = new System.Drawing.Size(146, 15);
            this.lbl_gname.TabIndex = 6;
            this.lbl_gname.Text = "Name of Guardian/Parent:";
            // 
            // lbl_address
            // 
            this.lbl_address.AutoSize = true;
            this.lbl_address.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lbl_address.Location = new System.Drawing.Point(90, 333);
            this.lbl_address.Name = "lbl_address";
            this.lbl_address.Size = new System.Drawing.Size(52, 15);
            this.lbl_address.TabIndex = 7;
            this.lbl_address.Text = "Address:";
            this.lbl_address.Click += new System.EventHandler(this.label8_Click);
            // 
            // lbl_cnumber
            // 
            this.lbl_cnumber.AutoSize = true;
            this.lbl_cnumber.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lbl_cnumber.Location = new System.Drawing.Point(43, 367);
            this.lbl_cnumber.Name = "lbl_cnumber";
            this.lbl_cnumber.Size = new System.Drawing.Size(99, 15);
            this.lbl_cnumber.TabIndex = 8;
            this.lbl_cnumber.Text = "Contact Number:";
            // 
            // lbl_temp
            // 
            this.lbl_temp.AutoSize = true;
            this.lbl_temp.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lbl_temp.Location = new System.Drawing.Point(66, 401);
            this.lbl_temp.Name = "lbl_temp";
            this.lbl_temp.Size = new System.Drawing.Size(76, 15);
            this.lbl_temp.TabIndex = 9;
            this.lbl_temp.Text = "Temperature:";
            // 
            // lbl_gender
            // 
            this.lbl_gender.AutoSize = true;
            this.lbl_gender.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lbl_gender.Location = new System.Drawing.Point(524, 182);
            this.lbl_gender.Name = "lbl_gender";
            this.lbl_gender.Size = new System.Drawing.Size(48, 15);
            this.lbl_gender.TabIndex = 10;
            this.lbl_gender.Text = "Gender:";
            // 
            // lbl_dbirth
            // 
            this.lbl_dbirth.AutoSize = true;
            this.lbl_dbirth.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lbl_dbirth.Location = new System.Drawing.Point(496, 214);
            this.lbl_dbirth.Name = "lbl_dbirth";
            this.lbl_dbirth.Size = new System.Drawing.Size(76, 15);
            this.lbl_dbirth.TabIndex = 11;
            this.lbl_dbirth.Text = "Date of Birth:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(150, 182);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(122, 23);
            this.textBox1.TabIndex = 12;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(150, 211);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(77, 23);
            this.textBox2.TabIndex = 13;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(148, 240);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(107, 23);
            this.textBox3.TabIndex = 14;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(148, 269);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(193, 23);
            this.textBox4.TabIndex = 15;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(178, 298);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(181, 23);
            this.textBox5.TabIndex = 16;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(148, 330);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(370, 23);
            this.textBox6.TabIndex = 17;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(148, 364);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(235, 23);
            this.textBox7.TabIndex = 18;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(148, 393);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(159, 23);
            this.textBox8.TabIndex = 19;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(578, 179);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(60, 23);
            this.textBox9.TabIndex = 20;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(578, 211);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(154, 23);
            this.textBox10.TabIndex = 21;
            // 
            // btn_submit
            // 
            this.btn_submit.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_submit.Location = new System.Drawing.Point(618, 367);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(166, 46);
            this.btn_submit.TabIndex = 22;
            this.btn_submit.Text = "Submit";
            this.btn_submit.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(917, 464);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbl_dbirth);
            this.Controls.Add(this.lbl_gender);
            this.Controls.Add(this.lbl_temp);
            this.Controls.Add(this.lbl_cnumber);
            this.Controls.Add(this.lbl_address);
            this.Controls.Add(this.lbl_gname);
            this.Controls.Add(this.lbl_pname);
            this.Controls.Add(this.lbl_gsection);
            this.Controls.Add(this.lbl_time);
            this.Controls.Add(this.lbl_date);
            this.Controls.Add(this.lbl_ctracing);
            this.Name = "Form1";
            this.Text = "Contact Tracing";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label lbl_ctracing;
        private Label lbl_date;
        private Label lbl_time;
        private Label lbl_gsection;
        private Label lbl_pname;
        private Label lbl_gname;
        private Label lbl_address;
        private Label lbl_cnumber;
        private Label lbl_temp;
        private Label lbl_gender;
        private Label lbl_dbirth;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private TextBox textBox8;
        private TextBox textBox9;
        private TextBox textBox10;
        private Button btn_submit;
    }
}