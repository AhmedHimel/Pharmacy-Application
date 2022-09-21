namespace Final_Project
{
    partial class emcallinfo
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
            this.emcallgridview = new System.Windows.Forms.DataGridView();
            this.view = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.Cid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Service_Provider = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contact_Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Area = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.eid = new System.Windows.Forms.TextBox();
            this.ename = new System.Windows.Forms.TextBox();
            this.enm = new System.Windows.Forms.TextBox();
            this.earea = new System.Windows.Forms.TextBox();
            this.srch = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.search = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.emcallgridview)).BeginInit();
            this.SuspendLayout();
            // 
            // emcallgridview
            // 
            this.emcallgridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.emcallgridview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cid,
            this.Service_Provider,
            this.Contact_Number,
            this.Area});
            this.emcallgridview.Location = new System.Drawing.Point(-1, 49);
            this.emcallgridview.Name = "emcallgridview";
            this.emcallgridview.RowHeadersWidth = 51;
            this.emcallgridview.RowTemplate.Height = 24;
            this.emcallgridview.Size = new System.Drawing.Size(477, 313);
            this.emcallgridview.TabIndex = 0;
            // 
            // view
            // 
            this.view.BackgroundImage = global::Final_Project.Properties.Resources._053026334c7f11be0fba9924ff8aa100;
            this.view.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.view.Location = new System.Drawing.Point(188, 368);
            this.view.Name = "view";
            this.view.Size = new System.Drawing.Size(75, 38);
            this.view.TabIndex = 2;
            this.view.Text = "View";
            this.view.UseVisualStyleBackColor = true;
            this.view.Click += new System.EventHandler(this.view_Click);
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.Red;
            this.back.Location = new System.Drawing.Point(-1, 420);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(85, 28);
            this.back.TabIndex = 5;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.Maroon;
            this.delete.Location = new System.Drawing.Point(699, 347);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(89, 38);
            this.delete.TabIndex = 6;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
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
            this.Service_Provider.HeaderText = "Name";
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
            this.label1.Location = new System.Drawing.Point(517, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(517, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(517, 266);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(517, 306);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Area";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button1.Location = new System.Drawing.Point(713, 197);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Fetch";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // eid
            // 
            this.eid.Location = new System.Drawing.Point(600, 198);
            this.eid.Name = "eid";
            this.eid.Size = new System.Drawing.Size(100, 22);
            this.eid.TabIndex = 12;
            // 
            // ename
            // 
            this.ename.Location = new System.Drawing.Point(600, 229);
            this.ename.Name = "ename";
            this.ename.Size = new System.Drawing.Size(188, 22);
            this.ename.TabIndex = 13;
            // 
            // enm
            // 
            this.enm.Location = new System.Drawing.Point(600, 266);
            this.enm.Name = "enm";
            this.enm.Size = new System.Drawing.Size(188, 22);
            this.enm.TabIndex = 14;
            // 
            // earea
            // 
            this.earea.Location = new System.Drawing.Point(600, 306);
            this.earea.Name = "earea";
            this.earea.Size = new System.Drawing.Size(188, 22);
            this.earea.TabIndex = 15;
            // 
            // srch
            // 
            this.srch.Location = new System.Drawing.Point(101, 21);
            this.srch.Name = "srch";
            this.srch.Size = new System.Drawing.Size(272, 22);
            this.srch.TabIndex = 16;
            this.srch.TextChanged += new System.EventHandler(this.srch_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(12, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 16);
            this.label5.TabIndex = 17;
            this.label5.Text = "Search Here";
            // 
            // search
            // 
            this.search.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.search.Location = new System.Drawing.Point(389, 20);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(75, 23);
            this.search.TabIndex = 18;
            this.search.Text = "Search";
            this.search.UseVisualStyleBackColor = false;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // emcallinfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Final_Project.Properties.Resources._053026334c7f11be0fba9924ff8aa100;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.search);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.srch);
            this.Controls.Add(this.earea);
            this.Controls.Add(this.enm);
            this.Controls.Add(this.ename);
            this.Controls.Add(this.eid);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.back);
            this.Controls.Add(this.view);
            this.Controls.Add(this.emcallgridview);
            this.Name = "emcallinfo";
            this.Text = "Emergency Call Information";
            ((System.ComponentModel.ISupportInitialize)(this.emcallgridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView emcallgridview;
        private System.Windows.Forms.Button view;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Service_Provider;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contact_Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Area;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox eid;
        private System.Windows.Forms.TextBox ename;
        private System.Windows.Forms.TextBox enm;
        private System.Windows.Forms.TextBox earea;
        private System.Windows.Forms.TextBox srch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button search;
    }
}