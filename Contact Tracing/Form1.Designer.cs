﻿namespace Contact_Tracing
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
            this.lbl_mname = new System.Windows.Forms.Label();
            this.lbl_time = new System.Windows.Forms.Label();
            this.lbl_cyear = new System.Windows.Forms.Label();
            this.lbl_fname = new System.Windows.Forms.Label();
            this.lbl_lname = new System.Windows.Forms.Label();
            this.lbl_address = new System.Windows.Forms.Label();
            this.lbl_cnumber = new System.Windows.Forms.Label();
            this.lbl_temp = new System.Windows.Forms.Label();
            this.lbl_gender = new System.Windows.Forms.Label();
            this.lbl_dbirth = new System.Windows.Forms.Label();
            this.txtbox_mname = new System.Windows.Forms.TextBox();
            this.txtbox_time = new System.Windows.Forms.TextBox();
            this.txtbox_cyear = new System.Windows.Forms.TextBox();
            this.txtbox_fname = new System.Windows.Forms.TextBox();
            this.txtbox_lname = new System.Windows.Forms.TextBox();
            this.txtbox_address = new System.Windows.Forms.TextBox();
            this.txtbox_cnumber = new System.Windows.Forms.TextBox();
            this.txtbox_temp = new System.Windows.Forms.TextBox();
            this.txtbox_gender = new System.Windows.Forms.TextBox();
            this.txtbox_dbirth = new System.Windows.Forms.TextBox();
            this.btn_submit = new System.Windows.Forms.Button();
            this.dtp_date = new System.Windows.Forms.DateTimePicker();
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
            // lbl_mname
            // 
            this.lbl_mname.AutoSize = true;
            this.lbl_mname.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lbl_mname.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_mname.Location = new System.Drawing.Point(6, 218);
            this.lbl_mname.Name = "lbl_mname";
            this.lbl_mname.Size = new System.Drawing.Size(110, 18);
            this.lbl_mname.TabIndex = 2;
            this.lbl_mname.Text = "Middle Name:";
            // 
            // lbl_time
            // 
            this.lbl_time.AutoSize = true;
            this.lbl_time.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lbl_time.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_time.Location = new System.Drawing.Point(6, 383);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(51, 18);
            this.lbl_time.TabIndex = 3;
            this.lbl_time.Text = "Time:";
            // 
            // lbl_cyear
            // 
            this.lbl_cyear.AutoSize = true;
            this.lbl_cyear.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lbl_cyear.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_cyear.Location = new System.Drawing.Point(6, 282);
            this.lbl_cyear.Name = "lbl_cyear";
            this.lbl_cyear.Size = new System.Drawing.Size(137, 18);
            this.lbl_cyear.TabIndex = 4;
            this.lbl_cyear.Text = "Course and Year:";
            // 
            // lbl_fname
            // 
            this.lbl_fname.AutoSize = true;
            this.lbl_fname.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lbl_fname.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_fname.Location = new System.Drawing.Point(6, 187);
            this.lbl_fname.Name = "lbl_fname";
            this.lbl_fname.Size = new System.Drawing.Size(96, 18);
            this.lbl_fname.TabIndex = 5;
            this.lbl_fname.Text = "First Name:";
            // 
            // lbl_lname
            // 
            this.lbl_lname.AutoSize = true;
            this.lbl_lname.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lbl_lname.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_lname.Location = new System.Drawing.Point(6, 250);
            this.lbl_lname.Name = "lbl_lname";
            this.lbl_lname.Size = new System.Drawing.Size(95, 18);
            this.lbl_lname.TabIndex = 6;
            this.lbl_lname.Text = "Last Name:";
            // 
            // lbl_address
            // 
            this.lbl_address.AutoSize = true;
            this.lbl_address.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lbl_address.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_address.Location = new System.Drawing.Point(6, 316);
            this.lbl_address.Name = "lbl_address";
            this.lbl_address.Size = new System.Drawing.Size(74, 18);
            this.lbl_address.TabIndex = 7;
            this.lbl_address.Text = "Address:";
            this.lbl_address.Click += new System.EventHandler(this.label8_Click);
            // 
            // lbl_cnumber
            // 
            this.lbl_cnumber.AutoSize = true;
            this.lbl_cnumber.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lbl_cnumber.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_cnumber.Location = new System.Drawing.Point(6, 350);
            this.lbl_cnumber.Name = "lbl_cnumber";
            this.lbl_cnumber.Size = new System.Drawing.Size(138, 18);
            this.lbl_cnumber.TabIndex = 8;
            this.lbl_cnumber.Text = "Contact Number:";
            // 
            // lbl_temp
            // 
            this.lbl_temp.AutoSize = true;
            this.lbl_temp.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lbl_temp.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_temp.Location = new System.Drawing.Point(496, 245);
            this.lbl_temp.Name = "lbl_temp";
            this.lbl_temp.Size = new System.Drawing.Size(109, 18);
            this.lbl_temp.TabIndex = 9;
            this.lbl_temp.Text = "Temperature:";
            // 
            // lbl_gender
            // 
            this.lbl_gender.AutoSize = true;
            this.lbl_gender.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lbl_gender.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_gender.Location = new System.Drawing.Point(524, 182);
            this.lbl_gender.Name = "lbl_gender";
            this.lbl_gender.Size = new System.Drawing.Size(69, 18);
            this.lbl_gender.TabIndex = 10;
            this.lbl_gender.Text = "Gender:";
            // 
            // lbl_dbirth
            // 
            this.lbl_dbirth.AutoSize = true;
            this.lbl_dbirth.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lbl_dbirth.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_dbirth.Location = new System.Drawing.Point(496, 214);
            this.lbl_dbirth.Name = "lbl_dbirth";
            this.lbl_dbirth.Size = new System.Drawing.Size(109, 18);
            this.lbl_dbirth.TabIndex = 11;
            this.lbl_dbirth.Text = "Date of Birth:";
            // 
            // txtbox_mname
            // 
            this.txtbox_mname.Location = new System.Drawing.Point(136, 214);
            this.txtbox_mname.Name = "txtbox_mname";
            this.txtbox_mname.Size = new System.Drawing.Size(210, 23);
            this.txtbox_mname.TabIndex = 2;
            // 
            // txtbox_time
            // 
            this.txtbox_time.Location = new System.Drawing.Point(63, 380);
            this.txtbox_time.Name = "txtbox_time";
            this.txtbox_time.Size = new System.Drawing.Size(77, 23);
            this.txtbox_time.TabIndex = 7;
            this.txtbox_time.TextChanged += new System.EventHandler(this.txtbox_time_TextChanged);
            // 
            // txtbox_cyear
            // 
            this.txtbox_cyear.Location = new System.Drawing.Point(161, 277);
            this.txtbox_cyear.Name = "txtbox_cyear";
            this.txtbox_cyear.Size = new System.Drawing.Size(107, 23);
            this.txtbox_cyear.TabIndex = 4;
            // 
            // txtbox_fname
            // 
            this.txtbox_fname.Location = new System.Drawing.Point(108, 182);
            this.txtbox_fname.Name = "txtbox_fname";
            this.txtbox_fname.Size = new System.Drawing.Size(193, 23);
            this.txtbox_fname.TabIndex = 1;
            // 
            // txtbox_lname
            // 
            this.txtbox_lname.Location = new System.Drawing.Point(122, 245);
            this.txtbox_lname.Name = "txtbox_lname";
            this.txtbox_lname.Size = new System.Drawing.Size(224, 23);
            this.txtbox_lname.TabIndex = 3;
            // 
            // txtbox_address
            // 
            this.txtbox_address.Location = new System.Drawing.Point(86, 311);
            this.txtbox_address.Name = "txtbox_address";
            this.txtbox_address.Size = new System.Drawing.Size(392, 23);
            this.txtbox_address.TabIndex = 5;
            // 
            // txtbox_cnumber
            // 
            this.txtbox_cnumber.Location = new System.Drawing.Point(161, 345);
            this.txtbox_cnumber.Name = "txtbox_cnumber";
            this.txtbox_cnumber.Size = new System.Drawing.Size(235, 23);
            this.txtbox_cnumber.TabIndex = 6;
            // 
            // txtbox_temp
            // 
            this.txtbox_temp.Location = new System.Drawing.Point(611, 245);
            this.txtbox_temp.Name = "txtbox_temp";
            this.txtbox_temp.Size = new System.Drawing.Size(159, 23);
            this.txtbox_temp.TabIndex = 10;
            // 
            // txtbox_gender
            // 
            this.txtbox_gender.Location = new System.Drawing.Point(599, 182);
            this.txtbox_gender.Name = "txtbox_gender";
            this.txtbox_gender.Size = new System.Drawing.Size(83, 23);
            this.txtbox_gender.TabIndex = 8;
            // 
            // txtbox_dbirth
            // 
            this.txtbox_dbirth.Location = new System.Drawing.Point(611, 211);
            this.txtbox_dbirth.Name = "txtbox_dbirth";
            this.txtbox_dbirth.Size = new System.Drawing.Size(154, 23);
            this.txtbox_dbirth.TabIndex = 9;
            this.txtbox_dbirth.TextChanged += new System.EventHandler(this.txtbox_dbirth_TextChanged);
            // 
            // btn_submit
            // 
            this.btn_submit.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_submit.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_submit.Location = new System.Drawing.Point(611, 295);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(166, 46);
            this.btn_submit.TabIndex = 11;
            this.btn_submit.Text = "Submit";
            this.btn_submit.UseVisualStyleBackColor = false;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // dtp_date
            // 
            this.dtp_date.Location = new System.Drawing.Point(146, 380);
            this.dtp_date.Name = "dtp_date";
            this.dtp_date.Size = new System.Drawing.Size(207, 23);
            this.dtp_date.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(917, 464);
            this.Controls.Add(this.dtp_date);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.txtbox_dbirth);
            this.Controls.Add(this.txtbox_gender);
            this.Controls.Add(this.txtbox_temp);
            this.Controls.Add(this.txtbox_cnumber);
            this.Controls.Add(this.txtbox_address);
            this.Controls.Add(this.txtbox_lname);
            this.Controls.Add(this.txtbox_fname);
            this.Controls.Add(this.txtbox_cyear);
            this.Controls.Add(this.txtbox_time);
            this.Controls.Add(this.txtbox_mname);
            this.Controls.Add(this.lbl_dbirth);
            this.Controls.Add(this.lbl_gender);
            this.Controls.Add(this.lbl_temp);
            this.Controls.Add(this.lbl_cnumber);
            this.Controls.Add(this.lbl_address);
            this.Controls.Add(this.lbl_lname);
            this.Controls.Add(this.lbl_fname);
            this.Controls.Add(this.lbl_cyear);
            this.Controls.Add(this.lbl_time);
            this.Controls.Add(this.lbl_mname);
            this.Controls.Add(this.lbl_ctracing);
            this.Name = "Form1";
            this.Text = "Contact Tracing";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label lbl_ctracing;
        private Label lbl_mname;
        private Label lbl_time;
        private Label lbl_cyear;
        private Label lbl_fname;
        private Label lbl_lname;
        private Label lbl_address;
        private Label lbl_cnumber;
        private Label lbl_temp;
        private Label lbl_gender;
        private Label lbl_dbirth;
        private TextBox txtbox_mname;
        private TextBox txtbox_time;
        private TextBox txtbox_cyear;
        private TextBox txtbox_fname;
        private TextBox txtbox_lname;
        private TextBox txtbox_address;
        private TextBox txtbox_cnumber;
        private TextBox txtbox_temp;
        private TextBox txtbox_gender;
        private TextBox txtbox_dbirth;
        private Button btn_submit;
        private DateTimePicker dtp_date;
    }
}