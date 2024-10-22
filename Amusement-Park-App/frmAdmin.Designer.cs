namespace Amusement_Park_App
{
    partial class frmAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdmin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.reviewView = new System.Windows.Forms.DataGridView();
            this.bookingView = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.adminuserTag = new System.Windows.Forms.Label();
            this.adminemailTag = new System.Windows.Forms.Label();
            this.adminpnumberTag = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.adminImage = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reviewView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminImage)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.reviewView);
            this.panel1.Controls.Add(this.bookingView);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(245, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(553, 455);
            this.panel1.TabIndex = 0;
            // 
            // reviewView
            // 
            this.reviewView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reviewView.Location = new System.Drawing.Point(26, 308);
            this.reviewView.Name = "reviewView";
            this.reviewView.Size = new System.Drawing.Size(515, 132);
            this.reviewView.TabIndex = 3;
            this.reviewView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ReviewView_CellContentClick);
            // 
            // bookingView
            // 
            this.bookingView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bookingView.Location = new System.Drawing.Point(22, 28);
            this.bookingView.Name = "bookingView";
            this.bookingView.Size = new System.Drawing.Size(520, 246);
            this.bookingView.TabIndex = 2;
            this.bookingView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BookingView_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 292);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Reviews";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bookings";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(33, 390);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 48);
            this.button1.TabIndex = 1;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // adminuserTag
            // 
            this.adminuserTag.AutoSize = true;
            this.adminuserTag.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminuserTag.Location = new System.Drawing.Point(81, 159);
            this.adminuserTag.Name = "adminuserTag";
            this.adminuserTag.Size = new System.Drawing.Size(85, 18);
            this.adminuserTag.TabIndex = 2;
            this.adminuserTag.Text = "Username";
            // 
            // adminemailTag
            // 
            this.adminemailTag.AutoSize = true;
            this.adminemailTag.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminemailTag.Location = new System.Drawing.Point(81, 186);
            this.adminemailTag.Name = "adminemailTag";
            this.adminemailTag.Size = new System.Drawing.Size(86, 13);
            this.adminemailTag.TabIndex = 2;
            this.adminemailTag.Text = "Email Address";
            // 
            // adminpnumberTag
            // 
            this.adminpnumberTag.AutoSize = true;
            this.adminpnumberTag.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminpnumberTag.Location = new System.Drawing.Point(81, 211);
            this.adminpnumberTag.Name = "adminpnumberTag";
            this.adminpnumberTag.Size = new System.Drawing.Size(67, 13);
            this.adminpnumberTag.TabIndex = 2;
            this.adminpnumberTag.Text = "Phone No.";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.Red;
            this.linkLabel1.Location = new System.Drawing.Point(30, 364);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(50, 13);
            this.linkLabel1.TabIndex = 3;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Log-out";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel1_LinkClicked);
            // 
            // adminImage
            // 
            this.adminImage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("adminImage.BackgroundImage")));
            this.adminImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.adminImage.Location = new System.Drawing.Point(47, 25);
            this.adminImage.Name = "adminImage";
            this.adminImage.Size = new System.Drawing.Size(138, 125);
            this.adminImage.TabIndex = 4;
            this.adminImage.TabStop = false;
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.adminImage);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.adminpnumberTag);
            this.Controls.Add(this.adminemailTag);
            this.Controls.Add(this.adminuserTag);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Name = "frmAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.FrmAdmin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reviewView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView bookingView;
        private System.Windows.Forms.DataGridView reviewView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label adminuserTag;
        private System.Windows.Forms.Label adminemailTag;
        private System.Windows.Forms.Label adminpnumberTag;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.PictureBox adminImage;
    }
}