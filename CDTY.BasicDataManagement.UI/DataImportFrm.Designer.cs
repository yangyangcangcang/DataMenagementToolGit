namespace CDTY.BasicDataManagement.UI
{
    partial class DataImportFrm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSelectExcelFile = new System.Windows.Forms.Button();
            this.cmbSelectWorkerSheet = new System.Windows.Forms.ComboBox();
            this.btnOpenSheet = new System.Windows.Forms.Button();
            this.btnImportExcel = new System.Windows.Forms.Button();
            this.dgvExcelData = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExcelData)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(931, 518);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmbSelectWorkerSheet);
            this.panel1.Controls.Add(this.btnImportExcel);
            this.panel1.Controls.Add(this.btnOpenSheet);
            this.panel1.Controls.Add(this.btnSelectExcelFile);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(925, 44);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvExcelData);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 53);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(925, 462);
            this.panel2.TabIndex = 1;
            // 
            // btnSelectExcelFile
            // 
            this.btnSelectExcelFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(155)))), ((int)(((byte)(252)))));
            this.btnSelectExcelFile.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            this.btnSelectExcelFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectExcelFile.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSelectExcelFile.ForeColor = System.Drawing.Color.White;
            this.btnSelectExcelFile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSelectExcelFile.Location = new System.Drawing.Point(9, 5);
            this.btnSelectExcelFile.Name = "btnSelectExcelFile";
            this.btnSelectExcelFile.Size = new System.Drawing.Size(122, 32);
            this.btnSelectExcelFile.TabIndex = 2;
            this.btnSelectExcelFile.Text = "选择Excel文件";
            this.btnSelectExcelFile.UseVisualStyleBackColor = false;
            this.btnSelectExcelFile.Click += new System.EventHandler(this.btnSelectExcelFile_Click);
            // 
            // cmbSelectWorkerSheet
            // 
            this.cmbSelectWorkerSheet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            this.cmbSelectWorkerSheet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSelectWorkerSheet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbSelectWorkerSheet.FormattingEnabled = true;
            this.cmbSelectWorkerSheet.Location = new System.Drawing.Point(137, 13);
            this.cmbSelectWorkerSheet.Name = "cmbSelectWorkerSheet";
            this.cmbSelectWorkerSheet.Size = new System.Drawing.Size(133, 20);
            this.cmbSelectWorkerSheet.TabIndex = 3;
            // 
            // btnOpenSheet
            // 
            this.btnOpenSheet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(155)))), ((int)(((byte)(252)))));
            this.btnOpenSheet.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            this.btnOpenSheet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenSheet.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnOpenSheet.ForeColor = System.Drawing.Color.White;
            this.btnOpenSheet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOpenSheet.Location = new System.Drawing.Point(276, 5);
            this.btnOpenSheet.Name = "btnOpenSheet";
            this.btnOpenSheet.Size = new System.Drawing.Size(97, 32);
            this.btnOpenSheet.TabIndex = 2;
            this.btnOpenSheet.Text = "打开Excel表";
            this.btnOpenSheet.UseVisualStyleBackColor = false;
            this.btnOpenSheet.Click += new System.EventHandler(this.btnOpenSheet_Click);
            // 
            // btnImportExcel
            // 
            this.btnImportExcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(155)))), ((int)(((byte)(252)))));
            this.btnImportExcel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            this.btnImportExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImportExcel.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnImportExcel.ForeColor = System.Drawing.Color.White;
            this.btnImportExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImportExcel.Location = new System.Drawing.Point(753, 5);
            this.btnImportExcel.Name = "btnImportExcel";
            this.btnImportExcel.Size = new System.Drawing.Size(97, 32);
            this.btnImportExcel.TabIndex = 2;
            this.btnImportExcel.Text = "导入数据库";
            this.btnImportExcel.UseVisualStyleBackColor = false;
            this.btnImportExcel.Click += new System.EventHandler(this.btnImportExcel_Click);
            // 
            // dgvExcelData
            // 
            this.dgvExcelData.AllowUserToAddRows = false;
            this.dgvExcelData.AllowUserToDeleteRows = false;
            this.dgvExcelData.AllowUserToResizeColumns = false;
            this.dgvExcelData.AllowUserToResizeRows = false;
            this.dgvExcelData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvExcelData.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvExcelData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvExcelData.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(29)))), ((int)(((byte)(67)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvExcelData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvExcelData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(29)))), ((int)(((byte)(67)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvExcelData.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvExcelData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvExcelData.EnableHeadersVisualStyles = false;
            this.dgvExcelData.Location = new System.Drawing.Point(0, 0);
            this.dgvExcelData.MultiSelect = false;
            this.dgvExcelData.Name = "dgvExcelData";
            this.dgvExcelData.ReadOnly = true;
            this.dgvExcelData.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(29)))), ((int)(((byte)(67)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvExcelData.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvExcelData.RowHeadersVisible = false;
            this.dgvExcelData.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.dgvExcelData.RowTemplate.Height = 30;
            this.dgvExcelData.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvExcelData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvExcelData.Size = new System.Drawing.Size(925, 462);
            this.dgvExcelData.TabIndex = 1;
            // 
            // DataImportFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(931, 518);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DataImportFrm";
            this.Text = "DataImportFrm";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvExcelData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbSelectWorkerSheet;
        private System.Windows.Forms.Button btnImportExcel;
        private System.Windows.Forms.Button btnOpenSheet;
        private System.Windows.Forms.Button btnSelectExcelFile;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvExcelData;
    }
}