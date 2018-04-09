namespace FastFoodDemo
{
    partial class Authentification_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Authentification_Form));
            this.BLogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TUsername = new System.Windows.Forms.TextBox();
            this.TPassword = new System.Windows.Forms.TextBox();
            this.BCancel = new System.Windows.Forms.Button();
            this.LError = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BLogin
            // 
            this.BLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BLogin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BLogin.Location = new System.Drawing.Point(334, 164);
            this.BLogin.Name = "BLogin";
            this.BLogin.Size = new System.Drawing.Size(90, 31);
            this.BLogin.TabIndex = 0;
            this.BLogin.Text = "Login";
            this.BLogin.UseVisualStyleBackColor = true;
            this.BLogin.Click += new System.EventHandler(this.BLogin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(231, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(231, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(179, 180);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // TUsername
            // 
            this.TUsername.Location = new System.Drawing.Point(334, 60);
            this.TUsername.Name = "TUsername";
            this.TUsername.Size = new System.Drawing.Size(222, 20);
            this.TUsername.TabIndex = 2;
            // 
            // TPassword
            // 
            this.TPassword.Location = new System.Drawing.Point(334, 104);
            this.TPassword.Name = "TPassword";
            this.TPassword.Size = new System.Drawing.Size(222, 20);
            this.TPassword.TabIndex = 2;
            // 
            // BCancel
            // 
            this.BCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BCancel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BCancel.Location = new System.Drawing.Point(444, 164);
            this.BCancel.Name = "BCancel";
            this.BCancel.Size = new System.Drawing.Size(90, 31);
            this.BCancel.TabIndex = 0;
            this.BCancel.Text = "Cancel";
            this.BCancel.UseVisualStyleBackColor = true;
            this.BCancel.Click += new System.EventHandler(this.BCancel_Click);
            // 
            // LError
            // 
            this.LError.AutoSize = true;
            this.LError.Location = new System.Drawing.Point(235, 212);
            this.LError.Name = "LError";
            this.LError.Size = new System.Drawing.Size(0, 13);
            this.LError.TabIndex = 4;
            // 
            // Authentification_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(587, 237);
            this.Controls.Add(this.LError);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.TPassword);
            this.Controls.Add(this.TUsername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BCancel);
            this.Controls.Add(this.BLogin);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Authentification_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Authentification_Form";
            this.Load += new System.EventHandler(this.Authentification_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox TUsername;
        private System.Windows.Forms.TextBox TPassword;
        private System.Windows.Forms.Button BCancel;
        private System.Windows.Forms.Label LError;
    }
}