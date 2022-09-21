namespace Final_Project
{
    partial class doctorconsultation
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
            this.label3 = new System.Windows.Forms.Label();
            this.did = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dnme = new System.Windows.Forms.TextBox();
            this.id = new System.Windows.Forms.Label();
            this.dname = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.Label();
            this.loc = new System.Windows.Forms.Label();
            this.ctime = new System.Windows.Forms.Label();
            this.apply = new System.Windows.Forms.Button();
            this.home = new System.Windows.Forms.Button();
            this.emal = new System.Windows.Forms.TextBox();
            this.lctn = new System.Windows.Forms.ComboBox();
            this.cntime = new System.Windows.Forms.ComboBox();
            this.leave = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.BackgroundImage = global::Final_Project.Properties.Resources._053026334c7f11be0fba9924ff8aa100;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.did);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.dnme);
            this.panel1.Controls.Add(this.id);
            this.panel1.Controls.Add(this.dname);
            this.panel1.Location = new System.Drawing.Point(-2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(963, 241);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(475, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(312, 16);
            this.label3.TabIndex = 39;
            this.label3.Text = "Search between 1-10 as well click on \"Fetch\" button.";
            // 
            // did
            // 
            this.did.FormattingEnabled = true;
            this.did.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.did.Location = new System.Drawing.Point(478, 152);
            this.did.Name = "did";
            this.did.Size = new System.Drawing.Size(219, 24);
            this.did.TabIndex = 38;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Final_Project.Properties.Resources._053026334c7f11be0fba9924ff8aa100;
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.button1.Location = new System.Drawing.Point(721, 144);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 33);
            this.button1.TabIndex = 36;
            this.button1.Text = "Fetch";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Goudy Stout", 13.8F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(353, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(471, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "NEED CONSULTATION?";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Final_Project.Properties.Resources.Doctor;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(246, 241);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // dnme
            // 
            this.dnme.Location = new System.Drawing.Point(478, 203);
            this.dnme.Name = "dnme";
            this.dnme.Size = new System.Drawing.Size(318, 22);
            this.dnme.TabIndex = 4;
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.BackColor = System.Drawing.SystemColors.ControlText;
            this.id.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.id.Location = new System.Drawing.Point(325, 152);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(61, 16);
            this.id.TabIndex = 0;
            this.id.Text = "Doctor Id";
            // 
            // dname
            // 
            this.dname.AutoSize = true;
            this.dname.BackColor = System.Drawing.SystemColors.ControlText;
            this.dname.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dname.Location = new System.Drawing.Point(325, 206);
            this.dname.Name = "dname";
            this.dname.Size = new System.Drawing.Size(87, 16);
            this.dname.TabIndex = 1;
            this.dname.Text = "Doctor Name";
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.BackColor = System.Drawing.SystemColors.ControlText;
            this.email.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.email.Location = new System.Drawing.Point(323, 256);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(41, 16);
            this.email.TabIndex = 2;
            this.email.Text = "Email";
            // 
            // loc
            // 
            this.loc.AutoSize = true;
            this.loc.BackColor = System.Drawing.SystemColors.ControlText;
            this.loc.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.loc.Location = new System.Drawing.Point(323, 308);
            this.loc.Name = "loc";
            this.loc.Size = new System.Drawing.Size(58, 16);
            this.loc.TabIndex = 3;
            this.loc.Text = "Location";
            // 
            // ctime
            // 
            this.ctime.AutoSize = true;
            this.ctime.BackColor = System.Drawing.SystemColors.ControlText;
            this.ctime.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ctime.Location = new System.Drawing.Point(323, 368);
            this.ctime.Name = "ctime";
            this.ctime.Size = new System.Drawing.Size(114, 16);
            this.ctime.TabIndex = 4;
            this.ctime.Text = "Consultation Time";
            // 
            // apply
            // 
            this.apply.BackColor = System.Drawing.SystemColors.Highlight;
            this.apply.Location = new System.Drawing.Point(739, 451);
            this.apply.Name = "apply";
            this.apply.Size = new System.Drawing.Size(135, 40);
            this.apply.TabIndex = 2;
            this.apply.Text = "Apply";
            this.apply.UseVisualStyleBackColor = false;
            this.apply.Click += new System.EventHandler(this.apply_Click);
            // 
            // home
            // 
            this.home.BackColor = System.Drawing.Color.RosyBrown;
            this.home.Location = new System.Drawing.Point(229, 451);
            this.home.Name = "home";
            this.home.Size = new System.Drawing.Size(135, 40);
            this.home.TabIndex = 3;
            this.home.Text = "Home";
            this.home.UseVisualStyleBackColor = false;
            this.home.Click += new System.EventHandler(this.home_Click);
            // 
            // emal
            // 
            this.emal.Location = new System.Drawing.Point(476, 253);
            this.emal.Name = "emal";
            this.emal.Size = new System.Drawing.Size(318, 22);
            this.emal.TabIndex = 6;
            // 
            // lctn
            // 
            this.lctn.FormattingEnabled = true;
            this.lctn.Items.AddRange(new object[] {
            "Dhaka",
            "Barishal",
            "Chittogong",
            "Comilla",
            "Coxs Bazar",
            "Sylhet ",
            "Chandpur",
            "Rajshahi"});
            this.lctn.Location = new System.Drawing.Point(476, 305);
            this.lctn.Name = "lctn";
            this.lctn.Size = new System.Drawing.Size(318, 24);
            this.lctn.TabIndex = 7;
            // 
            // cntime
            // 
            this.cntime.FormattingEnabled = true;
            this.cntime.Items.AddRange(new object[] {
            "9:00-11:00 AM",
            "5:00-7:00 PM",
            "7:00-9:00 PM"});
            this.cntime.Location = new System.Drawing.Point(476, 365);
            this.cntime.Name = "cntime";
            this.cntime.Size = new System.Drawing.Size(318, 24);
            this.cntime.TabIndex = 8;
            // 
            // leave
            // 
            this.leave.BackColor = System.Drawing.Color.DarkCyan;
            this.leave.Location = new System.Drawing.Point(489, 451);
            this.leave.Name = "leave";
            this.leave.Size = new System.Drawing.Size(135, 40);
            this.leave.TabIndex = 9;
            this.leave.Text = "Leave";
            this.leave.UseVisualStyleBackColor = false;
            this.leave.Click += new System.EventHandler(this.leave_Click);
            // 
            // doctorconsultation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BackgroundImage = global::Final_Project.Properties.Resources._053026334c7f11be0fba9924ff8aa100;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(962, 567);
            this.Controls.Add(this.leave);
            this.Controls.Add(this.cntime);
            this.Controls.Add(this.emal);
            this.Controls.Add(this.lctn);
            this.Controls.Add(this.apply);
            this.Controls.Add(this.home);
            this.Controls.Add(this.email);
            this.Controls.Add(this.ctime);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.loc);
            this.Name = "doctorconsultation";
            this.Text = "Doctor Consultation";
            this.Load += new System.EventHandler(this.doctorconsultation_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label dname;
        private System.Windows.Forms.Label id;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.Label loc;
        private System.Windows.Forms.Label ctime;
        private System.Windows.Forms.Button apply;
        private System.Windows.Forms.TextBox dnme;
        private System.Windows.Forms.Button home;
        private System.Windows.Forms.TextBox emal;
        private System.Windows.Forms.ComboBox lctn;
        private System.Windows.Forms.ComboBox cntime;
        private System.Windows.Forms.Button leave;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox did;
        private System.Windows.Forms.Label label3;
    }
}