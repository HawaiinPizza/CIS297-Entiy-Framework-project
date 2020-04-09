namespace February27th_EntityFramework
{
    partial class Form2
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
            this.instructorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.collegeDataSetInstructor = new February27th_EntityFramework.CollegeDataSetInstructor();
            this.instructorTableAdapter = new February27th_EntityFramework.CollegeDataSetInstructorTableAdapters.InstructorTableAdapter();
            this.DaysLabel = new System.Windows.Forms.TextBox();
            this.TimeLabel = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.addSectionButton = new System.Windows.Forms.Button();
            this.fillByToolStrip = new System.Windows.Forms.ToolStrip();
            this.fillByToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.collegeDataSetSection = new February27th_EntityFramework.CollegeDataSetSection();
            this.sectionTableAdapter = new February27th_EntityFramework.CollegeDataSetSectionTableAdapters.SectionTableAdapter();
            this.tableAdapterManager = new February27th_EntityFramework.CollegeDataSetSectionTableAdapters.TableAdapterManager();
            this.sectionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Course_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Days = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Instructor_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sectionBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.collegeSet = new February27th_EntityFramework.CollegeSet();
            this.sectionBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.instructorBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.instructorTableAdapter1 = new February27th_EntityFramework.CollegeDataSetSectionTableAdapters.InstructorTableAdapter();
            this.instructorBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.instructorTableAdapter2 = new February27th_EntityFramework.CollegeSetTableAdapters.InstructorTableAdapter();
            this.sectionTableAdapter1 = new February27th_EntityFramework.CollegeSetTableAdapters.SectionTableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.officeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.courseTableAdapter = new February27th_EntityFramework.CollegeSetTableAdapters.CourseTableAdapter();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.InstructorLabel = new System.Windows.Forms.TextBox();
            this.CourseLabel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.filterTextBox = new System.Windows.Forms.TextBox();
            this.filterButton = new System.Windows.Forms.Button();
            this.filterByName = new System.Windows.Forms.Button();
            this.instructorFilterTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.instructorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.collegeDataSetInstructor)).BeginInit();
            this.fillByToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.collegeDataSetSection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectionBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.collegeSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectionBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.instructorBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.instructorBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // selectedFacultyLabel
            // 
            this.selectedFacultyLabel.AutoSize = true;
            this.selectedFacultyLabel.Location = new System.Drawing.Point(11, 358);
            this.selectedFacultyLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.selectedFacultyLabel.Name = "selectedFacultyLabel";
            this.selectedFacultyLabel.Size = new System.Drawing.Size(43, 13);
            this.selectedFacultyLabel.TabIndex = 15;
            this.selectedFacultyLabel.Text = "Section";
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
            // DaysLabel
            // 
            this.DaysLabel.Location = new System.Drawing.Point(799, 190);
            this.DaysLabel.Name = "DaysLabel";
            this.DaysLabel.Size = new System.Drawing.Size(100, 20);
            this.DaysLabel.TabIndex = 18;
            // 
            // TimeLabel
            // 
            this.TimeLabel.Location = new System.Drawing.Point(799, 242);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(100, 20);
            this.TimeLabel.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(726, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Days";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(723, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Time";
            // 
            // addSectionButton
            // 
            this.addSectionButton.Location = new System.Drawing.Point(729, 121);
            this.addSectionButton.Name = "addSectionButton";
            this.addSectionButton.Size = new System.Drawing.Size(182, 23);
            this.addSectionButton.TabIndex = 24;
            this.addSectionButton.Text = "Add Section";
            this.addSectionButton.UseVisualStyleBackColor = true;
            this.addSectionButton.Click += new System.EventHandler(this.addInstructorButton_Click);
            // 
            // fillByToolStrip
            // 
            this.fillByToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillByToolStripButton});
            this.fillByToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillByToolStrip.Name = "fillByToolStrip";
            this.fillByToolStrip.Size = new System.Drawing.Size(911, 25);
            this.fillByToolStrip.TabIndex = 25;
            this.fillByToolStrip.Text = "fillByToolStrip";
            // 
            // fillByToolStripButton
            // 
            this.fillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByToolStripButton.Name = "fillByToolStripButton";
            this.fillByToolStripButton.Size = new System.Drawing.Size(39, 22);
            this.fillByToolStripButton.Text = "FillBy";
            this.fillByToolStripButton.Click += new System.EventHandler(this.fillByToolStripButton_Click_1);
            // 
            // collegeDataSetSection
            // 
            this.collegeDataSetSection.DataSetName = "CollegeDataSetSection";
            this.collegeDataSetSection.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sectionTableAdapter
            // 
            this.sectionTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CourseTableAdapter = null;
            this.tableAdapterManager.EnrollmentTableAdapter = null;
            this.tableAdapterManager.InstructorTableAdapter = null;
            this.tableAdapterManager.MajorTableAdapter = null;
            this.tableAdapterManager.SectionTableAdapter = this.sectionTableAdapter;
            this.tableAdapterManager.StudentTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = February27th_EntityFramework.CollegeDataSetSectionTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // sectionBindingSource
            // 
            this.sectionBindingSource.DataMember = "Section";
            this.sectionBindingSource.DataSource = this.collegeDataSetSection;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.Course_Id,
            this.Days,
            this.Time,
            this.Instructor_ID});
            this.dataGridView1.DataSource = this.sectionBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(11, 374);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(581, 150);
            this.dataGridView1.TabIndex = 26;
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit_1);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Course_Id
            // 
            this.Course_Id.DataPropertyName = "Course_Id";
            this.Course_Id.HeaderText = "Course_Id";
            this.Course_Id.Name = "Course_Id";
            // 
            // Days
            // 
            this.Days.DataPropertyName = "Days";
            this.Days.HeaderText = "Days";
            this.Days.Name = "Days";
            // 
            // Time
            // 
            this.Time.DataPropertyName = "Time";
            this.Time.HeaderText = "Time";
            this.Time.Name = "Time";
            // 
            // Instructor_ID
            // 
            this.Instructor_ID.DataPropertyName = "Instructor_ID";
            this.Instructor_ID.HeaderText = "Instructor_ID";
            this.Instructor_ID.Name = "Instructor_ID";
            // 
            // sectionBindingSource2
            // 
            this.sectionBindingSource2.DataMember = "Section";
            this.sectionBindingSource2.DataSource = this.collegeSet;
            // 
            // collegeSet
            // 
            this.collegeSet.DataSetName = "CollegeSet";
            this.collegeSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sectionBindingSource1
            // 
            this.sectionBindingSource1.DataMember = "Section";
            this.sectionBindingSource1.DataSource = this.collegeDataSetSection;
            // 
            // instructorBindingSource1
            // 
            this.instructorBindingSource1.DataMember = "Instructor";
            this.instructorBindingSource1.DataSource = this.collegeDataSetSection;
            // 
            // instructorTableAdapter1
            // 
            this.instructorTableAdapter1.ClearBeforeFill = true;
            // 
            // instructorBindingSource2
            // 
            this.instructorBindingSource2.DataMember = "Instructor";
            this.instructorBindingSource2.DataSource = this.collegeSet;
            // 
            // instructorTableAdapter2
            // 
            this.instructorTableAdapter2.ClearBeforeFill = true;
            // 
            // sectionTableAdapter1
            // 
            this.sectionTableAdapter1.ClearBeforeFill = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.nameDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.officeDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.instructorBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(12, 121);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(503, 82);
            this.dataGridView2.TabIndex = 27;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            this.phoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // officeDataGridViewTextBoxColumn
            // 
            this.officeDataGridViewTextBoxColumn.DataPropertyName = "Office";
            this.officeDataGridViewTextBoxColumn.HeaderText = "Office";
            this.officeDataGridViewTextBoxColumn.Name = "officeDataGridViewTextBoxColumn";
            this.officeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 87);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Instructor";
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dataGridView3.DataSource = this.courseBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(14, 251);
            this.dataGridView3.MultiSelect = false;
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView3.Size = new System.Drawing.Size(503, 82);
            this.dataGridView3.TabIndex = 29;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn2.HeaderText = "Id";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn3.HeaderText = "Name";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // courseBindingSource
            // 
            this.courseBindingSource.DataMember = "Course";
            this.courseBindingSource.DataSource = this.collegeSet;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 221);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "Course";
            // 
            // courseTableAdapter
            // 
            this.courseTableAdapter.ClearBeforeFill = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(723, 341);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "Course";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(723, 289);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 32;
            this.label7.Text = "Instructor";
            // 
            // InstructorLabel
            // 
            this.InstructorLabel.Location = new System.Drawing.Point(799, 289);
            this.InstructorLabel.Name = "InstructorLabel";
            this.InstructorLabel.Size = new System.Drawing.Size(100, 20);
            this.InstructorLabel.TabIndex = 33;
            // 
            // CourseLabel
            // 
            this.CourseLabel.Location = new System.Drawing.Point(799, 341);
            this.CourseLabel.Name = "CourseLabel";
            this.CourseLabel.Size = new System.Drawing.Size(100, 20);
            this.CourseLabel.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(726, 456);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 35;
            this.label3.Text = "Semester";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // filterTextBox
            // 
            this.filterTextBox.Location = new System.Drawing.Point(799, 453);
            this.filterTextBox.Name = "filterTextBox";
            this.filterTextBox.Size = new System.Drawing.Size(100, 20);
            this.filterTextBox.TabIndex = 36;
            // 
            // filterButton
            // 
            this.filterButton.Location = new System.Drawing.Point(729, 479);
            this.filterButton.Name = "filterButton";
            this.filterButton.Size = new System.Drawing.Size(182, 23);
            this.filterButton.TabIndex = 37;
            this.filterButton.Text = "Filter by Semester";
            this.filterButton.UseVisualStyleBackColor = true;
            this.filterButton.Click += new System.EventHandler(this.filterButton_Click);
            // 
            // filterByName
            // 
            this.filterByName.Location = new System.Drawing.Point(729, 508);
            this.filterByName.Name = "filterByName";
            this.filterByName.Size = new System.Drawing.Size(182, 23);
            this.filterByName.TabIndex = 38;
            this.filterByName.Text = "Filter by Name and Semester";
            this.filterByName.UseVisualStyleBackColor = true;
            this.filterByName.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // instructorFilterTextBox
            // 
            this.instructorFilterTextBox.Location = new System.Drawing.Point(799, 427);
            this.instructorFilterTextBox.Name = "instructorFilterTextBox";
            this.instructorFilterTextBox.Size = new System.Drawing.Size(100, 20);
            this.instructorFilterTextBox.TabIndex = 39;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(728, 430);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 40;
            this.label8.Text = "Instructor";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 536);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.instructorFilterTextBox);
            this.Controls.Add(this.filterByName);
            this.Controls.Add(this.filterButton);
            this.Controls.Add(this.filterTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CourseLabel);
            this.Controls.Add(this.InstructorLabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.fillByToolStrip);
            this.Controls.Add(this.addSectionButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TimeLabel);
            this.Controls.Add(this.DaysLabel);
            this.Controls.Add(this.selectedFacultyLabel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.Click += new System.EventHandler(this.Form2_Enter);
            ((System.ComponentModel.ISupportInitialize)(this.instructorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.collegeDataSetInstructor)).EndInit();
            this.fillByToolStrip.ResumeLayout(false);
            this.fillByToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.collegeDataSetSection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectionBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.collegeSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectionBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.instructorBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.instructorBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label selectedFacultyLabel;
        private CollegeDataSetInstructor collegeDataSetInstructor;
        private System.Windows.Forms.BindingSource instructorBindingSource;
        private CollegeDataSetInstructorTableAdapters.InstructorTableAdapter instructorTableAdapter;
        private System.Windows.Forms.TextBox DaysLabel;
        private System.Windows.Forms.TextBox TimeLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addSectionButton;
        private CollegeDataSetSection collegeDataSetSection;
        private CollegeDataSetSectionTableAdapters.SectionTableAdapter sectionTableAdapter;
        private CollegeDataSetSectionTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ToolStrip fillByToolStrip;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton;
        private System.Windows.Forms.BindingSource sectionBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource sectionBindingSource1;
        private System.Windows.Forms.BindingSource instructorBindingSource1;
        private CollegeDataSetSectionTableAdapters.InstructorTableAdapter instructorTableAdapter1;
        private CollegeSet collegeSet;
        private System.Windows.Forms.BindingSource instructorBindingSource2;
        private CollegeSetTableAdapters.InstructorTableAdapter instructorTableAdapter2;
        private System.Windows.Forms.BindingSource sectionBindingSource2;
        private CollegeSetTableAdapters.SectionTableAdapter sectionTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Course_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Days;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn Instructor_ID;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn officeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.BindingSource courseBindingSource;
        private CollegeSetTableAdapters.CourseTableAdapter courseTableAdapter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox InstructorLabel;
        private System.Windows.Forms.TextBox CourseLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox filterTextBox;
        private System.Windows.Forms.Button filterButton;
        private System.Windows.Forms.Button filterByName;
        private System.Windows.Forms.TextBox instructorFilterTextBox;
        private System.Windows.Forms.Label label8;
    }
}

