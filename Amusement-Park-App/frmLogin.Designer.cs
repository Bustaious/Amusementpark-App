namespace Amusement_Park_App
{
    partial class frmLogin
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
            this.loginNext = new System.Windows.Forms.Button();
            this.usernameLogin = new System.Windows.Forms.TextBox();
            this.passwordLogin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.passtxt = new System.Windows.Forms.Label();
            this.loginPrev = new System.Windows.Forms.Button();
            this.registerLink = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.resetBtn = new System.Windows.Forms.Button();
            this.loginpassCheck = new System.Windows.Forms.CheckBox();
            this.customerCheck = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // loginNext
            // 
            this.loginNext.Location = new System.Drawing.Point(466, 187);
            this.loginNext.Name = "loginNext";
            this.loginNext.Size = new System.Drawing.Size(85, 27);
            this.loginNext.TabIndex = 0;
            this.loginNext.Text = "Next";
            this.loginNext.UseVisualStyleBackColor = true;
            this.loginNext.Click += new System.EventHandler(this.LoginNext_Click);
            // 
            // usernameLogin
            // 
            this.usernameLogin.Location = new System.Drawing.Point(183, 55);
            this.usernameLogin.Name = "usernameLogin";
            this.usernameLogin.Size = new System.Drawing.Size(225, 20);
            this.usernameLogin.TabIndex = 1;
            // 
            // passwordLogin
            // 
            this.passwordLogin.Location = new System.Drawing.Point(183, 111);
            this.passwordLogin.Name = "passwordLogin";
            this.passwordLogin.PasswordChar = '*';
            this.passwordLogin.Size = new System.Drawing.Size(225, 20);
            this.passwordLogin.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(104, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Username";
            // 
            // passtxt
            // 
            this.passtxt.AutoSize = true;
            this.passtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passtxt.Location = new System.Drawing.Point(108, 111);
            this.passtxt.Name = "passtxt";
            this.passtxt.Size = new System.Drawing.Size(69, 15);
            this.passtxt.TabIndex = 2;
            this.passtxt.Text = "Password";
            // 
            // loginPrev
            // 
            this.loginPrev.Location = new System.Drawing.Point(581, 187);
            this.loginPrev.Name = "loginPrev";
            this.loginPrev.Size = new System.Drawing.Size(85, 27);
            this.loginPrev.TabIndex = 0;
            this.loginPrev.Text = "Prev";
            this.loginPrev.UseVisualStyleBackColor = true;
            this.loginPrev.Click += new System.EventHandler(this.LoginPrev_Click);
            // 
            // registerLink
            // 
            this.registerLink.AutoSize = true;
            this.registerLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerLink.Location = new System.Drawing.Point(256, 194);
            this.registerLink.Name = "registerLink";
            this.registerLink.Size = new System.Drawing.Size(61, 15);
            this.registerLink.TabIndex = 3;
            this.registerLink.TabStop = true;
            this.registerLink.Text = "Register";
            this.registerLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.RegisterLink_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(93, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Don\'t have an account?";
            // 
            // resetBtn
            // 
            this.resetBtn.Location = new System.Drawing.Point(581, 107);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(85, 27);
            this.resetBtn.TabIndex = 0;
            this.resetBtn.Text = "Reset";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.ResetBtn_Click);
            // 
            // loginpassCheck
            // 
            this.loginpassCheck.AutoSize = true;
            this.loginpassCheck.Location = new System.Drawing.Point(431, 111);
            this.loginpassCheck.Name = "loginpassCheck";
            this.loginpassCheck.Size = new System.Drawing.Size(98, 17);
            this.loginpassCheck.TabIndex = 4;
            this.loginpassCheck.Text = "View Password";
            this.loginpassCheck.UseVisualStyleBackColor = true;
            this.loginpassCheck.CheckedChanged += new System.EventHandler(this.LoginpassCheck_CheckedChanged);
            // 
            // customerCheck
            // 
            this.customerCheck.AutoSize = true;
            this.customerCheck.Location = new System.Drawing.Point(111, 149);
            this.customerCheck.Name = "customerCheck";
            this.customerCheck.Size = new System.Drawing.Size(76, 17);
            this.customerCheck.TabIndex = 4;
            this.customerCheck.Text = "Customer?";
            this.customerCheck.UseVisualStyleBackColor = true;
            this.customerCheck.CheckedChanged += new System.EventHandler(this.LoginpassCheck_CheckedChanged);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(691, 236);
            this.Controls.Add(this.customerCheck);
            this.Controls.Add(this.loginpassCheck);
            this.Controls.Add(this.registerLink);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.passtxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passwordLogin);
            this.Controls.Add(this.usernameLogin);
            this.Controls.Add(this.loginPrev);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.loginNext);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sign In";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loginNext;
        private System.Windows.Forms.TextBox usernameLogin;
        private System.Windows.Forms.TextBox passwordLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label passtxt;
        private System.Windows.Forms.Button loginPrev;
        private System.Windows.Forms.LinkLabel registerLink;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.CheckBox loginpassCheck;
        private System.Windows.Forms.CheckBox customerCheck;
    }
}