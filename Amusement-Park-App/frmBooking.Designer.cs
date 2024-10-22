namespace Amusement_Park_App
{
    partial class frmBooking
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBooking));
            this.label1 = new System.Windows.Forms.Label();
            this.submitbookingBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panelLight = new System.Windows.Forms.Panel();
            this.visittypeCombo = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.daysCombo = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.weeksCombo = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.exclusiveCombo = new System.Windows.Forms.ComboBox();
            this.Datename = new System.Windows.Forms.Label();
            this.bookingDT = new System.Windows.Forms.DateTimePicker();
            this.panelLight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 280);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Exclusivity";
            // 
            // submitbookingBtn
            // 
            this.submitbookingBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.submitbookingBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitbookingBtn.Location = new System.Drawing.Point(626, 309);
            this.submitbookingBtn.Name = "submitbookingBtn";
            this.submitbookingBtn.Size = new System.Drawing.Size(138, 48);
            this.submitbookingBtn.TabIndex = 1;
            this.submitbookingBtn.Text = "Submit";
            this.submitbookingBtn.UseVisualStyleBackColor = false;
            this.submitbookingBtn.Click += new System.EventHandler(this.SubmitbookingBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(50, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Duration";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(50, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Plan";
            // 
            // panelLight
            // 
            this.panelLight.Controls.Add(this.visittypeCombo);
            this.panelLight.Controls.Add(this.pictureBox1);
            this.panelLight.Controls.Add(this.label4);
            this.panelLight.Location = new System.Drawing.Point(6, 19);
            this.panelLight.Name = "panelLight";
            this.panelLight.Size = new System.Drawing.Size(269, 104);
            this.panelLight.TabIndex = 2;
            // 
            // visittypeCombo
            // 
            this.visittypeCombo.FormattingEnabled = true;
            this.visittypeCombo.Items.AddRange(new object[] {
            "Light Visit",
            "Standard Trip",
            "Full Tour"});
            this.visittypeCombo.Location = new System.Drawing.Point(101, 45);
            this.visittypeCombo.Name = "visittypeCombo";
            this.visittypeCombo.Size = new System.Drawing.Size(109, 21);
            this.visittypeCombo.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(17, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 45);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(93, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Visit Type";
            this.label4.Click += new System.EventHandler(this.Label4_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.daysCombo);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(161, 185);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(231, 64);
            this.panel1.TabIndex = 3;
            // 
            // daysCombo
            // 
            this.daysCombo.FormattingEnabled = true;
            this.daysCombo.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.daysCombo.Location = new System.Drawing.Point(17, 21);
            this.daysCombo.Name = "daysCombo";
            this.daysCombo.Size = new System.Drawing.Size(121, 21);
            this.daysCombo.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(144, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 18);
            this.label7.TabIndex = 0;
            this.label7.Text = "Days";
            this.label7.Click += new System.EventHandler(this.Label4_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.weeksCombo);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Location = new System.Drawing.Point(435, 185);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(231, 64);
            this.panel2.TabIndex = 3;
            // 
            // weeksCombo
            // 
            this.weeksCombo.FormattingEnabled = true;
            this.weeksCombo.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4"});
            this.weeksCombo.Location = new System.Drawing.Point(17, 21);
            this.weeksCombo.Name = "weeksCombo";
            this.weeksCombo.Size = new System.Drawing.Size(121, 21);
            this.weeksCombo.TabIndex = 4;
            this.weeksCombo.SelectedIndexChanged += new System.EventHandler(this.ComboBox2_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(144, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 18);
            this.label8.TabIndex = 0;
            this.label8.Text = "Weeks";
            this.label8.Click += new System.EventHandler(this.Label4_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(626, 374);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 48);
            this.button1.TabIndex = 1;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panelLight);
            this.groupBox1.Location = new System.Drawing.Point(161, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(302, 129);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // exclusiveCombo
            // 
            this.exclusiveCombo.FormattingEnabled = true;
            this.exclusiveCombo.Items.AddRange(new object[] {
            "Budget",
            "Standard",
            "VIP",
            "Executive"});
            this.exclusiveCombo.Location = new System.Drawing.Point(161, 280);
            this.exclusiveCombo.Name = "exclusiveCombo";
            this.exclusiveCombo.Size = new System.Drawing.Size(174, 21);
            this.exclusiveCombo.TabIndex = 5;
            // 
            // Datename
            // 
            this.Datename.AutoSize = true;
            this.Datename.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Datename.Location = new System.Drawing.Point(65, 342);
            this.Datename.Name = "Datename";
            this.Datename.Size = new System.Drawing.Size(37, 15);
            this.Datename.TabIndex = 6;
            this.Datename.Text = "Date";
            // 
            // bookingDT
            // 
            this.bookingDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookingDT.Location = new System.Drawing.Point(161, 338);
            this.bookingDT.Name = "bookingDT";
            this.bookingDT.Size = new System.Drawing.Size(210, 18);
            this.bookingDT.TabIndex = 7;
            this.bookingDT.ValueChanged += new System.EventHandler(this.DateTimePicker1_ValueChanged);
            // 
            // frmBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bookingDT);
            this.Controls.Add(this.Datename);
            this.Controls.Add(this.exclusiveCombo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.submitbookingBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmBooking";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Set Booking";
            this.Load += new System.EventHandler(this.FrmBooking_Load);
            this.panelLight.ResumeLayout(false);
            this.panelLight.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button submitbookingBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelLight;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox daysCombo;
        private System.Windows.Forms.ComboBox weeksCombo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox exclusiveCombo;
        private System.Windows.Forms.Label Datename;
        private System.Windows.Forms.DateTimePicker bookingDT;
        private System.Windows.Forms.ComboBox visittypeCombo;
    }
}