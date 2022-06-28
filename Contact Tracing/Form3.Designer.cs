namespace Contact_Tracing
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.lbl_date = new System.Windows.Forms.Label();
            this.dtp_date = new System.Windows.Forms.DateTimePicker();
            this.txtbox_search = new System.Windows.Forms.TextBox();
            this.lbl_search = new System.Windows.Forms.Label();
            this.btn_date = new System.Windows.Forms.Button();
            this.btn_all = new System.Windows.Forms.Button();
            this.lbl_all = new System.Windows.Forms.Label();
            this.btn_search = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Font = new System.Drawing.Font("Swis721 BlkCn BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_date.Location = new System.Drawing.Point(147, 224);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(137, 22);
            this.lbl_date.TabIndex = 0;
            this.lbl_date.Text = "Search For Date";
            // 
            // dtp_date
            // 
            this.dtp_date.Location = new System.Drawing.Point(84, 261);
            this.dtp_date.Name = "dtp_date";
            this.dtp_date.Size = new System.Drawing.Size(262, 23);
            this.dtp_date.TabIndex = 1;
            // 
            // txtbox_search
            // 
            this.txtbox_search.Location = new System.Drawing.Point(43, 129);
            this.txtbox_search.Name = "txtbox_search";
            this.txtbox_search.Size = new System.Drawing.Size(701, 23);
            this.txtbox_search.TabIndex = 3;
            // 
            // lbl_search
            // 
            this.lbl_search.AutoSize = true;
            this.lbl_search.Font = new System.Drawing.Font("Swis721 BlkCn BT", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_search.Location = new System.Drawing.Point(283, 79);
            this.lbl_search.Name = "lbl_search";
            this.lbl_search.Size = new System.Drawing.Size(177, 42);
            this.lbl_search.TabIndex = 7;
            this.lbl_search.Text = "Search Bar";
            // 
            // btn_date
            // 
            this.btn_date.Font = new System.Drawing.Font("Swis721 BlkCn BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_date.Location = new System.Drawing.Point(147, 304);
            this.btn_date.Name = "btn_date";
            this.btn_date.Size = new System.Drawing.Size(135, 38);
            this.btn_date.TabIndex = 8;
            this.btn_date.Text = "Enter";
            this.btn_date.UseVisualStyleBackColor = true;
            this.btn_date.Click += new System.EventHandler(this.btn_date_Click);
            // 
            // btn_all
            // 
            this.btn_all.Font = new System.Drawing.Font("Swis721 BlkCn BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_all.Location = new System.Drawing.Point(526, 255);
            this.btn_all.Name = "btn_all";
            this.btn_all.Size = new System.Drawing.Size(135, 38);
            this.btn_all.TabIndex = 9;
            this.btn_all.Text = "Enter";
            this.btn_all.UseVisualStyleBackColor = true;
            this.btn_all.Click += new System.EventHandler(this.btn_all_Click);
            // 
            // lbl_all
            // 
            this.lbl_all.AutoSize = true;
            this.lbl_all.Font = new System.Drawing.Font("Swis721 BlkCn BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_all.Location = new System.Drawing.Point(397, 262);
            this.lbl_all.Name = "lbl_all";
            this.lbl_all.Size = new System.Drawing.Size(123, 22);
            this.lbl_all.TabIndex = 10;
            this.lbl_all.Text = "Search All List";
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.Color.Transparent;
            this.btn_search.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_search.BackgroundImage")));
            this.btn_search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_search.Location = new System.Drawing.Point(706, 129);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(38, 23);
            this.btn_search.TabIndex = 11;
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.lbl_all);
            this.Controls.Add(this.btn_all);
            this.Controls.Add(this.btn_date);
            this.Controls.Add(this.lbl_search);
            this.Controls.Add(this.txtbox_search);
            this.Controls.Add(this.dtp_date);
            this.Controls.Add(this.lbl_date);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form3";
            this.Text = "Admin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_date;
        private DateTimePicker dtp_date;
        private TextBox txtbox_search;
        private Label lbl_search;
        private Button btn_date;
        private Button btn_all;
        private Label lbl_all;
        private Button btn_search;
    }
}