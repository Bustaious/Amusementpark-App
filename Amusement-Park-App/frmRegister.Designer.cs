namespace Amusement_Park_App
{
    partial class frmRegister
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
            this.usernameRegister = new System.Windows.Forms.TextBox();
            this.emailRegister = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmdRegisterCont = new System.Windows.Forms.Button();
            this.cmdRegisterback = new System.Windows.Forms.Button();
            this.pnumberRegister = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.userType = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.passwordRegister = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.passwordRegister2 = new System.Windows.Forms.TextBox();
            this.eraseBtn = new System.Windows.Forms.Button();
            this.passwordCheck = new System.Windows.Forms.CheckBox();
            this.prelogLink = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // usernameRegister
            // 
            this.usernameRegister.Location = new System.Drawing.Point(107, 70);
            this.usernameRegister.Name = "usernameRegister";
            this.usernameRegister.Size = new System.Drawing.Size(212, 20);
            this.usernameRegister.TabIndex = 0;
            this.usernameRegister.TextChanged += new System.EventHandler(this.TextBox3_TextChanged);
            // 
            // emailRegister
            // 
            this.emailRegister.Location = new System.Drawing.Point(127, 206);
            this.emailRegister.Name = "emailRegister";
            this.emailRegister.Size = new System.Drawing.Size(259, 20);
            this.emailRegister.TabIndex = 0;
            this.emailRegister.TextChanged += new System.EventHandler(this.EmailRegister_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Username";
            this.label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Email Address";
            this.label4.Click += new System.EventHandler(this.Label2_Click);
            // 
            // cmdRegisterCont
            // 
            this.cmdRegisterCont.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdRegisterCont.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdRegisterCont.Location = new System.Drawing.Point(437, 345);
            this.cmdRegisterCont.Name = "cmdRegisterCont";
            this.cmdRegisterCont.Size = new System.Drawing.Size(139, 34);
            this.cmdRegisterCont.TabIndex = 2;
            this.cmdRegisterCont.Text = "Continue";
            this.cmdRegisterCont.UseVisualStyleBackColor = true;
            this.cmdRegisterCont.Click += new System.EventHandler(this.CmdRegisterCont_Click);
            // 
            // cmdRegisterback
            // 
            this.cmdRegisterback.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdRegisterback.Location = new System.Drawing.Point(437, 399);
            this.cmdRegisterback.Name = "cmdRegisterback";
            this.cmdRegisterback.Size = new System.Drawing.Size(139, 34);
            this.cmdRegisterback.TabIndex = 2;
            this.cmdRegisterback.Text = "Back";
            this.cmdRegisterback.UseVisualStyleBackColor = true;
            this.cmdRegisterback.Click += new System.EventHandler(this.CmdRegisterback_Click);
            // 
            // pnumberRegister
            // 
            this.pnumberRegister.Location = new System.Drawing.Point(105, 249);
            this.pnumberRegister.Name = "pnumberRegister";
            this.pnumberRegister.Size = new System.Drawing.Size(214, 20);
            this.pnumberRegister.TabIndex = 0;
            this.pnumberRegister.TextChanged += new System.EventHandler(this.PnumberRegister_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "Phone No.";
            this.label5.Click += new System.EventHandler(this.Label2_Click);
            // 
            // userType
            // 
            this.userType.Location = new System.Drawing.Point(447, 70);
            this.userType.Name = "userType";
            this.userType.Size = new System.Drawing.Size(97, 20);
            this.userType.TabIndex = 0;
            this.userType.TextChanged += new System.EventHandler(this.UserType_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(434, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 15);
            this.label6.TabIndex = 3;
            this.label6.Text = "Admin code (Optional)";
            // 
            // passwordRegister
            // 
            this.passwordRegister.Location = new System.Drawing.Point(107, 115);
            this.passwordRegister.Name = "passwordRegister";
            this.passwordRegister.PasswordChar = '*';
            this.passwordRegister.Size = new System.Drawing.Size(155, 20);
            this.passwordRegister.TabIndex = 0;
            this.passwordRegister.TextChanged += new System.EventHandler(this.TextBox3_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(22, 160);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 15);
            this.label7.TabIndex = 1;
            this.label7.Text = "Confirm Password";
            this.label7.Click += new System.EventHandler(this.Label2_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(22, 120);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 15);
            this.label8.TabIndex = 1;
            this.label8.Text = "Password";
            this.label8.Click += new System.EventHandler(this.Label2_Click);
            // 
            // passwordRegister2
            // 
            this.passwordRegister2.Location = new System.Drawing.Point(151, 155);
            this.passwordRegister2.Name = "passwordRegister2";
            this.passwordRegister2.PasswordChar = '*';
            this.passwordRegister2.Size = new System.Drawing.Size(155, 20);
            this.passwordRegister2.TabIndex = 0;
            this.passwordRegister2.TextChanged += new System.EventHandler(this.TextBox3_TextChanged);
            // 
            // eraseBtn
            // 
            this.eraseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.eraseBtn.Location = new System.Drawing.Point(43, 388);
            this.eraseBtn.Name = "eraseBtn";
            this.eraseBtn.Size = new System.Drawing.Size(139, 34);
            this.eraseBtn.TabIndex = 2;
            this.eraseBtn.Text = "Erase";
            this.eraseBtn.UseVisualStyleBackColor = true;
            this.eraseBtn.Click += new System.EventHandler(this.EraseBtn_Click);
            // 
            // passwordCheck
            // 
            this.passwordCheck.AutoSize = true;
            this.passwordCheck.Location = new System.Drawing.Point(361, 157);
            this.passwordCheck.Name = "passwordCheck";
            this.passwordCheck.Size = new System.Drawing.Size(98, 17);
            this.passwordCheck.TabIndex = 4;
            this.passwordCheck.Text = "View Password";
            this.passwordCheck.UseVisualStyleBackColor = true;
            this.passwordCheck.CheckedChanged += new System.EventHandler(this.PasswordCheck_CheckedChanged);
            // 
            // prelogLink
            // 
            this.prelogLink.AutoSize = true;
            this.prelogLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prelogLink.Location = new System.Drawing.Point(104, 284);
            this.prelogLink.Name = "prelogLink";
            this.prelogLink.Size = new System.Drawing.Size(174, 15);
            this.prelogLink.TabIndex = 5;
            this.prelogLink.TabStop = true;
            this.prelogLink.Text = "I already have an account.";
            this.prelogLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.PrelogLink_LinkClicked);
            // 
            // frmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(614, 450);
            this.Controls.Add(this.prelogLink);
            this.Controls.Add(this.passwordCheck);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmdRegisterback);
            this.Controls.Add(this.eraseBtn);
            this.Controls.Add(this.cmdRegisterCont);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pnumberRegister);
            this.Controls.Add(this.emailRegister);
            this.Controls.Add(this.passwordRegister2);
            this.Controls.Add(this.passwordRegister);
            this.Controls.Add(this.usernameRegister);
            this.Controls.Add(this.userType);
            this.Name = "frmRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.Load += new System.EventHandler(this.FrmRegister_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox usernameRegister;
        private System.Windows.Forms.TextBox emailRegister;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button cmdRegisterCont;
        private System.Windows.Forms.Button cmdRegisterback;
        private System.Windows.Forms.TextBox pnumberRegister;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox userType;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox passwordRegister;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox passwordRegister2;
        private System.Windows.Forms.Button eraseBtn;
        private System.Windows.Forms.CheckBox passwordCheck;
        private System.Windows.Forms.LinkLabel prelogLink;
    }
}