
namespace ReportManager
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label lbReportType;
            System.Windows.Forms.Label lblReport;
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.cbSpan = new System.Windows.Forms.ComboBox();
            this.reportsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportsDBDataSet = new ReportManager.ReportsDBDataSet();
            this.tbReportInput = new System.Windows.Forms.RichTextBox();
            this.reportsDataGridView = new System.Windows.Forms.DataGridView();
            this.reportsTableAdapter = new ReportManager.ReportsDBDataSetTableAdapters.ReportsTableAdapter();
            this.tableAdapterManager = new ReportManager.ReportsDBDataSetTableAdapters.TableAdapterManager();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblNoRecordsFound = new System.Windows.Forms.Label();
            this.lblTimeSpan = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeSpan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblNoEdit = new System.Windows.Forms.Label();
            lbReportType = new System.Windows.Forms.Label();
            lblReport = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.reportsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportsDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // lbReportType
            // 
            lbReportType.AutoSize = true;
            lbReportType.Location = new System.Drawing.Point(373, 10);
            lbReportType.Name = "lbReportType";
            lbReportType.Size = new System.Drawing.Size(66, 13);
            lbReportType.TabIndex = 9;
            lbReportType.Text = "Report Type";
            // 
            // lblReport
            // 
            lblReport.AutoSize = true;
            lblReport.Location = new System.Drawing.Point(12, 34);
            lblReport.Name = "lblReport";
            lblReport.Size = new System.Drawing.Size(39, 13);
            lblReport.TabIndex = 10;
            lblReport.Text = "Report";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(15, 203);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(121, 23);
            this.btnSubmit.TabIndex = 1;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(324, 437);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(121, 23);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(12, 437);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(121, 23);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(324, 203);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(121, 23);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // cbSpan
            // 
            this.cbSpan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSpan.FormattingEnabled = true;
            this.cbSpan.Items.AddRange(new object[] {
            "Daily",
            "Weekly",
            "Monthly",
            "Quarterly",
            "Annually"});
            this.cbSpan.Location = new System.Drawing.Point(324, 26);
            this.cbSpan.Name = "cbSpan";
            this.cbSpan.Size = new System.Drawing.Size(121, 21);
            this.cbSpan.TabIndex = 10;
            // 
            // reportsBindingSource
            // 
            this.reportsBindingSource.DataMember = "Reports";
            this.reportsBindingSource.DataSource = this.reportsDBDataSet;
            // 
            // reportsDBDataSet
            // 
            this.reportsDBDataSet.DataSetName = "ReportsDBDataSet";
            this.reportsDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbReportInput
            // 
            this.tbReportInput.Location = new System.Drawing.Point(12, 53);
            this.tbReportInput.Name = "tbReportInput";
            this.tbReportInput.Size = new System.Drawing.Size(433, 144);
            this.tbReportInput.TabIndex = 11;
            this.tbReportInput.Text = "";
            // 
            // reportsDataGridView
            // 
            this.reportsDataGridView.AllowUserToAddRows = false;
            this.reportsDataGridView.AllowUserToDeleteRows = false;
            this.reportsDataGridView.AllowUserToResizeColumns = false;
            this.reportsDataGridView.AllowUserToResizeRows = false;
            this.reportsDataGridView.AutoGenerateColumns = false;
            this.reportsDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.reportsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reportsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.TimeSpan,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.reportsDataGridView.DataSource = this.reportsBindingSource;
            this.reportsDataGridView.Location = new System.Drawing.Point(12, 262);
            this.reportsDataGridView.Name = "reportsDataGridView";
            this.reportsDataGridView.ReadOnly = true;
            this.reportsDataGridView.RowHeadersVisible = false;
            this.reportsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.reportsDataGridView.Size = new System.Drawing.Size(433, 169);
            this.reportsDataGridView.TabIndex = 11;
            this.reportsDataGridView.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.reportsDataGridView_RowEnter);
            // 
            // reportsTableAdapter
            // 
            this.reportsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ReportsTableAdapter = this.reportsTableAdapter;
            this.tableAdapterManager.UpdateOrder = ReportManager.ReportsDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(15, 203);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(121, 23);
            this.btnUpdate.TabIndex = 12;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Visible = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(324, 203);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(121, 23);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblNoRecordsFound
            // 
            this.lblNoRecordsFound.AutoSize = true;
            this.lblNoRecordsFound.Location = new System.Drawing.Point(167, 442);
            this.lblNoRecordsFound.Name = "lblNoRecordsFound";
            this.lblNoRecordsFound.Size = new System.Drawing.Size(100, 13);
            this.lblNoRecordsFound.TabIndex = 14;
            this.lblNoRecordsFound.Text = "No Records Found.";
            this.lblNoRecordsFound.Visible = false;
            // 
            // lblTimeSpan
            // 
            this.lblTimeSpan.AutoSize = true;
            this.lblTimeSpan.Location = new System.Drawing.Point(152, 9);
            this.lblTimeSpan.Name = "lblTimeSpan";
            this.lblTimeSpan.Size = new System.Drawing.Size(35, 13);
            this.lblTimeSpan.TabIndex = 15;
            this.lblTimeSpan.Text = "label1";
            this.lblTimeSpan.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 25;
            // 
            // TimeSpan
            // 
            this.TimeSpan.DataPropertyName = "TimeSpan";
            this.TimeSpan.HeaderText = "TimeSpan";
            this.TimeSpan.Name = "TimeSpan";
            this.TimeSpan.ReadOnly = true;
            this.TimeSpan.Width = 65;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ReportData";
            this.dataGridViewTextBoxColumn3.FillWeight = 125F;
            this.dataGridViewTextBoxColumn3.HeaderText = "ReportData";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 220;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "TimeStamp";
            this.dataGridViewTextBoxColumn4.HeaderText = "TimeStamp";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // lblNoEdit
            // 
            this.lblNoEdit.AutoSize = true;
            this.lblNoEdit.Location = new System.Drawing.Point(139, 442);
            this.lblNoEdit.Name = "lblNoEdit";
            this.lblNoEdit.Size = new System.Drawing.Size(177, 13);
            this.lblNoEdit.TabIndex = 16;
            this.lblNoEdit.Text = "There must be a valid record to edit.";
            this.lblNoEdit.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 494);
            this.Controls.Add(this.lblNoEdit);
            this.Controls.Add(this.lblTimeSpan);
            this.Controls.Add(this.lblNoRecordsFound);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.reportsDataGridView);
            this.Controls.Add(lblReport);
            this.Controls.Add(this.tbReportInput);
            this.Controls.Add(lbReportType);
            this.Controls.Add(this.cbSpan);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reportsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportsDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnClear;
        private ReportsDBDataSet reportsDBDataSet;
        private System.Windows.Forms.BindingSource reportsBindingSource;
        private ReportsDBDataSetTableAdapters.ReportsTableAdapter reportsTableAdapter;
        private ReportsDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox cbSpan;
        private System.Windows.Forms.RichTextBox tbReportInput;
        private System.Windows.Forms.DataGridView reportsDataGridView;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblNoRecordsFound;
        private System.Windows.Forms.Label lblTimeSpan;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeSpan;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Label lblNoEdit;
    }
}

