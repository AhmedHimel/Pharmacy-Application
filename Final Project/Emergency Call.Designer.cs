namespace Final_Project
{
    partial class emergencycall
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.vecontact = new System.Windows.Forms.Button();
            this.ecallgridview = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.Cid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Service_Provider = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contact_Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Area = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.search = new System.Windows.Forms.TextBox();
            this.srch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ecallgridview)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Final_Project.Properties.Resources.Emergency_calls;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(256, 561);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // vecontact
            // 
            this.vecontact.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.vecontact.BackgroundImage = global::Final_Project.Properties.Resources._053026334c7f11be0fba9924ff8aa100;
            this.vecontact.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.vecontact.Location = new System.Drawing.Point(481, 448);
            this.vecontact.Name = "vecontact";
            this.vecontact.Size = new System.Drawing.Size(172, 58);
            this.vecontact.TabIndex = 2;
            this.vecontact.Text = "View Emergency Contact";
            this.vecontact.UseVisualStyleBackColor = false;
            this.vecontact.Click += new System.EventHandler(this.vecontact_Click);
            // 
            // ecallgridview
            // 
            this.ecallgridview.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.ecallgridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ecallgridview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cid,
            this.Service_Provider,
            this.Contact_Number,
            this.Area});
            this.ecallgridview.Location = new System.Drawing.Point(262, 42);
            this.ecallgridview.Name = "ecallgridview";
            this.ecallgridview.RowHeadersWidth = 51;
            this.ecallgridview.RowTemplate.Height = 24;
            this.ecallgridview.Size = new System.Drawing.Size(547, 400);
            this.ecallgridview.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.RosyBrown;
            this.button1.Location = new System.Drawing.Point(271, 500);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 42);
            this.button1.TabIndex = 4;
            this.button1.Text = "Home";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Cid
            // 
            this.Cid.HeaderText = "Id";
            this.Cid.MinimumWidth = 6;
            this.Cid.Name = "Cid";
            this.Cid.Width = 125;
            // 
            // Service_Provider
            // 
            this.Service_Provider.HeaderText = "Employee Name";
            this.Service_Provider.MinimumWidth = 6;
            this.Service_Provider.Name = "Service_Provider";
            this.Service_Provider.Width = 125;
            // 
            // Contact_Number
            // 
            this.Contact_Number.HeaderText = "Number";
            this.Contact_Number.MinimumWidth = 6;
            this.Contact_Number.Name = "Contact_Number";
            this.Contact_Number.Width = 125;
            // 
            // Area
            // 
            this.Area.HeaderText = "Area";
            this.Area.MinimumWidth = 6;
            this.Area.Name = "Area";
            this.Area.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(277, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Search Here";
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(366, 13);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(348, 22);
            this.search.TabIndex = 6;
            this.search.TextChanged += new System.EventHandler(this.search_TextChanged);
            // 
            // srch
            // 
            this.srch.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.srch.Location = new System.Drawing.Point(720, 13);
            this.srch.Name = "srch";
            this.srch.Size = new System.Drawing.Size(75, 23);
            this.srch.TabIndex = 7;
            this.srch.Text = "Search";
            this.srch.UseVisualStyleBackColor = false;
            this.srch.Click += new System.EventHandler(this.srch_Click);
            // 
            // emergencycall
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BackgroundImage = global::Final_Project.Properties.Resources._053026334c7f11be0fba9924ff8aa100;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(807, 554);
            this.Controls.Add(this.srch);
            this.Controls.Add(this.search);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ecallgridview);
            this.Controls.Add(this.vecontact);
            this.Controls.Add(this.pictureBox1);
            this.Name = "emergencycall";
            this.Text = "Emergencey Call";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ecallgridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button vecontact;
        private System.Windows.Forms.DataGridView ecallgridview;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Service_Provider;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contact_Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Area;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox search;
        private System.Windows.Forms.Button srch;
    }
}