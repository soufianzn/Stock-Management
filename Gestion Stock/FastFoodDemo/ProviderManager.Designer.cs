namespace FastFoodDemo
{
    partial class ProviderManager
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.TPRName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TPRAdresse = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TPRCity = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TPRPhone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ProviderDataGrid = new System.Windows.Forms.DataGridView();
            this.BPRSearch = new System.Windows.Forms.Button();
            this.BPRDelete = new System.Windows.Forms.Button();
            this.BPRAdd = new System.Windows.Forms.Button();
            this.TPRSearch = new System.Windows.Forms.TextBox();
            this.BPREdit = new System.Windows.Forms.Button();
            this.TPRID = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.ProviderDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // TPRName
            // 
            this.TPRName.Location = new System.Drawing.Point(114, 57);
            this.TPRName.Name = "TPRName";
            this.TPRName.Size = new System.Drawing.Size(172, 20);
            this.TPRName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Provider Name";
            // 
            // TPRAdresse
            // 
            this.TPRAdresse.Location = new System.Drawing.Point(114, 99);
            this.TPRAdresse.Name = "TPRAdresse";
            this.TPRAdresse.Size = new System.Drawing.Size(172, 20);
            this.TPRAdresse.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Addresse";
            // 
            // TPRCity
            // 
            this.TPRCity.Location = new System.Drawing.Point(114, 141);
            this.TPRCity.Name = "TPRCity";
            this.TPRCity.Size = new System.Drawing.Size(172, 20);
            this.TPRCity.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "City";
            // 
            // TPRPhone
            // 
            this.TPRPhone.Location = new System.Drawing.Point(114, 186);
            this.TPRPhone.Name = "TPRPhone";
            this.TPRPhone.Size = new System.Drawing.Size(172, 20);
            this.TPRPhone.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Phone";
            // 
            // ProviderDataGrid
            // 
            this.ProviderDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProviderDataGrid.Location = new System.Drawing.Point(324, 19);
            this.ProviderDataGrid.Name = "ProviderDataGrid";
            this.ProviderDataGrid.Size = new System.Drawing.Size(481, 369);
            this.ProviderDataGrid.TabIndex = 10;
            this.ProviderDataGrid.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ProviderDataGrid_MouseClick);
            // 
            // BPRSearch
            // 
            this.BPRSearch.Location = new System.Drawing.Point(206, 310);
            this.BPRSearch.Name = "BPRSearch";
            this.BPRSearch.Size = new System.Drawing.Size(95, 23);
            this.BPRSearch.TabIndex = 6;
            this.BPRSearch.Text = "Search";
            this.BPRSearch.UseVisualStyleBackColor = true;
            this.BPRSearch.Click += new System.EventHandler(this.BPRSearch_Click);
            // 
            // BPRDelete
            // 
            this.BPRDelete.Location = new System.Drawing.Point(223, 262);
            this.BPRDelete.Name = "BPRDelete";
            this.BPRDelete.Size = new System.Drawing.Size(95, 23);
            this.BPRDelete.TabIndex = 7;
            this.BPRDelete.Text = "Delete";
            this.BPRDelete.UseVisualStyleBackColor = true;
            this.BPRDelete.Click += new System.EventHandler(this.BPRDelete_Click);
            // 
            // BPRAdd
            // 
            this.BPRAdd.Location = new System.Drawing.Point(21, 262);
            this.BPRAdd.Name = "BPRAdd";
            this.BPRAdd.Size = new System.Drawing.Size(95, 23);
            this.BPRAdd.TabIndex = 9;
            this.BPRAdd.Text = "Add";
            this.BPRAdd.UseVisualStyleBackColor = true;
            this.BPRAdd.Click += new System.EventHandler(this.BPRAdd_Click);
            // 
            // TPRSearch
            // 
            this.TPRSearch.Location = new System.Drawing.Point(21, 313);
            this.TPRSearch.Name = "TPRSearch";
            this.TPRSearch.Size = new System.Drawing.Size(164, 20);
            this.TPRSearch.TabIndex = 5;
            // 
            // BPREdit
            // 
            this.BPREdit.Location = new System.Drawing.Point(122, 262);
            this.BPREdit.Name = "BPREdit";
            this.BPREdit.Size = new System.Drawing.Size(95, 23);
            this.BPREdit.TabIndex = 8;
            this.BPREdit.Text = "Edit";
            this.BPREdit.UseVisualStyleBackColor = true;
            this.BPREdit.Click += new System.EventHandler(this.BPREdit_Click);
            // 
            // TPRID
            // 
            this.TPRID.Location = new System.Drawing.Point(49, 353);
            this.TPRID.Name = "TPRID";
            this.TPRID.Size = new System.Drawing.Size(21, 20);
            this.TPRID.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(34, 353);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(62, 33);
            this.panel1.TabIndex = 11;
            // 
            // ProviderManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ProviderDataGrid);
            this.Controls.Add(this.BPRSearch);
            this.Controls.Add(this.BPRDelete);
            this.Controls.Add(this.BPREdit);
            this.Controls.Add(this.BPRAdd);
            this.Controls.Add(this.TPRID);
            this.Controls.Add(this.TPRSearch);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TPRPhone);
            this.Controls.Add(this.TPRCity);
            this.Controls.Add(this.TPRAdresse);
            this.Controls.Add(this.TPRName);
            this.Name = "ProviderManager";
            this.Size = new System.Drawing.Size(817, 406);
            this.Load += new System.EventHandler(this.ProviderManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProviderDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox TPRName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TPRAdresse;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TPRCity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TPRPhone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView ProviderDataGrid;
        private System.Windows.Forms.Button BPRSearch;
        private System.Windows.Forms.Button BPRDelete;
        private System.Windows.Forms.Button BPRAdd;
        private System.Windows.Forms.TextBox TPRSearch;
        private System.Windows.Forms.Button BPREdit;
        private System.Windows.Forms.TextBox TPRID;
        private System.Windows.Forms.Panel panel1;
    }
}
