namespace February27th_EntityFramework
{
    partial class Form10
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
            this.instructorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.collegeDataSetInstructor = new February27th_EntityFramework.CollegeDataSetInstructor();
            this.instructorTableAdapter = new February27th_EntityFramework.CollegeDataSetInstructorTableAdapters.InstructorTableAdapter();
            this.NameLabel = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addMajorButton = new System.Windows.Forms.Button();
            this.goSection = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.collegeSet = new February27th_EntityFramework.CollegeSet();
            this.majorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.majorTableAdapter = new February27th_EntityFramework.CollegeSetTableAdapters.MajorTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.TypeLabel = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.instructorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.collegeDataSetInstructor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.collegeSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.majorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // selectedFacultyLabel
            // 
            this.selectedFacultyLabel.AutoSize = true;
            this.selectedFacultyLabel.Location = new System.Drawing.Point(58, 165);
            this.selectedFacultyLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.selectedFacultyLabel.Name = "selectedFacultyLabel";
            this.selectedFacultyLabel.Size = new System.Drawing.Size(33, 13);
            this.selectedFacultyLabel.TabIndex = 15;
            this.selectedFacultyLabel.Text = "Major";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.majorBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 223);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(503, 150);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.AllowUserToDeleteRowsChanged += new System.EventHandler(this.dataGridView1_AllowUserToDeleteRowsChanged);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            this.dataGridView1.CellValueNeeded += new System.Windows.Forms.DataGridViewCellValueEventHandler(this.dataGridView1_CellValueNeeded);
            this.dataGridView1.CellValuePushed += new System.Windows.Forms.DataGridViewCellValueEventHandler(this.dataGridView1_CellValuePushed);
            this.dataGridView1.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView1_DataBindingComplete);
            this.dataGridView1.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridView1_DefaultValuesNeeded);
            this.dataGridView1.NewRowNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridView1_NewRowNeeded);
            this.dataGridView1.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridView1_UserAddedRow);
            this.dataGridView1.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridView1_UserDeletedRow);
            this.dataGridView1.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridView1_UserDeletingRow);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(532, 223);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Name";
            // 
            // addMajorButton
            // 
            this.addMajorButton.Location = new System.Drawing.Point(535, 178);
            this.addMajorButton.Name = "addMajorButton";
            this.addMajorButton.Size = new System.Drawing.Size(182, 23);
            this.addMajorButton.TabIndex = 24;
            this.addMajorButton.Text = "Add Instructor";
            this.addMajorButton.UseVisualStyleBackColor = true;
            this.addMajorButton.Click += new System.EventHandler(this.addInstructorButton_Click);
            // 
            // goSection
            // 
            this.goSection.Location = new System.Drawing.Point(296, 32);
            this.goSection.Name = "goSection";
            this.goSection.Size = new System.Drawing.Size(55, 23);
            this.goSection.TabIndex = 25;
            this.goSection.Text = "Section";
            this.goSection.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.goSection.UseVisualStyleBackColor = true;
            this.goSection.Click += new System.EventHandler(this.goSection_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(391, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(55, 23);
            this.button1.TabIndex = 26;
            this.button1.Text = "Course";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(189, 32);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(55, 23);
            this.button2.TabIndex = 27;
            this.button2.Text = "Student";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(92, 32);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(78, 23);
            this.button3.TabIndex = 28;
            this.button3.Text = "Enrollment";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // collegeSet
            // 
            this.collegeSet.DataSetName = "CollegeSet";
            this.collegeSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // majorBindingSource
            // 
            this.majorBindingSource.DataMember = "Major";
            this.majorBindingSource.DataSource = this.collegeSet;
            // 
            // majorTableAdapter
            // 
            this.majorTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(532, 249);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "Type";
            // 
            // TypeLabel
            // 
            this.TypeLabel.Location = new System.Drawing.Point(617, 249);
            this.TypeLabel.Name = "TypeLabel";
            this.TypeLabel.Size = new System.Drawing.Size(100, 20);
            this.TypeLabel.TabIndex = 29;
            // 
            // Form10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 536);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TypeLabel);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.goSection);
            this.Controls.Add(this.addMajorButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.selectedFacultyLabel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form10";
            this.Text = "Form10";
            this.Load += new System.EventHandler(this.Form10_Load);
            this.Click += new System.EventHandler(this.Form10_Enter);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.instructorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.collegeDataSetInstructor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.collegeSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.majorBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label selectedFacultyLabel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private CollegeDataSetInstructor collegeDataSetInstructor;
        private System.Windows.Forms.BindingSource instructorBindingSource;
        private CollegeDataSetInstructorTableAdapters.InstructorTableAdapter instructorTableAdapter;
        private System.Windows.Forms.TextBox NameLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addMajorButton;
        private System.Windows.Forms.Button goSection;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private CollegeSet collegeSet;
        private System.Windows.Forms.BindingSource majorBindingSource;
        private CollegeSetTableAdapters.MajorTableAdapter majorTableAdapter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TypeLabel;
    }
}

