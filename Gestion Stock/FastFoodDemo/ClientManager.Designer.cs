namespace FastFoodDemo
{
    partial class ClientManager
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
            this.label1 = new System.Windows.Forms.Label();
            this.TNom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TPrenom = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TTEL = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TCity = new System.Windows.Forms.TextBox();
            this.BAdd = new System.Windows.Forms.Button();
            this.BEdit = new System.Windows.Forms.Button();
            this.BDelete = new System.Windows.Forms.Button();
            this.TSearch = new System.Windows.Forms.TextBox();
            this.BSearch = new System.Windows.Forms.Button();
            this.ClientDataGrid = new System.Windows.Forms.DataGridView();
            this.TClienID = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.ClientDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // TNom
            // 
            this.TNom.Location = new System.Drawing.Point(101, 17);
            this.TNom.Name = "TNom";
            this.TNom.Size = new System.Drawing.Size(164, 20);
            this.TNom.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Prenom";
            // 
            // TPrenom
            // 
            this.TPrenom.Location = new System.Drawing.Point(101, 59);
            this.TPrenom.Name = "TPrenom";
            this.TPrenom.Size = new System.Drawing.Size(164, 20);
            this.TPrenom.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Telephone";
            // 
            // TTEL
            // 
            this.TTEL.Location = new System.Drawing.Point(101, 100);
            this.TTEL.Name = "TTEL";
            this.TTEL.Size = new System.Drawing.Size(164, 20);
            this.TTEL.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Email";
            // 
            // TEmail
            // 
            this.TEmail.Location = new System.Drawing.Point(101, 143);
            this.TEmail.Name = "TEmail";
            this.TEmail.Size = new System.Drawing.Size(164, 20);
            this.TEmail.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "City";
            // 
            // TCity
            // 
            this.TCity.Location = new System.Drawing.Point(101, 182);
            this.TCity.Name = "TCity";
            this.TCity.Size = new System.Drawing.Size(164, 20);
            this.TCity.TabIndex = 1;
            // 
            // BAdd
            // 
            this.BAdd.Location = new System.Drawing.Point(26, 228);
            this.BAdd.Name = "BAdd";
            this.BAdd.Size = new System.Drawing.Size(95, 23);
            this.BAdd.TabIndex = 3;
            this.BAdd.Text = "Add";
            this.BAdd.UseVisualStyleBackColor = true;
            this.BAdd.Click += new System.EventHandler(this.BAdd_Click);
            // 
            // BEdit
            // 
            this.BEdit.Location = new System.Drawing.Point(127, 228);
            this.BEdit.Name = "BEdit";
            this.BEdit.Size = new System.Drawing.Size(95, 23);
            this.BEdit.TabIndex = 3;
            this.BEdit.Text = "Edit";
            this.BEdit.UseVisualStyleBackColor = true;
            this.BEdit.Click += new System.EventHandler(this.BEdit_Click);
            // 
            // BDelete
            // 
            this.BDelete.Location = new System.Drawing.Point(228, 228);
            this.BDelete.Name = "BDelete";
            this.BDelete.Size = new System.Drawing.Size(95, 23);
            this.BDelete.TabIndex = 3;
            this.BDelete.Text = "Delete";
            this.BDelete.UseVisualStyleBackColor = true;
            this.BDelete.Click += new System.EventHandler(this.BDelete_Click);
            // 
            // TSearch
            // 
            this.TSearch.Location = new System.Drawing.Point(26, 279);
            this.TSearch.Name = "TSearch";
            this.TSearch.Size = new System.Drawing.Size(164, 20);
            this.TSearch.TabIndex = 1;
            // 
            // BSearch
            // 
            this.BSearch.Location = new System.Drawing.Point(211, 276);
            this.BSearch.Name = "BSearch";
            this.BSearch.Size = new System.Drawing.Size(95, 23);
            this.BSearch.TabIndex = 3;
            this.BSearch.Text = "Search";
            this.BSearch.UseVisualStyleBackColor = true;
            this.BSearch.Click += new System.EventHandler(this.BSearch_Click);
            // 
            // ClientDataGrid
            // 
            this.ClientDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ClientDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClientDataGrid.Location = new System.Drawing.Point(329, 17);
            this.ClientDataGrid.Name = "ClientDataGrid";
            this.ClientDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ClientDataGrid.Size = new System.Drawing.Size(471, 369);
            this.ClientDataGrid.TabIndex = 4;
            this.ClientDataGrid.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ClientDataGrid_MouseClick);
            // 
            // TClienID
            // 
            this.TClienID.Location = new System.Drawing.Point(26, 335);
            this.TClienID.Name = "TClienID";
            this.TClienID.Size = new System.Drawing.Size(76, 20);
            this.TClienID.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(26, 306);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(100, 100);
            this.panel1.TabIndex = 6;
            // 
            // ClientManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ClientDataGrid);
            this.Controls.Add(this.BSearch);
            this.Controls.Add(this.BDelete);
            this.Controls.Add(this.BEdit);
            this.Controls.Add(this.BAdd);
            this.Controls.Add(this.TSearch);
            this.Controls.Add(this.TCity);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TEmail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TTEL);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TPrenom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TNom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TClienID);
            this.Name = "ClientManager";
            this.Size = new System.Drawing.Size(817, 406);
            this.Load += new System.EventHandler(this.ClientManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ClientDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TNom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TPrenom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TTEL;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TCity;
        private System.Windows.Forms.Button BAdd;
        private System.Windows.Forms.Button BEdit;
        private System.Windows.Forms.Button BDelete;
        private System.Windows.Forms.TextBox TSearch;
        private System.Windows.Forms.Button BSearch;
        private System.Windows.Forms.DataGridView ClientDataGrid;
        private System.Windows.Forms.TextBox TClienID;
        private System.Windows.Forms.Panel panel1;
    }
}
