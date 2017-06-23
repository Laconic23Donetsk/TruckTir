﻿namespace PartsApp
{
    partial class EmployeeOperationsInfoForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.BottomSplitContainer = new System.Windows.Forms.SplitContainer();
            this.OperationsGroupBox = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.OperationsStatusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.OperationsCountStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.OperationsDGV = new System.Windows.Forms.DataGridView();
            this.PurchaseCheckBox = new System.Windows.Forms.CheckBox();
            this.SaleCheckBox = new System.Windows.Forms.CheckBox();
            this.BeginDatePanel = new System.Windows.Forms.Panel();
            this.BeginDateCheckBox = new System.Windows.Forms.CheckBox();
            this.BeginDateDTP = new System.Windows.Forms.DateTimePicker();
            this.EndDatePanel = new System.Windows.Forms.Panel();
            this.EndDateCheckBox = new System.Windows.Forms.CheckBox();
            this.EndDateDTP = new System.Windows.Forms.DateTimePicker();
            this.OperationDetailsGroupBox = new System.Windows.Forms.GroupBox();
            this.OperationDetailsDGV = new System.Windows.Forms.DataGridView();
            this.ManufacturerCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ArticulCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TitleCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MeasureUnitCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CountCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SumCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.EmployeeGroupBox = new System.Windows.Forms.GroupBox();
            this.EmployeeListBox = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BottomSplitContainer)).BeginInit();
            this.BottomSplitContainer.Panel1.SuspendLayout();
            this.BottomSplitContainer.Panel2.SuspendLayout();
            this.BottomSplitContainer.SuspendLayout();
            this.OperationsGroupBox.SuspendLayout();
            this.OperationsStatusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OperationsDGV)).BeginInit();
            this.BeginDatePanel.SuspendLayout();
            this.EndDatePanel.SuspendLayout();
            this.OperationDetailsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OperationDetailsDGV)).BeginInit();
            this.EmployeeGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer1.Panel1.Controls.Add(this.EmployeeGroupBox);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.BottomSplitContainer);
            this.splitContainer1.Size = new System.Drawing.Size(779, 685);
            this.splitContainer1.SplitterDistance = 191;
            this.splitContainer1.TabIndex = 0;
            // 
            // BottomSplitContainer
            // 
            this.BottomSplitContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BottomSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BottomSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.BottomSplitContainer.Name = "BottomSplitContainer";
            this.BottomSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // BottomSplitContainer.Panel1
            // 
            this.BottomSplitContainer.Panel1.Controls.Add(this.OperationsGroupBox);
            // 
            // BottomSplitContainer.Panel2
            // 
            this.BottomSplitContainer.Panel2.BackColor = System.Drawing.SystemColors.Control;
            this.BottomSplitContainer.Panel2.Controls.Add(this.OperationDetailsGroupBox);
            this.BottomSplitContainer.Size = new System.Drawing.Size(779, 490);
            this.BottomSplitContainer.SplitterDistance = 249;
            this.BottomSplitContainer.SplitterWidth = 2;
            this.BottomSplitContainer.TabIndex = 0;
            // 
            // OperationsGroupBox
            // 
            this.OperationsGroupBox.BackColor = System.Drawing.SystemColors.Control;
            this.OperationsGroupBox.Controls.Add(this.label2);
            this.OperationsGroupBox.Controls.Add(this.label1);
            this.OperationsGroupBox.Controls.Add(this.OperationsStatusStrip);
            this.OperationsGroupBox.Controls.Add(this.OperationsDGV);
            this.OperationsGroupBox.Controls.Add(this.PurchaseCheckBox);
            this.OperationsGroupBox.Controls.Add(this.SaleCheckBox);
            this.OperationsGroupBox.Controls.Add(this.BeginDatePanel);
            this.OperationsGroupBox.Controls.Add(this.EndDatePanel);
            this.OperationsGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OperationsGroupBox.Location = new System.Drawing.Point(0, 0);
            this.OperationsGroupBox.Name = "OperationsGroupBox";
            this.OperationsGroupBox.Size = new System.Drawing.Size(779, 249);
            this.OperationsGroupBox.TabIndex = 0;
            this.OperationsGroupBox.TabStop = false;
            this.OperationsGroupBox.Text = "Операции";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(476, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "до :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(312, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "от :";
            // 
            // OperationsStatusStrip
            // 
            this.OperationsStatusStrip.AutoSize = false;
            this.OperationsStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.OperationsCountStatusLabel});
            this.OperationsStatusStrip.Location = new System.Drawing.Point(3, 228);
            this.OperationsStatusStrip.Name = "OperationsStatusStrip";
            this.OperationsStatusStrip.Size = new System.Drawing.Size(773, 18);
            this.OperationsStatusStrip.TabIndex = 1;
            this.OperationsStatusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(89, 13);
            this.toolStripStatusLabel1.Text = "Всего док-тов :";
            // 
            // OperationsCountStatusLabel
            // 
            this.OperationsCountStatusLabel.Name = "OperationsCountStatusLabel";
            this.OperationsCountStatusLabel.Size = new System.Drawing.Size(0, 13);
            // 
            // OperationsDGV
            // 
            this.OperationsDGV.AllowUserToAddRows = false;
            this.OperationsDGV.AllowUserToDeleteRows = false;
            this.OperationsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OperationsDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OperationsDGV.Location = new System.Drawing.Point(3, 16);
            this.OperationsDGV.Name = "OperationsDGV";
            this.OperationsDGV.ReadOnly = true;
            this.OperationsDGV.Size = new System.Drawing.Size(773, 230);
            this.OperationsDGV.TabIndex = 0;
            // 
            // PurchaseCheckBox
            // 
            this.PurchaseCheckBox.AutoSize = true;
            this.PurchaseCheckBox.Checked = true;
            this.PurchaseCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.PurchaseCheckBox.Location = new System.Drawing.Point(124, 0);
            this.PurchaseCheckBox.Name = "PurchaseCheckBox";
            this.PurchaseCheckBox.Size = new System.Drawing.Size(63, 17);
            this.PurchaseCheckBox.TabIndex = 3;
            this.PurchaseCheckBox.Text = "Приход";
            this.PurchaseCheckBox.UseVisualStyleBackColor = true;
            // 
            // SaleCheckBox
            // 
            this.SaleCheckBox.AutoSize = true;
            this.SaleCheckBox.Checked = true;
            this.SaleCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SaleCheckBox.Location = new System.Drawing.Point(193, 0);
            this.SaleCheckBox.Name = "SaleCheckBox";
            this.SaleCheckBox.Size = new System.Drawing.Size(62, 17);
            this.SaleCheckBox.TabIndex = 4;
            this.SaleCheckBox.Text = "Расход";
            this.SaleCheckBox.UseVisualStyleBackColor = true;
            // 
            // BeginDatePanel
            // 
            this.BeginDatePanel.Controls.Add(this.BeginDateCheckBox);
            this.BeginDatePanel.Controls.Add(this.BeginDateDTP);
            this.BeginDatePanel.Location = new System.Drawing.Point(342, -1);
            this.BeginDatePanel.Name = "BeginDatePanel";
            this.BeginDatePanel.Size = new System.Drawing.Size(108, 18);
            this.BeginDatePanel.TabIndex = 7;
            // 
            // BeginDateCheckBox
            // 
            this.BeginDateCheckBox.AutoSize = true;
            this.BeginDateCheckBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BeginDateCheckBox.Checked = true;
            this.BeginDateCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.BeginDateCheckBox.Location = new System.Drawing.Point(59, 2);
            this.BeginDateCheckBox.Name = "BeginDateCheckBox";
            this.BeginDateCheckBox.Size = new System.Drawing.Size(15, 14);
            this.BeginDateCheckBox.TabIndex = 6;
            this.BeginDateCheckBox.UseVisualStyleBackColor = false;
            this.BeginDateCheckBox.CheckedChanged += new System.EventHandler(this.DatesCheckBox_CheckedChanged);
            // 
            // BeginDateDTP
            // 
            this.BeginDateDTP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BeginDateDTP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.BeginDateDTP.Location = new System.Drawing.Point(0, 0);
            this.BeginDateDTP.MinDate = new System.DateTime(2015, 1, 1, 0, 0, 0, 0);
            this.BeginDateDTP.Name = "BeginDateDTP";
            this.BeginDateDTP.Size = new System.Drawing.Size(108, 20);
            this.BeginDateDTP.TabIndex = 5;
            this.toolTip1.SetToolTip(this.BeginDateDTP, "Начальная дата");
            this.BeginDateDTP.Value = new System.DateTime(2017, 9, 21, 0, 0, 0, 0);
            // 
            // EndDatePanel
            // 
            this.EndDatePanel.Controls.Add(this.EndDateCheckBox);
            this.EndDatePanel.Controls.Add(this.EndDateDTP);
            this.EndDatePanel.Location = new System.Drawing.Point(507, -1);
            this.EndDatePanel.Name = "EndDatePanel";
            this.EndDatePanel.Size = new System.Drawing.Size(108, 18);
            this.EndDatePanel.TabIndex = 9;
            // 
            // EndDateCheckBox
            // 
            this.EndDateCheckBox.AutoSize = true;
            this.EndDateCheckBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.EndDateCheckBox.Checked = true;
            this.EndDateCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.EndDateCheckBox.Location = new System.Drawing.Point(59, 2);
            this.EndDateCheckBox.Name = "EndDateCheckBox";
            this.EndDateCheckBox.Size = new System.Drawing.Size(15, 14);
            this.EndDateCheckBox.TabIndex = 6;
            this.EndDateCheckBox.UseVisualStyleBackColor = false;
            this.EndDateCheckBox.CheckedChanged += new System.EventHandler(this.DatesCheckBox_CheckedChanged);
            // 
            // EndDateDTP
            // 
            this.EndDateDTP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EndDateDTP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.EndDateDTP.Location = new System.Drawing.Point(0, 0);
            this.EndDateDTP.MinDate = new System.DateTime(2015, 1, 1, 0, 0, 0, 0);
            this.EndDateDTP.Name = "EndDateDTP";
            this.EndDateDTP.Size = new System.Drawing.Size(108, 20);
            this.EndDateDTP.TabIndex = 5;
            this.toolTip1.SetToolTip(this.EndDateDTP, "Начальная дата");
            this.EndDateDTP.Value = new System.DateTime(2017, 9, 21, 0, 0, 0, 0);
            // 
            // OperationDetailsGroupBox
            // 
            this.OperationDetailsGroupBox.Controls.Add(this.OperationDetailsDGV);
            this.OperationDetailsGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OperationDetailsGroupBox.Location = new System.Drawing.Point(0, 0);
            this.OperationDetailsGroupBox.Name = "OperationDetailsGroupBox";
            this.OperationDetailsGroupBox.Size = new System.Drawing.Size(779, 239);
            this.OperationDetailsGroupBox.TabIndex = 2;
            this.OperationDetailsGroupBox.TabStop = false;
            this.OperationDetailsGroupBox.Text = "Доп. инф-ция по операции.";
            // 
            // OperationDetailsDGV
            // 
            this.OperationDetailsDGV.AllowUserToAddRows = false;
            this.OperationDetailsDGV.AllowUserToDeleteRows = false;
            this.OperationDetailsDGV.AllowUserToResizeRows = false;
            this.OperationDetailsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OperationDetailsDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ManufacturerCol,
            this.ArticulCol,
            this.TitleCol,
            this.MeasureUnitCol,
            this.CountCol,
            this.PriceCol,
            this.SumCol});
            this.OperationDetailsDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OperationDetailsDGV.Location = new System.Drawing.Point(3, 16);
            this.OperationDetailsDGV.Name = "OperationDetailsDGV";
            this.OperationDetailsDGV.Size = new System.Drawing.Size(773, 220);
            this.OperationDetailsDGV.TabIndex = 0;
            // 
            // ManufacturerCol
            // 
            this.ManufacturerCol.HeaderText = "Производитель";
            this.ManufacturerCol.Name = "ManufacturerCol";
            this.ManufacturerCol.ReadOnly = true;
            // 
            // ArticulCol
            // 
            this.ArticulCol.HeaderText = "Артикул";
            this.ArticulCol.Name = "ArticulCol";
            this.ArticulCol.ReadOnly = true;
            // 
            // TitleCol
            // 
            this.TitleCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TitleCol.HeaderText = "Название";
            this.TitleCol.Name = "TitleCol";
            this.TitleCol.ReadOnly = true;
            // 
            // MeasureUnitCol
            // 
            this.MeasureUnitCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.MeasureUnitCol.DefaultCellStyle = dataGridViewCellStyle17;
            this.MeasureUnitCol.HeaderText = "Ед. изм.";
            this.MeasureUnitCol.MinimumWidth = 35;
            this.MeasureUnitCol.Name = "MeasureUnitCol";
            this.MeasureUnitCol.ReadOnly = true;
            this.MeasureUnitCol.Width = 35;
            // 
            // CountCol
            // 
            this.CountCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.CountCol.DefaultCellStyle = dataGridViewCellStyle18;
            this.CountCol.HeaderText = "Кол-во";
            this.CountCol.Name = "CountCol";
            this.CountCol.ReadOnly = true;
            this.CountCol.Width = 50;
            // 
            // PriceCol
            // 
            this.PriceCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle19.Format = "N2";
            dataGridViewCellStyle19.NullValue = null;
            this.PriceCol.DefaultCellStyle = dataGridViewCellStyle19;
            this.PriceCol.HeaderText = "Цена (руб.)";
            this.PriceCol.MinimumWidth = 50;
            this.PriceCol.Name = "PriceCol";
            this.PriceCol.ReadOnly = true;
            this.PriceCol.Width = 75;
            // 
            // SumCol
            // 
            this.SumCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle20.Format = "C2";
            dataGridViewCellStyle20.NullValue = null;
            this.SumCol.DefaultCellStyle = dataGridViewCellStyle20;
            this.SumCol.HeaderText = "Сумма (руб.)";
            this.SumCol.Name = "SumCol";
            this.SumCol.ReadOnly = true;
            // 
            // EmployeeGroupBox
            // 
            this.EmployeeGroupBox.Controls.Add(this.EmployeeListBox);
            this.EmployeeGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EmployeeGroupBox.Location = new System.Drawing.Point(0, 0);
            this.EmployeeGroupBox.Name = "EmployeeGroupBox";
            this.EmployeeGroupBox.Size = new System.Drawing.Size(779, 191);
            this.EmployeeGroupBox.TabIndex = 1;
            this.EmployeeGroupBox.TabStop = false;
            this.EmployeeGroupBox.Text = "Сотрудники";
            // 
            // EmployeeListBox
            // 
            this.EmployeeListBox.DisplayMember = "LastName";
            this.EmployeeListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EmployeeListBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.EmployeeListBox.Location = new System.Drawing.Point(3, 16);
            this.EmployeeListBox.Name = "EmployeeListBox";
            this.EmployeeListBox.Size = new System.Drawing.Size(773, 172);
            this.EmployeeListBox.TabIndex = 0;
            this.EmployeeListBox.ValueMember = "EmployeeId";
            // 
            // EmployeeOperationsInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 685);
            this.Controls.Add(this.splitContainer1);
            this.Name = "EmployeeOperationsInfoForm";
            this.Text = "Операции сотрудников";
            this.Load += new System.EventHandler(this.EmployeeOperationsInfoForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.BottomSplitContainer.Panel1.ResumeLayout(false);
            this.BottomSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BottomSplitContainer)).EndInit();
            this.BottomSplitContainer.ResumeLayout(false);
            this.OperationsGroupBox.ResumeLayout(false);
            this.OperationsGroupBox.PerformLayout();
            this.OperationsStatusStrip.ResumeLayout(false);
            this.OperationsStatusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OperationsDGV)).EndInit();
            this.BeginDatePanel.ResumeLayout(false);
            this.BeginDatePanel.PerformLayout();
            this.EndDatePanel.ResumeLayout(false);
            this.EndDatePanel.PerformLayout();
            this.OperationDetailsGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.OperationDetailsDGV)).EndInit();
            this.EmployeeGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer BottomSplitContainer;
        private System.Windows.Forms.GroupBox OperationsGroupBox;
        private System.Windows.Forms.DataGridView OperationsDGV;
        private System.Windows.Forms.StatusStrip OperationsStatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel OperationsCountStatusLabel;
        private System.Windows.Forms.CheckBox SaleCheckBox;
        private System.Windows.Forms.CheckBox PurchaseCheckBox;
        private System.Windows.Forms.DateTimePicker BeginDateDTP;
        private System.Windows.Forms.CheckBox BeginDateCheckBox;
        private System.Windows.Forms.Panel BeginDatePanel;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel EndDatePanel;
        private System.Windows.Forms.CheckBox EndDateCheckBox;
        private System.Windows.Forms.DateTimePicker EndDateDTP;
        private System.Windows.Forms.GroupBox OperationDetailsGroupBox;
        private System.Windows.Forms.DataGridView OperationDetailsDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ManufacturerCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArticulCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn TitleCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn MeasureUnitCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn CountCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn SumCol;
        private System.Windows.Forms.GroupBox EmployeeGroupBox;
        private System.Windows.Forms.ListBox EmployeeListBox;
    }
}