namespace Final_Project
{
    partial class dclogin
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.D_username = new System.Windows.Forms.TextBox();
            this.D_password = new System.Windows.Forms.TextBox();
            this.lgn = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(26, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(26, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // D_username
            // 
            this.D_username.Location = new System.Drawing.Point(134, 163);
            this.D_username.Name = "D_username";
            this.D_username.Size = new System.Drawing.Size(229, 22);
            this.D_username.TabIndex = 2;
            // 
            // D_password
            // 
            this.D_password.Location = new System.Drawing.Point(134, 227);
            this.D_password.Name = "D_password";
            this.D_password.Size = new System.Drawing.Size(229, 22);
            this.D_password.TabIndex = 3;
            // 
            // lgn
            // 
            this.lgn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lgn.BackgroundImage = global::Final_Project.Properties.Resources._053026334c7f11be0fba9924ff8aa100;
            this.lgn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.lgn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lgn.Location = new System.Drawing.Point(269, 284);
            this.lgn.Name = "lgn";
            this.lgn.Size = new System.Drawing.Size(94, 40);
            this.lgn.TabIndex = 4;
            this.lgn.Text = "Login";
            this.lgn.UseVisualStyleBackColor = false;
            this.lgn.Click += new System.EventHandler(this.lgn_Click);
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.Maroon;
            this.back.Location = new System.Drawing.Point(29, 442);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 35);
            this.back.TabIndex = 5;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // dclogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Final_Project.Properties.Resources._053026334c7f11be0fba9924ff8aa100;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 510);
            this.Controls.Add(this.back);
            this.Controls.Add(this.lgn);
            this.Controls.Add(this.D_password);
            this.Controls.Add(this.D_username);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "dclogin";
            this.Text = "Doctor Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox D_username;
        private System.Windows.Forms.TextBox D_password;
        private System.Windows.Forms.Button lgn;
        private System.Windows.Forms.Button back;
    }
}