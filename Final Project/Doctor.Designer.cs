namespace Final_Project
{
    partial class doctor
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.logout = new System.Windows.Forms.Button();
            this.about = new System.Windows.Forms.Button();
            this.profile = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.doctorgridview = new System.Windows.Forms.DataGridView();
            this.Doctor_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Location = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Consultation_Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viewp = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.search = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.TextBox();
            this.eml = new System.Windows.Forms.TextBox();
            this.loc = new System.Windows.Forms.TextBox();
            this.tm = new System.Windows.Forms.TextBox();
            this.fetch = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorgridview)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.logout);
            this.panel1.Controls.Add(this.about);
            this.panel1.Controls.Add(this.profile);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 599);
            this.panel1.TabIndex = 0;
            // 
            // logout
            // 
            this.logout.BackColor = System.Drawing.Color.DarkRed;
            this.logout.Location = new System.Drawing.Point(0, 553);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(300, 46);
            this.logout.TabIndex = 3;
            this.logout.Text = "Logout";
            this.logout.UseVisualStyleBackColor = false;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // about
            // 
            this.about.BackColor = System.Drawing.Color.RoyalBlue;
            this.about.Location = new System.Drawing.Point(0, 256);
            this.about.Name = "about";
            this.about.Size = new System.Drawing.Size(300, 42);
            this.about.TabIndex = 2;
            this.about.Text = "About";
            this.about.UseVisualStyleBackColor = false;
            // 
            // profile
            // 
            this.profile.BackColor = System.Drawing.Color.RoyalBlue;
            this.profile.Location = new System.Drawing.Point(0, 219);
            this.profile.Name = "profile";
            this.profile.Size = new System.Drawing.Size(300, 41);
            this.profile.TabIndex = 1;
            this.profile.Text = "Profile";
            this.profile.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Final_Project.Properties.Resources.Doctor;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 218);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // doctorgridview
            // 
            this.doctorgridview.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.doctorgridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.doctorgridview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Doctor_Id,
            this.Email,
            this.Location,
            this.Consultation_Time});
            this.doctorgridview.Location = new System.Drawing.Point(299, 58);
            this.doctorgridview.Name = "doctorgridview";
            this.doctorgridview.RowHeadersWidth = 51;
            this.doctorgridview.RowTemplate.Height = 24;
            this.doctorgridview.Size = new System.Drawing.Size(665, 286);
            this.doctorgridview.TabIndex = 1;
            // 
            // Doctor_Id
            // 
            this.Doctor_Id.HeaderText = "Doctor Id";
            this.Doctor_Id.MinimumWidth = 6;
            this.Doctor_Id.Name = "Doctor_Id";
            this.Doctor_Id.Width = 125;
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 6;
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Width = 125;
            // 
            // Location
            // 
            this.Location.HeaderText = "Location";
            this.Location.MinimumWidth = 6;
            this.Location.Name = "Location";
            this.Location.ReadOnly = true;
            this.Location.Width = 125;
            // 
            // Consultation_Time
            // 
            this.Consultation_Time.HeaderText = "Time";
            this.Consultation_Time.MinimumWidth = 6;
            this.Consultation_Time.Name = "Consultation_Time";
            this.Consultation_Time.ReadOnly = true;
            this.Consultation_Time.Width = 125;
            // 
            // viewp
            // 
            this.viewp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.viewp.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.viewp.Location = new System.Drawing.Point(576, 350);
            this.viewp.Name = "viewp";
            this.viewp.Size = new System.Drawing.Size(139, 40);
            this.viewp.TabIndex = 2;
            this.viewp.Text = "View Patient List";
            this.viewp.UseVisualStyleBackColor = false;
            this.viewp.Click += new System.EventHandler(this.viewp_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(713, 519);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 40);
            this.button1.TabIndex = 3;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(335, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Search Here";
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(435, 21);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(338, 22);
            this.search.TabIndex = 5;
            this.search.TextChanged += new System.EventHandler(this.search_TextChanged);
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::Final_Project.Properties.Resources._053026334c7f11be0fba9924ff8aa100;
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button2.Location = new System.Drawing.Point(800, 16);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 32);
            this.button2.TabIndex = 6;
            this.button2.Text = "Search";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(335, 415);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "ID";
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(419, 412);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(113, 22);
            this.id.TabIndex = 11;
            // 
            // eml
            // 
            this.eml.Location = new System.Drawing.Point(419, 459);
            this.eml.Name = "eml";
            this.eml.Size = new System.Drawing.Size(206, 22);
            this.eml.TabIndex = 12;
            // 
            // loc
            // 
            this.loc.Location = new System.Drawing.Point(419, 497);
            this.loc.Name = "loc";
            this.loc.Size = new System.Drawing.Size(206, 22);
            this.loc.TabIndex = 13;
            // 
            // tm
            // 
            this.tm.Location = new System.Drawing.Point(419, 537);
            this.tm.Name = "tm";
            this.tm.Size = new System.Drawing.Size(206, 22);
            this.tm.TabIndex = 14;
            // 
            // fetch
            // 
            this.fetch.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.fetch.Location = new System.Drawing.Point(550, 410);
            this.fetch.Name = "fetch";
            this.fetch.Size = new System.Drawing.Size(75, 24);
            this.fetch.TabIndex = 15;
            this.fetch.Text = "Fetch";
            this.fetch.UseVisualStyleBackColor = false;
            this.fetch.Click += new System.EventHandler(this.fetch_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(335, 459);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(335, 497);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 16);
            this.label4.TabIndex = 17;
            this.label4.Text = "Location";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(335, 540);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 16);
            this.label5.TabIndex = 18;
            this.label5.Text = "Time";
            // 
            // doctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BackgroundImage = global::Final_Project.Properties.Resources._053026334c7f11be0fba9924ff8aa100;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(962, 596);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.fetch);
            this.Controls.Add(this.tm);
            this.Controls.Add(this.loc);
            this.Controls.Add(this.eml);
            this.Controls.Add(this.id);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.search);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.viewp);
            this.Controls.Add(this.doctorgridview);
            this.Controls.Add(this.panel1);
            this.Name = "doctor";
            this.Text = "Doctor";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorgridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.Button about;
        private System.Windows.Forms.Button profile;
        private System.Windows.Forms.DataGridView doctorgridview;
        private System.Windows.Forms.Button viewp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Doctor_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Location;
        private System.Windows.Forms.DataGridViewTextBoxColumn Consultation_Time;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox search;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.TextBox eml;
        private System.Windows.Forms.TextBox loc;
        private System.Windows.Forms.TextBox tm;
        private System.Windows.Forms.Button fetch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}