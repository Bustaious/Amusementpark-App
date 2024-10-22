namespace Amusement_Park_App
{
    partial class accountDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(accountDashboard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.pnumberTag = new System.Windows.Forms.Label();
            this.emailTag = new System.Windows.Forms.Label();
            this.usernameTag = new System.Windows.Forms.Label();
            this.userIcon = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.reviewBox = new System.Windows.Forms.RichTextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.bookingLink = new System.Windows.Forms.LinkLabel();
            this.reviewBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userIcon)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.linkLabel2);
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pnumberTag);
            this.panel1.Controls.Add(this.emailTag);
            this.panel1.Controls.Add(this.usernameTag);
            this.panel1.Controls.Add(this.userIcon);
            this.panel1.Location = new System.Drawing.Point(594, -9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(210, 467);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel2.LinkColor = System.Drawing.Color.Red;
            this.linkLabel2.Location = new System.Drawing.Point(67, 401);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(58, 15);
            this.linkLabel2.TabIndex = 3;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Log-Out";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel2_LinkClicked);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.Green;
            this.linkLabel1.Location = new System.Drawing.Point(67, 424);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(79, 15);
            this.linkLabel1.TabIndex = 3;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Main Menu";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel1_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-590, 336);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "label1";
            // 
            // pnumberTag
            // 
            this.pnumberTag.AutoSize = true;
            this.pnumberTag.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnumberTag.Location = new System.Drawing.Point(67, 243);
            this.pnumberTag.Name = "pnumberTag";
            this.pnumberTag.Size = new System.Drawing.Size(90, 13);
            this.pnumberTag.TabIndex = 2;
            this.pnumberTag.Text = "Phone Number";
            // 
            // emailTag
            // 
            this.emailTag.AutoSize = true;
            this.emailTag.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTag.Location = new System.Drawing.Point(67, 219);
            this.emailTag.Name = "emailTag";
            this.emailTag.Size = new System.Drawing.Size(86, 13);
            this.emailTag.TabIndex = 2;
            this.emailTag.Text = "Email Address";
            this.emailTag.Click += new System.EventHandler(this.EmailTag_Click);
            // 
            // usernameTag
            // 
            this.usernameTag.AutoSize = true;
            this.usernameTag.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTag.Location = new System.Drawing.Point(52, 183);
            this.usernameTag.Name = "usernameTag";
            this.usernameTag.Size = new System.Drawing.Size(118, 25);
            this.usernameTag.TabIndex = 1;
            this.usernameTag.Text = "Username";
            this.usernameTag.Click += new System.EventHandler(this.UsernameTag_Click);
            // 
            // userIcon
            // 
            this.userIcon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("userIcon.BackgroundImage")));
            this.userIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.userIcon.Location = new System.Drawing.Point(27, 45);
            this.userIcon.Name = "userIcon";
            this.userIcon.Size = new System.Drawing.Size(153, 130);
            this.userIcon.TabIndex = 0;
            this.userIcon.TabStop = false;
            this.userIcon.Click += new System.EventHandler(this.UserIcon_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.reviewBtn);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.reviewBox);
            this.panel2.Location = new System.Drawing.Point(1, 257);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(593, 194);
            this.panel2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 26);
            this.label3.TabIndex = 0;
            this.label3.Text = "Review";
            this.label3.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(522, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "If you do so please, state your experience with our services.";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // reviewBox
            // 
            this.reviewBox.Location = new System.Drawing.Point(17, 64);
            this.reviewBox.Name = "reviewBox";
            this.reviewBox.Size = new System.Drawing.Size(519, 97);
            this.reviewBox.TabIndex = 0;
            this.reviewBox.Text = "";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.bookingLink);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(1, 1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(593, 256);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.richTextBox1);
            this.panel4.Location = new System.Drawing.Point(14, 35);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(549, 211);
            this.panel4.TabIndex = 1;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(3, 11);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(543, 193);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 26);
            this.label4.TabIndex = 0;
            this.label4.Text = "Booking Details";
            this.label4.Click += new System.EventHandler(this.Label1_Click);
            // 
            // bookingLink
            // 
            this.bookingLink.AutoSize = true;
            this.bookingLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookingLink.LinkColor = System.Drawing.Color.Green;
            this.bookingLink.Location = new System.Drawing.Point(444, 10);
            this.bookingLink.Name = "bookingLink";
            this.bookingLink.Size = new System.Drawing.Size(119, 16);
            this.bookingLink.TabIndex = 2;
            this.bookingLink.TabStop = true;
            this.bookingLink.Text = "Make a booking";
            // 
            // reviewBtn
            // 
            this.reviewBtn.BackColor = System.Drawing.Color.DarkKhaki;
            this.reviewBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reviewBtn.Location = new System.Drawing.Point(447, 26);
            this.reviewBtn.Name = "reviewBtn";
            this.reviewBtn.Size = new System.Drawing.Size(74, 32);
            this.reviewBtn.TabIndex = 1;
            this.reviewBtn.Text = "Review";
            this.reviewBtn.UseVisualStyleBackColor = false;
            // 
            // accountDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "accountDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Profile";
            this.Load += new System.EventHandler(this.AccountDashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userIcon)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox userIcon;
        private System.Windows.Forms.Label usernameTag;
        private System.Windows.Forms.Label emailTag;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RichTextBox reviewBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label pnumberTag;
        private System.Windows.Forms.Button reviewBtn;
        private System.Windows.Forms.LinkLabel bookingLink;
    }
}