namespace Final_Project
{
    partial class ordermedicine
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.medicinename = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mid = new System.Windows.Forms.Label();
            this.mname = new System.Windows.Forms.Label();
            this.order = new System.Windows.Forms.Button();
            this.home = new System.Windows.Forms.Button();
            this.leave = new System.Windows.Forms.Button();
            this.address = new System.Windows.Forms.ComboBox();
            this.maddress = new System.Windows.Forms.Label();
            this.qntity = new System.Windows.Forms.ComboBox();
            this.quantity = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.medicineid = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.BackgroundImage = global::Final_Project.Properties.Resources._053026334c7f11be0fba9924ff8aa100;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.medicineid);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.price);
            this.panel1.Controls.Add(this.medicinename);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.mid);
            this.panel1.Controls.Add(this.mname);
            this.panel1.Location = new System.Drawing.Point(0, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(963, 241);
            this.panel1.TabIndex = 0;
            // 
            // medicinename
            // 
            this.medicinename.Location = new System.Drawing.Point(449, 155);
            this.medicinename.Name = "medicinename";
            this.medicinename.Size = new System.Drawing.Size(300, 22);
            this.medicinename.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Goudy Stout", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(281, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(617, 31);
            this.label1.TabIndex = 8;
            this.label1.Text = "GRAB BASE ON YOUR DESIRE";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Final_Project.Properties.Resources.ormd;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(246, 241);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // mid
            // 
            this.mid.AutoSize = true;
            this.mid.BackColor = System.Drawing.SystemColors.ControlText;
            this.mid.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.mid.Location = new System.Drawing.Point(323, 112);
            this.mid.Name = "mid";
            this.mid.Size = new System.Drawing.Size(76, 16);
            this.mid.TabIndex = 18;
            this.mid.Text = "Medicine Id";
            // 
            // mname
            // 
            this.mname.AutoSize = true;
            this.mname.BackColor = System.Drawing.SystemColors.ControlText;
            this.mname.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.mname.Location = new System.Drawing.Point(323, 158);
            this.mname.Name = "mname";
            this.mname.Size = new System.Drawing.Size(99, 16);
            this.mname.TabIndex = 20;
            this.mname.Text = "Medicine name";
            // 
            // order
            // 
            this.order.BackColor = System.Drawing.Color.DodgerBlue;
            this.order.Location = new System.Drawing.Point(688, 436);
            this.order.Name = "order";
            this.order.Size = new System.Drawing.Size(135, 40);
            this.order.TabIndex = 15;
            this.order.Text = "Order Now";
            this.order.UseVisualStyleBackColor = false;
            this.order.Click += new System.EventHandler(this.order_Click);
            // 
            // home
            // 
            this.home.BackColor = System.Drawing.Color.RosyBrown;
            this.home.Location = new System.Drawing.Point(240, 436);
            this.home.Name = "home";
            this.home.Size = new System.Drawing.Size(135, 40);
            this.home.TabIndex = 16;
            this.home.Text = "Home";
            this.home.UseVisualStyleBackColor = false;
            this.home.Click += new System.EventHandler(this.home_Click);
            // 
            // leave
            // 
            this.leave.BackColor = System.Drawing.Color.DarkCyan;
            this.leave.ForeColor = System.Drawing.SystemColors.ControlText;
            this.leave.Location = new System.Drawing.Point(465, 436);
            this.leave.Name = "leave";
            this.leave.Size = new System.Drawing.Size(135, 40);
            this.leave.TabIndex = 32;
            this.leave.Text = "Leave";
            this.leave.UseVisualStyleBackColor = false;
            this.leave.Click += new System.EventHandler(this.leave_Click);
            // 
            // address
            // 
            this.address.FormattingEnabled = true;
            this.address.Items.AddRange(new object[] {
            "Dhaka",
            "Chittogong",
            "Barishal",
            "Khulna",
            "Comilla",
            "Sylhet",
            "Coxs-Bazar",
            "Rajshai",
            "Kustia",
            "Chandpur",
            "Noakhali"});
            this.address.Location = new System.Drawing.Point(449, 309);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(300, 24);
            this.address.TabIndex = 31;
            // 
            // maddress
            // 
            this.maddress.AutoSize = true;
            this.maddress.BackColor = System.Drawing.SystemColors.ControlText;
            this.maddress.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.maddress.Location = new System.Drawing.Point(323, 312);
            this.maddress.Name = "maddress";
            this.maddress.Size = new System.Drawing.Size(58, 16);
            this.maddress.TabIndex = 30;
            this.maddress.Text = "Address";
            // 
            // qntity
            // 
            this.qntity.FormattingEnabled = true;
            this.qntity.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59",
            "60",
            "61",
            "62",
            "63",
            "64",
            "65",
            "66",
            "67",
            "68",
            "69",
            "70",
            "71",
            "72",
            "73",
            "74",
            "75",
            "76",
            "77",
            "78",
            "79",
            "80",
            "81",
            "82",
            "83",
            "84",
            "85",
            "86",
            "87",
            "88",
            "89",
            "90",
            "91",
            "92",
            "93",
            "94",
            "95",
            "96",
            "97",
            "98",
            "99",
            "100",
            "More Than 100"});
            this.qntity.Location = new System.Drawing.Point(449, 247);
            this.qntity.Name = "qntity";
            this.qntity.Size = new System.Drawing.Size(300, 24);
            this.qntity.TabIndex = 29;
            // 
            // quantity
            // 
            this.quantity.AutoSize = true;
            this.quantity.BackColor = System.Drawing.SystemColors.ControlText;
            this.quantity.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.quantity.Location = new System.Drawing.Point(323, 247);
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(55, 16);
            this.quantity.TabIndex = 25;
            this.quantity.Text = "Quantity";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(323, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 16);
            this.label2.TabIndex = 33;
            this.label2.Text = "Price";
            // 
            // price
            // 
            this.price.Location = new System.Drawing.Point(449, 201);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(300, 22);
            this.price.TabIndex = 34;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Final_Project.Properties.Resources._053026334c7f11be0fba9924ff8aa100;
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.button1.Location = new System.Drawing.Point(674, 104);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 33);
            this.button1.TabIndex = 35;
            this.button1.Text = "Fetch";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(446, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(312, 16);
            this.label3.TabIndex = 36;
            this.label3.Text = "Search between 1-10 as well click on \"Fetch\" button.";
            // 
            // medicineid
            // 
            this.medicineid.FormattingEnabled = true;
            this.medicineid.Items.AddRange(new object[] {
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
            this.medicineid.Location = new System.Drawing.Point(449, 109);
            this.medicineid.Name = "medicineid";
            this.medicineid.Size = new System.Drawing.Size(219, 24);
            this.medicineid.TabIndex = 37;
            // 
            // ordermedicine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BackgroundImage = global::Final_Project.Properties.Resources._053026334c7f11be0fba9924ff8aa100;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(962, 567);
            this.Controls.Add(this.qntity);
            this.Controls.Add(this.address);
            this.Controls.Add(this.leave);
            this.Controls.Add(this.maddress);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.quantity);
            this.Controls.Add(this.home);
            this.Controls.Add(this.order);
            this.Name = "ordermedicine";
            this.Text = "Order Medicine";
            this.Load += new System.EventHandler(this.ordermedicine_Load);
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
        private System.Windows.Forms.Button order;
        private System.Windows.Forms.Button home;
        private System.Windows.Forms.TextBox medicinename;
        private System.Windows.Forms.Label mname;
        private System.Windows.Forms.Label mid;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label quantity;
        private System.Windows.Forms.Label maddress;
        private System.Windows.Forms.ComboBox qntity;
        private System.Windows.Forms.ComboBox address;
        private System.Windows.Forms.Button leave;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox price;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox medicineid;
    }
}