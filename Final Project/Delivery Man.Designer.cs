namespace Final_Project
{
    partial class deliveryman
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
            this.deliverygridview = new System.Windows.Forms.DataGridView();
            this.vieworder = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.search = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.M_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Medicine_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliverygridview)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.logout);
            this.panel1.Controls.Add(this.about);
            this.panel1.Controls.Add(this.profile);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-3, -4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(354, 577);
            this.panel1.TabIndex = 0;
            // 
            // logout
            // 
            this.logout.BackColor = System.Drawing.Color.DarkRed;
            this.logout.Location = new System.Drawing.Point(3, 528);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(351, 46);
            this.logout.TabIndex = 3;
            this.logout.Text = "Logout";
            this.logout.UseVisualStyleBackColor = false;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // about
            // 
            this.about.BackColor = System.Drawing.Color.RoyalBlue;
            this.about.Location = new System.Drawing.Point(0, 236);
            this.about.Name = "about";
            this.about.Size = new System.Drawing.Size(354, 40);
            this.about.TabIndex = 2;
            this.about.Text = "About";
            this.about.UseVisualStyleBackColor = false;
            // 
            // profile
            // 
            this.profile.BackColor = System.Drawing.Color.RoyalBlue;
            this.profile.Location = new System.Drawing.Point(0, 200);
            this.profile.Name = "profile";
            this.profile.Size = new System.Drawing.Size(354, 40);
            this.profile.TabIndex = 1;
            this.profile.Text = "Profile";
            this.profile.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Final_Project.Properties.Resources.delivery;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(351, 199);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // deliverygridview
            // 
            this.deliverygridview.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.deliverygridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.deliverygridview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.M_id,
            this.Medicine_Name,
            this.Quantity,
            this.Amount,
            this.Address});
            this.deliverygridview.Location = new System.Drawing.Point(351, 34);
            this.deliverygridview.Name = "deliverygridview";
            this.deliverygridview.RowHeadersWidth = 51;
            this.deliverygridview.RowTemplate.Height = 24;
            this.deliverygridview.Size = new System.Drawing.Size(618, 475);
            this.deliverygridview.TabIndex = 1;
            // 
            // vieworder
            // 
            this.vieworder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.vieworder.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.vieworder.Location = new System.Drawing.Point(611, 515);
            this.vieworder.Name = "vieworder";
            this.vieworder.Size = new System.Drawing.Size(134, 40);
            this.vieworder.TabIndex = 2;
            this.vieworder.Text = "View Order";
            this.vieworder.UseVisualStyleBackColor = false;
            this.vieworder.Click += new System.EventHandler(this.vieworder_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(357, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Search Here";
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(446, 6);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(370, 22);
            this.search.TabIndex = 6;
            this.search.TextChanged += new System.EventHandler(this.search_TextChanged);
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::Final_Project.Properties.Resources._053026334c7f11be0fba9924ff8aa100;
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button2.Location = new System.Drawing.Point(836, 1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 32);
            this.button2.TabIndex = 7;
            this.button2.Text = "Search";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // M_id
            // 
            this.M_id.HeaderText = "ID";
            this.M_id.MinimumWidth = 6;
            this.M_id.Name = "M_id";
            this.M_id.Width = 125;
            // 
            // Medicine_Name
            // 
            this.Medicine_Name.HeaderText = "Medicine Name";
            this.Medicine_Name.MinimumWidth = 6;
            this.Medicine_Name.Name = "Medicine_Name";
            this.Medicine_Name.Width = 125;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.MinimumWidth = 6;
            this.Quantity.Name = "Quantity";
            this.Quantity.Width = 125;
            // 
            // Amount
            // 
            this.Amount.HeaderText = "Amount";
            this.Amount.MinimumWidth = 6;
            this.Amount.Name = "Amount";
            this.Amount.Width = 125;
            // 
            // Address
            // 
            this.Address.HeaderText = "Address";
            this.Address.MinimumWidth = 6;
            this.Address.Name = "Address";
            this.Address.Width = 125;
            // 
            // deliveryman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BackgroundImage = global::Final_Project.Properties.Resources._053026334c7f11be0fba9924ff8aa100;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(962, 567);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.search);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.vieworder);
            this.Controls.Add(this.deliverygridview);
            this.Controls.Add(this.panel1);
            this.Name = "deliveryman";
            this.Text = "Delivery Man";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliverygridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.Button about;
        private System.Windows.Forms.Button profile;
        private System.Windows.Forms.DataGridView deliverygridview;
        private System.Windows.Forms.Button vieworder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox search;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn M_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Medicine_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
    }
}