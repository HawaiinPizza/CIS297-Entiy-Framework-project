namespace February27th_EntityFramework
{
    partial class Form3
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
            this.courseBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.collegeSet = new February27th_EntityFramework.CollegeSet();
            this.instructorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.collegeDataSetInstructor = new February27th_EntityFramework.CollegeDataSetInstructor();
            this.instructorTableAdapter = new February27th_EntityFramework.CollegeDataSetInstructorTableAdapters.InstructorTableAdapter();
            this.NameLabel = new System.Windows.Forms.TextBox();
            this.DepartmentLabel = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.addCourseButton = new System.Windows.Forms.Button();
            this.goSection = new System.Windows.Forms.Button();
            this.courseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.courseTableAdapter = new February27th_EntityFramework.CollegeSetTableAdapters.CourseTableAdapter();
            this.sectionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sectionTableAdapter = new February27th_EntityFramework.CollegeSetTableAdapters.SectionTableAdapter();
            this.Department = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Credits = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.collegeSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.instructorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.collegeDataSetInstructor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // selectedFacultyLabel
            // 
            this.selectedFacultyLabel.AutoSize = true;
            this.selectedFacultyLabel.Location = new System.Drawing.Point(58, 165);
            this.selectedFacultyLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.selectedFacultyLabel.Name = "selectedFacultyLabel";
            this.selectedFacultyLabel.Size = new System.Drawing.Size(40, 13);
            this.selectedFacultyLabel.TabIndex = 15;
            this.selectedFacultyLabel.Text = "Course";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.Department,
            this.Credits,
            this.Number});
            this.dataGridView1.DataSource = this.courseBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 223);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(595, 150);
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
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // courseBindingSource1
            // 
            this.courseBindingSource1.DataMember = "Course";
            this.courseBindingSource1.DataSource = this.collegeSet;
            // 
            // collegeSet
            // 
            this.collegeSet.DataSetName = "CollegeSet";
            this.collegeSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.NameLabel.Location = new System.Drawing.Point(785, 221);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(100, 20);
            this.NameLabel.TabIndex = 18;
            // 
            // DepartmentLabel
            // 
            this.DepartmentLabel.Location = new System.Drawing.Point(785, 283);
            this.DepartmentLabel.Name = "DepartmentLabel";
            this.DepartmentLabel.Size = new System.Drawing.Size(100, 20);
            this.DepartmentLabel.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(700, 221);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(700, 283);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Department";
            // 
            // addCourseButton
            // 
            this.addCourseButton.Location = new System.Drawing.Point(703, 176);
            this.addCourseButton.Name = "addCourseButton";
            this.addCourseButton.Size = new System.Drawing.Size(182, 23);
            this.addCourseButton.TabIndex = 24;
            this.addCourseButton.Text = "Add Course";
            this.addCourseButton.UseVisualStyleBackColor = true;
            this.addCourseButton.Click += new System.EventHandler(this.addInstructorButton_Click);
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
            // courseBindingSource
            // 
            this.courseBindingSource.DataMember = "Course";
            this.courseBindingSource.DataSource = this.collegeSet;
            // 
            // courseTableAdapter
            // 
            this.courseTableAdapter.ClearBeforeFill = true;
            // 
            // sectionBindingSource
            // 
            this.sectionBindingSource.DataMember = "Section";
            this.sectionBindingSource.DataSource = this.collegeSet;
            // 
            // sectionTableAdapter
            // 
            this.sectionTableAdapter.ClearBeforeFill = true;
            // 
            // Department
            // 
            this.Department.DataPropertyName = "Department";
            this.Department.HeaderText = "Department";
            this.Department.Name = "Department";
            // 
            // Credits
            // 
            this.Credits.DataPropertyName = "Credits";
            this.Credits.HeaderText = "Credits";
            this.Credits.Name = "Credits";
            // 
            // Number
            // 
            this.Number.DataPropertyName = "Number";
            this.Number.HeaderText = "Number";
            this.Number.Name = "Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(700, 376);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Number";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(785, 376);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(700, 332);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Credits";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(785, 332);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 28;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 536);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.goSection);
            this.Controls.Add(this.addCourseButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DepartmentLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.selectedFacultyLabel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.Click += new System.EventHandler(this.Form3_Enter);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.collegeSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.instructorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.collegeDataSetInstructor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectionBindingSource)).EndInit();
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
        private System.Windows.Forms.TextBox NameLabel;
        private System.Windows.Forms.TextBox DepartmentLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addCourseButton;
        private System.Windows.Forms.Button goSection;
        private CollegeSet collegeSet;
        private System.Windows.Forms.BindingSource courseBindingSource;
        private CollegeSetTableAdapters.CourseTableAdapter courseTableAdapter;
        private System.Windows.Forms.BindingSource courseBindingSource1;
        private System.Windows.Forms.BindingSource sectionBindingSource;
        private CollegeSetTableAdapters.SectionTableAdapter sectionTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Department;
        private System.Windows.Forms.DataGridViewTextBoxColumn Credits;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
    }
}

