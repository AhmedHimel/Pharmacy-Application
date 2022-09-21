namespace Final_Project
{
    partial class medinfo
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
            this.medinfogridview = new System.Windows.Forms.DataGridView();
            this.view = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.addmed = new System.Windows.Forms.Button();
            this.delmed = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mn = new System.Windows.Forms.TextBox();
            this.pr = new System.Windows.Forms.TextBox();
            this.sr = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Mid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.TextBox();
            this.fetch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.medinfogridview)).BeginInit();
            this.SuspendLayout();
            // 
            // medinfogridview
            // 
            this.medinfogridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.medinfogridview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Mid,
            this.Mname,
            this.price});
            this.medinfogridview.Location = new System.Drawing.Point(-1, 38);
            this.medinfogridview.Name = "medinfogridview";
            this.medinfogridview.RowHeadersWidth = 51;
            this.medinfogridview.RowTemplate.Height = 24;
            this.medinfogridview.Size = new System.Drawing.Size(433, 327);
            this.medinfogridview.TabIndex = 0;
            // 
            // view
            // 
            this.view.BackgroundImage = global::Final_Project.Properties.Resources._053026334c7f11be0fba9924ff8aa100;
            this.view.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.view.Location = new System.Drawing.Point(165, 371);
            this.view.Name = "view";
            this.view.Size = new System.Drawing.Size(96, 33);
            this.view.TabIndex = 1;
            this.view.Text = "View";
            this.view.UseVisualStyleBackColor = true;
            this.view.Click += new System.EventHandler(this.view_Click);
            // 
            // update
            // 
            this.update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.update.Location = new System.Drawing.Point(667, 12);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(121, 34);
            this.update.TabIndex = 2;
            this.update.Text = "Update Price";
            this.update.UseVisualStyleBackColor = false;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // addmed
            // 
            this.addmed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.addmed.Location = new System.Drawing.Point(453, 10);
            this.addmed.Name = "addmed";
            this.addmed.Size = new System.Drawing.Size(121, 36);
            this.addmed.TabIndex = 3;
            this.addmed.Text = "Add Medicine";
            this.addmed.UseVisualStyleBackColor = false;
            this.addmed.Click += new System.EventHandler(this.addmed_Click);
            // 
            // delmed
            // 
            this.delmed.BackColor = System.Drawing.Color.Red;
            this.delmed.Location = new System.Drawing.Point(667, 441);
            this.delmed.Name = "delmed";
            this.delmed.Size = new System.Drawing.Size(121, 36);
            this.delmed.TabIndex = 4;
            this.delmed.Text = "Delete Medicine";
            this.delmed.UseVisualStyleBackColor = false;
            this.delmed.Click += new System.EventHandler(this.delmed_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Maroon;
            this.button1.Location = new System.Drawing.Point(12, 441);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 36);
            this.button1.TabIndex = 5;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(481, 371);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Medicine Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(481, 410);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Price";
            // 
            // mn
            // 
            this.mn.Location = new System.Drawing.Point(601, 365);
            this.mn.Name = "mn";
            this.mn.Size = new System.Drawing.Size(187, 22);
            this.mn.TabIndex = 8;
            // 
            // pr
            // 
            this.pr.Location = new System.Drawing.Point(601, 404);
            this.pr.Name = "pr";
            this.pr.Size = new System.Drawing.Size(187, 22);
            this.pr.TabIndex = 9;
            // 
            // sr
            // 
            this.sr.Location = new System.Drawing.Point(108, 10);
            this.sr.Name = "sr";
            this.sr.Size = new System.Drawing.Size(243, 22);
            this.sr.TabIndex = 10;
            this.sr.TextChanged += new System.EventHandler(this.sr_TextChanged);
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::Final_Project.Properties.Resources._053026334c7f11be0fba9924ff8aa100;
            this.button2.ForeColor = System.Drawing.SystemColors.Control;
            this.button2.Location = new System.Drawing.Point(357, 8);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 27);
            this.button2.TabIndex = 11;
            this.button2.Text = "Search";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(12, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Search Here";
            // 
            // Mid
            // 
            this.Mid.HeaderText = "Id";
            this.Mid.MinimumWidth = 6;
            this.Mid.Name = "Mid";
            this.Mid.Width = 125;
            // 
            // Mname
            // 
            this.Mname.HeaderText = "Name";
            this.Mname.MinimumWidth = 6;
            this.Mname.Name = "Mname";
            this.Mname.Width = 125;
            // 
            // price
            // 
            this.price.HeaderText = "Price";
            this.price.MinimumWidth = 6;
            this.price.Name = "price";
            this.price.Width = 125;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(481, 332);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Id";
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(601, 329);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(187, 22);
            this.id.TabIndex = 14;
            // 
            // fetch
            // 
            this.fetch.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.fetch.Location = new System.Drawing.Point(713, 300);
            this.fetch.Name = "fetch";
            this.fetch.Size = new System.Drawing.Size(75, 23);
            this.fetch.TabIndex = 15;
            this.fetch.Text = "Fetch";
            this.fetch.UseVisualStyleBackColor = false;
            this.fetch.Click += new System.EventHandler(this.fetch_Click);
            // 
            // medinfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Final_Project.Properties.Resources._053026334c7f11be0fba9924ff8aa100;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 489);
            this.Controls.Add(this.fetch);
            this.Controls.Add(this.id);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.sr);
            this.Controls.Add(this.pr);
            this.Controls.Add(this.mn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.delmed);
            this.Controls.Add(this.addmed);
            this.Controls.Add(this.update);
            this.Controls.Add(this.view);
            this.Controls.Add(this.medinfogridview);
            this.Name = "medinfo";
            this.Text = "Medicine Information";
            ((System.ComponentModel.ISupportInitialize)(this.medinfogridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView medinfogridview;
        private System.Windows.Forms.Button view;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button addmed;
        private System.Windows.Forms.Button delmed;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox mn;
        private System.Windows.Forms.TextBox pr;
        private System.Windows.Forms.TextBox sr;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mname;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.Button fetch;
    }
}