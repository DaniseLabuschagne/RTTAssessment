namespace ClientInformation
{
    partial class frmClientList
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
            this.dgvClientList = new System.Windows.Forms.DataGridView();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btnExportClients = new System.Windows.Forms.Button();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvClientList
            // 
            this.dgvClientList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Edit});
            this.dgvClientList.Location = new System.Drawing.Point(13, 2);
            this.dgvClientList.Name = "dgvClientList";
            this.dgvClientList.Size = new System.Drawing.Size(996, 504);
            this.dgvClientList.TabIndex = 0;
            this.dgvClientList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientList_CellClick);
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(851, 542);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(158, 23);
            this.btnAddNew.TabIndex = 1;
            this.btnAddNew.Text = "Add New Client";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // btnExportClients
            // 
            this.btnExportClients.Location = new System.Drawing.Point(13, 542);
            this.btnExportClients.Name = "btnExportClients";
            this.btnExportClients.Size = new System.Drawing.Size(158, 23);
            this.btnExportClients.TabIndex = 2;
            this.btnExportClients.Text = "Export All Clients";
            this.btnExportClients.UseVisualStyleBackColor = true;
            this.btnExportClients.Click += new System.EventHandler(this.btnExportClients_Click);
            // 
            // Edit
            // 
            this.Edit.HeaderText = "Edit";
            this.Edit.Name = "Edit";
            // 
            // frmClientList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 577);
            this.Controls.Add(this.btnExportClients);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.dgvClientList);
            this.Name = "frmClientList";
            this.Text = "Client List";
            this.Load += new System.EventHandler(this.frmClientList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvClientList;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Button btnExportClients;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
    }
}

