namespace CondSecurityRFID
{
    partial class HomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            this.LBL_Conexao = new System.Windows.Forms.Label();
            this.LBL_ENVIO = new System.Windows.Forms.Label();
            this.LBL_TAG = new System.Windows.Forms.Label();
            this.BTN_Test_Conn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LBL_TAG_ENVIO = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // LBL_Conexao
            // 
            this.LBL_Conexao.AutoSize = true;
            this.LBL_Conexao.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold);
            this.LBL_Conexao.Location = new System.Drawing.Point(14, 64);
            this.LBL_Conexao.Name = "LBL_Conexao";
            this.LBL_Conexao.Size = new System.Drawing.Size(77, 18);
            this.LBL_Conexao.TabIndex = 1;
            this.LBL_Conexao.Text = "Conectado";
            this.LBL_Conexao.Click += new System.EventHandler(this.LBL_Conexao_Click);
            // 
            // LBL_ENVIO
            // 
            this.LBL_ENVIO.AutoSize = true;
            this.LBL_ENVIO.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold);
            this.LBL_ENVIO.Location = new System.Drawing.Point(44, 140);
            this.LBL_ENVIO.Name = "LBL_ENVIO";
            this.LBL_ENVIO.Size = new System.Drawing.Size(90, 27);
            this.LBL_ENVIO.TabIndex = 2;
            this.LBL_ENVIO.Text = "Enviado";
            this.LBL_ENVIO.Click += new System.EventHandler(this.LBL_ENVIO_Click);
            // 
            // LBL_TAG
            // 
            this.LBL_TAG.AutoSize = true;
            this.LBL_TAG.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_TAG.Location = new System.Drawing.Point(192, 91);
            this.LBL_TAG.Name = "LBL_TAG";
            this.LBL_TAG.Size = new System.Drawing.Size(171, 20);
            this.LBL_TAG.TabIndex = 4;
            this.LBL_TAG.Text = "000000000000000000";
            this.LBL_TAG.Click += new System.EventHandler(this.LBL_TAG_Click);
            // 
            // BTN_Test_Conn
            // 
            this.BTN_Test_Conn.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold);
            this.BTN_Test_Conn.Location = new System.Drawing.Point(12, 84);
            this.BTN_Test_Conn.Name = "BTN_Test_Conn";
            this.BTN_Test_Conn.Size = new System.Drawing.Size(153, 28);
            this.BTN_Test_Conn.TabIndex = 5;
            this.BTN_Test_Conn.Text = "Testar conexão";
            this.BTN_Test_Conn.UseVisualStyleBackColor = true;
            this.BTN_Test_Conn.Click += new System.EventHandler(this.BTN_Test_Conn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = global::CondSecurityRFID.Properties.Resources.LogoEmpresa1;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(147, 205);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(79, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.ErrorImage = global::CondSecurityRFID.Properties.Resources.LogoEmpresa;
            this.pictureBox2.Image = global::CondSecurityRFID.Properties.Resources.LogoApp;
            this.pictureBox2.InitialImage = global::CondSecurityRFID.Properties.Resources.LogoEmpresa;
            this.pictureBox2.Location = new System.Drawing.Point(72, 7);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(229, 53);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(191, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 27);
            this.label1.TabIndex = 9;
            this.label1.Text = "Rfid Detectado";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // LBL_TAG_ENVIO
            // 
            this.LBL_TAG_ENVIO.AutoSize = true;
            this.LBL_TAG_ENVIO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_TAG_ENVIO.Location = new System.Drawing.Point(101, 167);
            this.LBL_TAG_ENVIO.Name = "LBL_TAG_ENVIO";
            this.LBL_TAG_ENVIO.Size = new System.Drawing.Size(171, 20);
            this.LBL_TAG_ENVIO.TabIndex = 10;
            this.LBL_TAG_ENVIO.Text = "000000000000000000";
            this.LBL_TAG_ENVIO.Click += new System.EventHandler(this.LBL_TAG_ENVIO_Click);
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(373, 293);
            this.Controls.Add(this.LBL_TAG_ENVIO);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BTN_Test_Conn);
            this.Controls.Add(this.LBL_TAG);
            this.Controls.Add(this.LBL_ENVIO);
            this.Controls.Add(this.LBL_Conexao);
            this.Name = "HomeForm";
            this.Text = "HomeForm";
            this.Load += new System.EventHandler(this.HomeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LBL_Conexao;
        private System.Windows.Forms.Label LBL_ENVIO;
        private System.Windows.Forms.Label LBL_TAG;
        private System.Windows.Forms.Button BTN_Test_Conn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LBL_TAG_ENVIO;
    }
}