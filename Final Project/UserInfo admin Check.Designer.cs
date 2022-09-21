namespace Final_Project
{
    partial class userinformation
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
            this.userinfocheckgridview = new System.Windows.Forms.DataGridView();
            this.User_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contact_Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.User_Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.view = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.search = new System.Windows.Forms.TextBox();
            this.srch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.userinfocheckgridview)).BeginInit();
            this.SuspendLayout();
            // 
            // userinfocheckgridview
            // 
            this.userinfocheckgridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userinfocheckgridview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.User_Name,
            this.Contact_Number,
            this.User_Address});
            this.userinfocheckgridview.Location = new System.Drawing.Point(-3, 51);
            this.userinfocheckgridview.Name = "userinfocheckgridview";
            this.userinfocheckgridview.RowHeadersWidth = 51;
            this.userinfocheckgridview.RowTemplate.Height = 24;
            this.userinfocheckgridview.Size = new System.Drawing.Size(801, 396);
            this.userinfocheckgridview.TabIndex = 0;
            // 
            // User_Name
            // 
            this.User_Name.HeaderText = "User Name";
            this.User_Name.MinimumWidth = 6;
            this.User_Name.Name = "User_Name";
            this.User_Name.Width = 125;
            // 
            // Contact_Number
            // 
            this.Contact_Number.HeaderText = "Contact Number";
            this.Contact_Number.MinimumWidth = 6;
            this.Contact_Number.Name = "Contact_Number";
            this.Contact_Number.Width = 125;
            // 
            // User_Address
            // 
            this.User_Address.HeaderText = "Address";
            this.User_Address.MinimumWidth = 6;
            this.User_Address.Name = "User_Address";
            this.User_Address.Width = 125;
            // 
            // view
            // 
            this.view.BackgroundImage = global::Final_Project.Properties.Resources._053026334c7f11be0fba9924ff8aa100;
            this.view.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.view.Location = new System.Drawing.Point(352, 463);
            this.view.Name = "view";
            this.view.Size = new System.Drawing.Size(98, 38);
            this.view.TabIndex = 1;
            this.view.Text = "View";
            this.view.UseVisualStyleBackColor = true;
            this.view.Click += new System.EventHandler(this.button1_Click);
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.Maroon;
            this.back.Location = new System.Drawing.Point(10, 493);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(85, 38);
            this.back.TabIndex = 3;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Search Here";
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(119, 14);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(563, 22);
            this.search.TabIndex = 5;
            this.search.TextChanged += new System.EventHandler(this.search_TextChanged);
            // 
            // srch
            // 
            this.srch.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.srch.Location = new System.Drawing.Point(710, 8);
            this.srch.Name = "srch";
            this.srch.Size = new System.Drawing.Size(75, 32);
            this.srch.TabIndex = 6;
            this.srch.Text = "Search";
            this.srch.UseVisualStyleBackColor = false;
            this.srch.Click += new System.EventHandler(this.srch_Click);
            // 
            // userinformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Final_Project.Properties.Resources._053026334c7f11be0fba9924ff8aa100;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(797, 543);
            this.Controls.Add(this.srch);
            this.Controls.Add(this.search);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.back);
            this.Controls.Add(this.view);
            this.Controls.Add(this.userinfocheckgridview);
            this.Name = "userinformation";
            this.Text = "User Information";
            ((System.ComponentModel.ISupportInitialize)(this.userinfocheckgridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView userinfocheckgridview;
        private System.Windows.Forms.DataGridViewTextBoxColumn User_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contact_Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn User_Address;
        private System.Windows.Forms.Button view;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox search;
        private System.Windows.Forms.Button srch;
    }
}