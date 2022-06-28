namespace Contact_Tracing
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.lbl_user = new System.Windows.Forms.Label();
            this.txtbox_user = new System.Windows.Forms.TextBox();
            this.lbl_pass = new System.Windows.Forms.Label();
            this.txtbox_pass = new System.Windows.Forms.TextBox();
            this.btn_admin = new System.Windows.Forms.Button();
            this.picbox_admin = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_admin)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_user
            // 
            this.lbl_user.AutoSize = true;
            this.lbl_user.Font = new System.Drawing.Font("Swis721 BlkCn BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_user.Location = new System.Drawing.Point(224, 238);
            this.lbl_user.Name = "lbl_user";
            this.lbl_user.Size = new System.Drawing.Size(45, 19);
            this.lbl_user.TabIndex = 0;
            this.lbl_user.Text = "User:";
            // 
            // txtbox_user
            // 
            this.txtbox_user.Location = new System.Drawing.Point(275, 234);
            this.txtbox_user.Name = "txtbox_user";
            this.txtbox_user.Size = new System.Drawing.Size(245, 23);
            this.txtbox_user.TabIndex = 1;
            // 
            // lbl_pass
            // 
            this.lbl_pass.AutoSize = true;
            this.lbl_pass.Font = new System.Drawing.Font("Swis721 BlkCn BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_pass.Location = new System.Drawing.Point(191, 276);
            this.lbl_pass.Name = "lbl_pass";
            this.lbl_pass.Size = new System.Drawing.Size(78, 19);
            this.lbl_pass.TabIndex = 3;
            this.lbl_pass.Text = "Password:";
            // 
            // txtbox_pass
            // 
            this.txtbox_pass.Location = new System.Drawing.Point(275, 272);
            this.txtbox_pass.Name = "txtbox_pass";
            this.txtbox_pass.PasswordChar = '*';
            this.txtbox_pass.Size = new System.Drawing.Size(245, 23);
            this.txtbox_pass.TabIndex = 2;
            // 
            // btn_admin
            // 
            this.btn_admin.Font = new System.Drawing.Font("Swis721 Blk BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_admin.Location = new System.Drawing.Point(332, 301);
            this.btn_admin.Name = "btn_admin";
            this.btn_admin.Size = new System.Drawing.Size(132, 41);
            this.btn_admin.TabIndex = 4;
            this.btn_admin.Text = "Login";
            this.btn_admin.UseVisualStyleBackColor = true;
            this.btn_admin.Click += new System.EventHandler(this.btn_admin_Click);
            // 
            // picbox_admin
            // 
            this.picbox_admin.Image = ((System.Drawing.Image)(resources.GetObject("picbox_admin.Image")));
            this.picbox_admin.Location = new System.Drawing.Point(150, 12);
            this.picbox_admin.Name = "picbox_admin";
            this.picbox_admin.Size = new System.Drawing.Size(496, 184);
            this.picbox_admin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbox_admin.TabIndex = 6;
            this.picbox_admin.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.picbox_admin);
            this.Controls.Add(this.btn_admin);
            this.Controls.Add(this.txtbox_pass);
            this.Controls.Add(this.lbl_pass);
            this.Controls.Add(this.txtbox_user);
            this.Controls.Add(this.lbl_user);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Admin";
            ((System.ComponentModel.ISupportInitialize)(this.picbox_admin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_user;
        private TextBox txtbox_user;
        private Label lbl_pass;
        private TextBox txtbox_pass;
        private Button btn_admin;
        private PictureBox picbox_admin;
    }
}