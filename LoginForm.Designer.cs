namespace CondSecurityRFID
{
    partial class LoginForm
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
            this.LBL_Header = new System.Windows.Forms.Label();
            this.LBL_USERTEXT = new System.Windows.Forms.Label();
            this.TB_USER = new System.Windows.Forms.TextBox();
            this.TB_PASS = new System.Windows.Forms.TextBox();
            this.Btn_Login = new System.Windows.Forms.Button();
            this.LBL_USERPASS = new System.Windows.Forms.Label();
            this.LBL_ResultLogin = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LBL_Header
            // 
            this.LBL_Header.AutoSize = true;
            this.LBL_Header.Font = new System.Drawing.Font("Trebuchet MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Header.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.LBL_Header.Location = new System.Drawing.Point(36, 9);
            this.LBL_Header.Name = "LBL_Header";
            this.LBL_Header.Size = new System.Drawing.Size(266, 80);
            this.LBL_Header.TabIndex = 0;
            this.LBL_Header.Text = "COND SECURITY \r\n        LOGIN";
            this.LBL_Header.Click += new System.EventHandler(this.LBL_Header_Click);
            // 
            // LBL_USERTEXT
            // 
            this.LBL_USERTEXT.AutoSize = true;
            this.LBL_USERTEXT.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold);
            this.LBL_USERTEXT.Location = new System.Drawing.Point(91, 110);
            this.LBL_USERTEXT.Name = "LBL_USERTEXT";
            this.LBL_USERTEXT.Size = new System.Drawing.Size(82, 22);
            this.LBL_USERTEXT.TabIndex = 1;
            this.LBL_USERTEXT.Text = "USUARIO:";
            // 
            // TB_USER
            // 
            this.TB_USER.Location = new System.Drawing.Point(95, 135);
            this.TB_USER.Name = "TB_USER";
            this.TB_USER.Size = new System.Drawing.Size(149, 20);
            this.TB_USER.TabIndex = 2;
            this.TB_USER.TextChanged += new System.EventHandler(this.TB_USER_TextChanged);
            // 
            // TB_PASS
            // 
            this.TB_PASS.Location = new System.Drawing.Point(95, 193);
            this.TB_PASS.Name = "TB_PASS";
            this.TB_PASS.PasswordChar = '*';
            this.TB_PASS.Size = new System.Drawing.Size(149, 20);
            this.TB_PASS.TabIndex = 3;
            // 
            // Btn_Login
            // 
            this.Btn_Login.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold);
            this.Btn_Login.Location = new System.Drawing.Point(96, 244);
            this.Btn_Login.Name = "Btn_Login";
            this.Btn_Login.Size = new System.Drawing.Size(147, 30);
            this.Btn_Login.TabIndex = 4;
            this.Btn_Login.Text = "ENTRAR";
            this.Btn_Login.UseVisualStyleBackColor = true;
            this.Btn_Login.Click += new System.EventHandler(this.Btn_Login_Click);
            // 
            // LBL_USERPASS
            // 
            this.LBL_USERPASS.AutoSize = true;
            this.LBL_USERPASS.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold);
            this.LBL_USERPASS.Location = new System.Drawing.Point(91, 168);
            this.LBL_USERPASS.Name = "LBL_USERPASS";
            this.LBL_USERPASS.Size = new System.Drawing.Size(66, 22);
            this.LBL_USERPASS.TabIndex = 5;
            this.LBL_USERPASS.Text = "SENHA:";
            // 
            // LBL_ResultLogin
            // 
            this.LBL_ResultLogin.AutoSize = true;
            this.LBL_ResultLogin.Location = new System.Drawing.Point(95, 281);
            this.LBL_ResultLogin.Name = "LBL_ResultLogin";
            this.LBL_ResultLogin.Size = new System.Drawing.Size(0, 13);
            this.LBL_ResultLogin.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = global::CondSecurityRFID.Properties.Resources.LogoEmpresa;
            this.pictureBox1.Image = global::CondSecurityRFID.Properties.Resources.LogoApp;
            this.pictureBox1.InitialImage = global::CondSecurityRFID.Properties.Resources.LogoEmpresa;
            this.pictureBox1.Location = new System.Drawing.Point(0, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(372, 95);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_2);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 369);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LBL_ResultLogin);
            this.Controls.Add(this.LBL_USERPASS);
            this.Controls.Add(this.Btn_Login);
            this.Controls.Add(this.TB_PASS);
            this.Controls.Add(this.TB_USER);
            this.Controls.Add(this.LBL_USERTEXT);
            this.Controls.Add(this.LBL_Header);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBL_Header;
        private System.Windows.Forms.Label LBL_USERTEXT;
        private System.Windows.Forms.TextBox TB_USER;
        private System.Windows.Forms.TextBox TB_PASS;
        private System.Windows.Forms.Button Btn_Login;
        private System.Windows.Forms.Label LBL_USERPASS;
        private System.Windows.Forms.Label LBL_ResultLogin;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}