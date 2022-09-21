namespace Final_Project
{
    partial class empinfo
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
            this.dcinfoecheckgridview = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Employee_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dmview = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.ddelete = new System.Windows.Forms.Button();
            this.dminfocheckgridview = new System.Windows.Forms.DataGridView();
            this.i = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dview = new System.Windows.Forms.Button();
            this.dmdel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dcid = new System.Windows.Forms.TextBox();
            this.dcname = new System.Windows.Forms.TextBox();
            this.dlname = new System.Windows.Forms.TextBox();
            this.dlid = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.src = new System.Windows.Forms.TextBox();
            this.srch = new System.Windows.Forms.TextBox();
            this.search = new System.Windows.Forms.Button();
            this.DLsrch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dcinfoecheckgridview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dminfocheckgridview)).BeginInit();
            this.SuspendLayout();
            // 
            // dcinfoecheckgridview
            // 
            this.dcinfoecheckgridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dcinfoecheckgridview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Employee_Name});
            this.dcinfoecheckgridview.Location = new System.Drawing.Point(0, 38);
            this.dcinfoecheckgridview.Name = "dcinfoecheckgridview";
            this.dcinfoecheckgridview.RowHeadersWidth = 51;
            this.dcinfoecheckgridview.RowTemplate.Height = 24;
            this.dcinfoecheckgridview.Size = new System.Drawing.Size(348, 269);
            this.dcinfoecheckgridview.TabIndex = 0;
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.Width = 125;
            // 
            // Employee_Name
            // 
            this.Employee_Name.HeaderText = "Doctor";
            this.Employee_Name.MinimumWidth = 6;
            this.Employee_Name.Name = "Employee_Name";
            this.Employee_Name.Width = 125;
            // 
            // dmview
            // 
            this.dmview.BackgroundImage = global::Final_Project.Properties.Resources._053026334c7f11be0fba9924ff8aa100;
            this.dmview.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dmview.Location = new System.Drawing.Point(604, 313);
            this.dmview.Name = "dmview";
            this.dmview.Size = new System.Drawing.Size(75, 38);
            this.dmview.TabIndex = 1;
            this.dmview.Text = "View";
            this.dmview.UseVisualStyleBackColor = true;
            this.dmview.Click += new System.EventHandler(this.button1_Click);
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.Red;
            this.back.Location = new System.Drawing.Point(354, 158);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(111, 38);
            this.back.TabIndex = 4;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // ddelete
            // 
            this.ddelete.BackColor = System.Drawing.Color.Maroon;
            this.ddelete.Location = new System.Drawing.Point(282, 381);
            this.ddelete.Name = "ddelete";
            this.ddelete.Size = new System.Drawing.Size(69, 33);
            this.ddelete.TabIndex = 5;
            this.ddelete.Text = "Delete";
            this.ddelete.UseVisualStyleBackColor = false;
            this.ddelete.Click += new System.EventHandler(this.ddelete_Click);
            // 
            // dminfocheckgridview
            // 
            this.dminfocheckgridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dminfocheckgridview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.i,
            this.D_Name});
            this.dminfocheckgridview.Location = new System.Drawing.Point(471, 38);
            this.dminfocheckgridview.Name = "dminfocheckgridview";
            this.dminfocheckgridview.RowHeadersWidth = 51;
            this.dminfocheckgridview.RowTemplate.Height = 24;
            this.dminfocheckgridview.Size = new System.Drawing.Size(330, 269);
            this.dminfocheckgridview.TabIndex = 6;
            // 
            // i
            // 
            this.i.HeaderText = "ID";
            this.i.MinimumWidth = 6;
            this.i.Name = "i";
            this.i.Width = 125;
            // 
            // D_Name
            // 
            this.D_Name.HeaderText = "DeliveryMan";
            this.D_Name.MinimumWidth = 6;
            this.D_Name.Name = "D_Name";
            this.D_Name.Width = 125;
            // 
            // dview
            // 
            this.dview.BackgroundImage = global::Final_Project.Properties.Resources._053026334c7f11be0fba9924ff8aa100;
            this.dview.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dview.Location = new System.Drawing.Point(122, 313);
            this.dview.Name = "dview";
            this.dview.Size = new System.Drawing.Size(75, 38);
            this.dview.TabIndex = 7;
            this.dview.Text = "View";
            this.dview.UseVisualStyleBackColor = true;
            this.dview.Click += new System.EventHandler(this.dview_Click);
            // 
            // dmdel
            // 
            this.dmdel.BackColor = System.Drawing.Color.Maroon;
            this.dmdel.Location = new System.Drawing.Point(702, 381);
            this.dmdel.Name = "dmdel";
            this.dmdel.Size = new System.Drawing.Size(69, 33);
            this.dmdel.TabIndex = 8;
            this.dmdel.Text = "Delete";
            this.dmdel.UseVisualStyleBackColor = false;
            this.dmdel.Click += new System.EventHandler(this.dmdel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 373);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(12, 408);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Doctor Name";
            // 
            // dcid
            // 
            this.dcid.Location = new System.Drawing.Point(105, 370);
            this.dcid.Name = "dcid";
            this.dcid.Size = new System.Drawing.Size(171, 22);
            this.dcid.TabIndex = 11;
            // 
            // dcname
            // 
            this.dcname.Location = new System.Drawing.Point(105, 408);
            this.dcname.Name = "dcname";
            this.dcname.Size = new System.Drawing.Size(171, 22);
            this.dcname.TabIndex = 12;
            // 
            // dlname
            // 
            this.dlname.Location = new System.Drawing.Point(511, 408);
            this.dlname.Name = "dlname";
            this.dlname.Size = new System.Drawing.Size(185, 22);
            this.dlname.TabIndex = 13;
            // 
            // dlid
            // 
            this.dlid.Location = new System.Drawing.Point(511, 373);
            this.dlid.Name = "dlid";
            this.dlid.Size = new System.Drawing.Size(185, 22);
            this.dlid.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(422, 381);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(422, 411);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 16);
            this.label4.TabIndex = 16;
            this.label4.Text = "DeliveryMan";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(-3, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 16);
            this.label5.TabIndex = 17;
            this.label5.Text = "Search Here";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(471, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 16);
            this.label6.TabIndex = 18;
            this.label6.Text = "Search Here";
            // 
            // src
            // 
            this.src.Location = new System.Drawing.Point(86, 10);
            this.src.Name = "src";
            this.src.Size = new System.Drawing.Size(181, 22);
            this.src.TabIndex = 19;
            this.src.TextChanged += new System.EventHandler(this.src_TextChanged);
            // 
            // srch
            // 
            this.srch.Location = new System.Drawing.Point(560, 10);
            this.srch.Name = "srch";
            this.srch.Size = new System.Drawing.Size(156, 22);
            this.srch.TabIndex = 20;
            this.srch.TextChanged += new System.EventHandler(this.srch_TextChanged);
            // 
            // search
            // 
            this.search.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.search.Location = new System.Drawing.Point(273, 8);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(75, 23);
            this.search.TabIndex = 21;
            this.search.Text = "Search";
            this.search.UseVisualStyleBackColor = false;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // DLsrch
            // 
            this.DLsrch.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.DLsrch.Location = new System.Drawing.Point(722, 9);
            this.DLsrch.Name = "DLsrch";
            this.DLsrch.Size = new System.Drawing.Size(75, 23);
            this.DLsrch.TabIndex = 22;
            this.DLsrch.Text = "Search";
            this.DLsrch.UseVisualStyleBackColor = false;
            this.DLsrch.Click += new System.EventHandler(this.DLsrch_Click);
            // 
            // empinfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Final_Project.Properties.Resources._053026334c7f11be0fba9924ff8aa100;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DLsrch);
            this.Controls.Add(this.search);
            this.Controls.Add(this.srch);
            this.Controls.Add(this.src);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dlid);
            this.Controls.Add(this.dlname);
            this.Controls.Add(this.dcname);
            this.Controls.Add(this.dcid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dmdel);
            this.Controls.Add(this.dview);
            this.Controls.Add(this.dminfocheckgridview);
            this.Controls.Add(this.ddelete);
            this.Controls.Add(this.back);
            this.Controls.Add(this.dmview);
            this.Controls.Add(this.dcinfoecheckgridview);
            this.Name = "empinfo";
            this.Text = "Employee Information";
            ((System.ComponentModel.ISupportInitialize)(this.dcinfoecheckgridview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dminfocheckgridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dcinfoecheckgridview;
        private System.Windows.Forms.Button dmview;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button ddelete;
        private System.Windows.Forms.DataGridView dminfocheckgridview;
        private System.Windows.Forms.Button dview;
        private System.Windows.Forms.Button dmdel;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Employee_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn i;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_Name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox dcid;
        private System.Windows.Forms.TextBox dcname;
        private System.Windows.Forms.TextBox dlname;
        private System.Windows.Forms.TextBox dlid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox src;
        private System.Windows.Forms.TextBox srch;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Button DLsrch;
    }
}