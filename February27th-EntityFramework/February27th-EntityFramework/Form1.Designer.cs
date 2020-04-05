﻿namespace February27th_EntityFramework
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
            this.selectedFacultyLabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.officeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.instructorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.collegeDataSetInstructor = new February27th_EntityFramework.CollegeDataSetInstructor();
            this.instructorTableAdapter = new February27th_EntityFramework.CollegeDataSetInstructorTableAdapters.InstructorTableAdapter();
            this.NameLabel = new System.Windows.Forms.TextBox();
            this.PhoneLabel = new System.Windows.Forms.TextBox();
            this.OfficeLabel = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.instructorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.collegeDataSetInstructor)).BeginInit();
            this.SuspendLayout();
            // 
            // selectedFacultyLabel
            // 
            this.selectedFacultyLabel.AutoSize = true;
            this.selectedFacultyLabel.Location = new System.Drawing.Point(58, 165);
            this.selectedFacultyLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.selectedFacultyLabel.Name = "selectedFacultyLabel";
            this.selectedFacultyLabel.Size = new System.Drawing.Size(51, 13);
            this.selectedFacultyLabel.TabIndex = 15;
            this.selectedFacultyLabel.Text = "Instructor";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.officeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.instructorBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 223);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(503, 150);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            this.dataGridView1.CellValueNeeded += new System.Windows.Forms.DataGridViewCellValueEventHandler(this.dataGridView1_CellValueNeeded);
            this.dataGridView1.CellValuePushed += new System.Windows.Forms.DataGridViewCellValueEventHandler(this.dataGridView1_CellValuePushed);
            this.dataGridView1.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView1_DataBindingComplete);
            this.dataGridView1.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridView1_DefaultValuesNeeded);
            this.dataGridView1.NewRowNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridView1_NewRowNeeded);
            this.dataGridView1.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridView1_UserAddedRow);
            this.dataGridView1.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridView1_UserDeletingRow);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            // 
            // officeDataGridViewTextBoxColumn
            // 
            this.officeDataGridViewTextBoxColumn.DataPropertyName = "Office";
            this.officeDataGridViewTextBoxColumn.HeaderText = "Office";
            this.officeDataGridViewTextBoxColumn.Name = "officeDataGridViewTextBoxColumn";
            // 
            // instructorBindingSource
            // 
            this.instructorBindingSource.DataMember = "Instructor";
            this.instructorBindingSource.DataSource = this.collegeDataSetInstructor;
            // 
            // collegeDataSetInstructor
            // 
            this.collegeDataSetInstructor.DataSetName = "CollegeDataSetInstructor";
            this.collegeDataSetInstructor.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // instructorTableAdapter
            // 
            this.instructorTableAdapter.ClearBeforeFill = true;
            // 
            // NameLabel
            // 
            this.NameLabel.Location = new System.Drawing.Point(617, 223);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(100, 20);
            this.NameLabel.TabIndex = 18;
            // 
            // PhoneLabel
            // 
            this.PhoneLabel.Location = new System.Drawing.Point(617, 285);
            this.PhoneLabel.Name = "PhoneLabel";
            this.PhoneLabel.Size = new System.Drawing.Size(100, 20);
            this.PhoneLabel.TabIndex = 19;
            // 
            // OfficeLabel
            // 
            this.OfficeLabel.Location = new System.Drawing.Point(617, 353);
            this.OfficeLabel.Name = "OfficeLabel";
            this.OfficeLabel.Size = new System.Drawing.Size(100, 20);
            this.OfficeLabel.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(532, 223);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(532, 285);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Phone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(532, 356);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Office";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 536);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OfficeLabel);
            this.Controls.Add(this.PhoneLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.selectedFacultyLabel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.Form1_Enter);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.instructorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.collegeDataSetInstructor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label selectedFacultyLabel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private CollegeDataSetInstructor collegeDataSetInstructor;
        private System.Windows.Forms.BindingSource instructorBindingSource;
        private CollegeDataSetInstructorTableAdapters.InstructorTableAdapter instructorTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn officeDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox NameLabel;
        private System.Windows.Forms.TextBox PhoneLabel;
        private System.Windows.Forms.TextBox OfficeLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

