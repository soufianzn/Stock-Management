namespace FastFoodDemo
{
    partial class CommandUserControl
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.id_Commande = new System.Windows.Forms.TextBox();
            this.TCSearch = new System.Windows.Forms.TextBox();
            this.TCValidation = new System.Windows.Forms.TextBox();
            this.Date_Commande = new System.Windows.Forms.TextBox();
            this.BDeleteCommande = new System.Windows.Forms.Button();
            this.BEditCommande = new System.Windows.Forms.Button();
            this.BAddCommande = new System.Windows.Forms.Button();
            this.BSearchCommande = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.RDNValider = new System.Windows.Forms.RadioButton();
            this.RDValider = new System.Windows.Forms.RadioButton();
            this.CommandeDataGrid = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CommandeDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.CommandeDataGrid);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(811, 400);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Commande";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.panel1);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.id_Commande);
            this.groupBox3.Controls.Add(this.TCSearch);
            this.groupBox3.Controls.Add(this.TCValidation);
            this.groupBox3.Controls.Add(this.Date_Commande);
            this.groupBox3.Controls.Add(this.BDeleteCommande);
            this.groupBox3.Controls.Add(this.BEditCommande);
            this.groupBox3.Controls.Add(this.BAddCommande);
            this.groupBox3.Controls.Add(this.BSearchCommande);
            this.groupBox3.Location = new System.Drawing.Point(6, 281);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(534, 113);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(337, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(61, 51);
            this.panel1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Search";
            //this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Date";
            // 
            // id_Commande
            // 
            this.id_Commande.Location = new System.Drawing.Point(346, 70);
            this.id_Commande.Name = "id_Commande";
            this.id_Commande.Size = new System.Drawing.Size(20, 20);
            this.id_Commande.TabIndex = 1;
            // 
            // TCSearch
            // 
            this.TCSearch.Location = new System.Drawing.Point(53, 67);
            this.TCSearch.Name = "TCSearch";
            this.TCSearch.Size = new System.Drawing.Size(158, 20);
            this.TCSearch.TabIndex = 1;
            // 
            // TCValidation
            // 
            this.TCValidation.Location = new System.Drawing.Point(404, 70);
            this.TCValidation.Name = "TCValidation";
            this.TCValidation.Size = new System.Drawing.Size(124, 20);
            this.TCValidation.TabIndex = 1;
            // 
            // Date_Commande
            // 
            this.Date_Commande.Location = new System.Drawing.Point(53, 26);
            this.Date_Commande.Name = "Date_Commande";
            this.Date_Commande.Size = new System.Drawing.Size(158, 20);
            this.Date_Commande.TabIndex = 1;
            // 
            // BDeleteCommande
            // 
            this.BDeleteCommande.Location = new System.Drawing.Point(404, 23);
            this.BDeleteCommande.Name = "BDeleteCommande";
            this.BDeleteCommande.Size = new System.Drawing.Size(75, 23);
            this.BDeleteCommande.TabIndex = 1;
            this.BDeleteCommande.Text = "Delete";
            this.BDeleteCommande.UseVisualStyleBackColor = true;
            this.BDeleteCommande.Click += new System.EventHandler(this.BDeleteCommande_Click);
            // 
            // BEditCommande
            // 
            this.BEditCommande.Location = new System.Drawing.Point(323, 23);
            this.BEditCommande.Name = "BEditCommande";
            this.BEditCommande.Size = new System.Drawing.Size(75, 23);
            this.BEditCommande.TabIndex = 1;
            this.BEditCommande.Text = "Edit";
            this.BEditCommande.UseVisualStyleBackColor = true;
            this.BEditCommande.Click += new System.EventHandler(this.BEditCommande_Click);
            // 
            // BAddCommande
            // 
            this.BAddCommande.Location = new System.Drawing.Point(242, 23);
            this.BAddCommande.Name = "BAddCommande";
            this.BAddCommande.Size = new System.Drawing.Size(75, 23);
            this.BAddCommande.TabIndex = 1;
            this.BAddCommande.Text = "Add";
            this.BAddCommande.UseVisualStyleBackColor = true;
            this.BAddCommande.Click += new System.EventHandler(this.BAddCommande_Click);
            // 
            // BSearchCommande
            // 
            this.BSearchCommande.Location = new System.Drawing.Point(242, 65);
            this.BSearchCommande.Name = "BSearchCommande";
            this.BSearchCommande.Size = new System.Drawing.Size(75, 23);
            this.BSearchCommande.TabIndex = 1;
            this.BSearchCommande.Text = "Search";
            this.BSearchCommande.UseVisualStyleBackColor = true;
            this.BSearchCommande.Click += new System.EventHandler(this.BSearchCommande_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.RDNValider);
            this.groupBox2.Controls.Add(this.RDValider);
            this.groupBox2.Location = new System.Drawing.Point(567, 281);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(238, 113);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Commande Validation";
            // 
            // RDNValider
            // 
            this.RDNValider.AutoSize = true;
            this.RDNValider.Location = new System.Drawing.Point(136, 38);
            this.RDNValider.Name = "RDNValider";
            this.RDNValider.Size = new System.Drawing.Size(80, 17);
            this.RDNValider.TabIndex = 4;
            this.RDNValider.TabStop = true;
            this.RDNValider.Text = "Non Valider";
            this.RDNValider.UseVisualStyleBackColor = true;
            // 
            // RDValider
            // 
            this.RDValider.AutoSize = true;
            this.RDValider.Location = new System.Drawing.Point(27, 38);
            this.RDValider.Name = "RDValider";
            this.RDValider.Size = new System.Drawing.Size(57, 17);
            this.RDValider.TabIndex = 3;
            this.RDValider.TabStop = true;
            this.RDValider.Text = "Valider";
            this.RDValider.UseVisualStyleBackColor = true;
            // 
            // CommandeDataGrid
            // 
            this.CommandeDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CommandeDataGrid.Location = new System.Drawing.Point(6, 19);
            this.CommandeDataGrid.Name = "CommandeDataGrid";
            this.CommandeDataGrid.Size = new System.Drawing.Size(799, 256);
            this.CommandeDataGrid.TabIndex = 0;
            // 
            // CommandUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "CommandUserControl";
            this.Size = new System.Drawing.Size(817, 406);
            this.Load += new System.EventHandler(this.CommandUserControl_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CommandeDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView CommandeDataGrid;
        private System.Windows.Forms.RadioButton RDNValider;
        private System.Windows.Forms.RadioButton RDValider;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BSearchCommande;
        private System.Windows.Forms.TextBox Date_Commande;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button BDeleteCommande;
        private System.Windows.Forms.Button BEditCommande;
        private System.Windows.Forms.Button BAddCommande;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox id_Commande;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TCSearch;
        private System.Windows.Forms.TextBox TCValidation;
    }
}
