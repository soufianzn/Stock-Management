namespace FastFoodDemo
{
    partial class MySecondCustmControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LBigTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LBigTitle
            // 
            this.LBigTitle.AutoSize = true;
            this.LBigTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBigTitle.Location = new System.Drawing.Point(194, 197);
            this.LBigTitle.Name = "LBigTitle";
            this.LBigTitle.Size = new System.Drawing.Size(445, 51);
            this.LBigTitle.TabIndex = 0;
            this.LBigTitle.Text = "GESTION DE STOCK";
            // 
            // MySecondCustmControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LBigTitle);
            this.Name = "MySecondCustmControl";
            this.Size = new System.Drawing.Size(817, 406);
            this.Load += new System.EventHandler(this.MySecondCustmControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBigTitle;
    }
}
