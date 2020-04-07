namespace February27th_EntityFramework
{
    partial class Form5
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
            this.MajorLabel = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.addSectionButton = new System.Windows.Forms.Button();
            this.fillByToolStrip = new System.Windows.Forms.ToolStrip();
            this.fillByToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.collegeDataSetSection = new February27th_EntityFramework.CollegeDataSetSection();
            this.sectionTableAdapter = new February27th_EntityFramework.CollegeDataSetSectionTableAdapters.SectionTableAdapter();
            this.tableAdapterManager = new February27th_EntityFramework.CollegeDataSetSectionTableAdapters.TableAdapterManager();
            this.sectionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.collegeSet = new February27th_EntityFramework.CollegeSet();
            this.sectionBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.sectionBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.instructorBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.instructorTableAdapter1 = new February27th_EntityFramework.CollegeDataSetSectionTableAdapters.InstructorTableAdapter();
            this.instructorBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.instructorTableAdapter2 = new February27th_EntityFramework.CollegeSetTableAdapters.InstructorTableAdapter();
            this.sectionTableAdapter1 = new February27th_EntityFramework.CollegeSetTableAdapters.SectionTableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.majorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.courseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.courseTableAdapter = new February27th_EntityFramework.CollegeSetTableAdapters.CourseTableAdapter();
            this.studentTableAdapter = new February27th_EntityFramework.CollegeSetTableAdapters.StudentTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Wow = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.majorTableAdapter = new February27th_EntityFramework.CollegeSetTableAdapters.MajorTableAdapter();
            this.filterTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.filterButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.instructorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.collegeDataSetInstructor)).BeginInit();
            this.fillByToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.collegeDataSetSection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.collegeSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectionBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectionBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.instructorBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.instructorBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.majorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // selectedFacultyLabel
            // 
            this.selectedFacultyLabel.AutoSize = true;
            this.selectedFacultyLabel.Location = new System.Drawing.Point(12, 239);
            this.selectedFacultyLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.selectedFacultyLabel.Name = "selectedFacultyLabel";
            this.selectedFacultyLabel.Size = new System.Drawing.Size(44, 13);
            this.selectedFacultyLabel.TabIndex = 15;
            this.selectedFacultyLabel.Text = "Student";
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
            // MajorLabel
            // 
            this.MajorLabel.Location = new System.Drawing.Point(799, 190);
            this.MajorLabel.Name = "MajorLabel";
            this.MajorLabel.Size = new System.Drawing.Size(100, 20);
            this.MajorLabel.TabIndex = 18;
            this.MajorLabel.TextChanged += new System.EventHandler(this.MajorLabel_TextChanged);
            // 
            // NameLabel
            // 
            this.NameLabel.Location = new System.Drawing.Point(799, 242);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(100, 20);
            this.NameLabel.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(726, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Major";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(723, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Name";
            // 
            // addSectionButton
            // 
            this.addSectionButton.Location = new System.Drawing.Point(729, 121);
            this.addSectionButton.Name = "addSectionButton";
            this.addSectionButton.Size = new System.Drawing.Size(182, 23);
            this.addSectionButton.TabIndex = 24;
            this.addSectionButton.Text = "Add Student";
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
            // studentBindingSource
            // 
            this.studentBindingSource.DataMember = "Student";
            this.studentBindingSource.DataSource = this.collegeSet;
            // 
            // collegeSet
            // 
            this.collegeSet.DataSetName = "CollegeSet";
            this.collegeSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sectionBindingSource2
            // 
            this.sectionBindingSource2.DataMember = "Section";
            this.sectionBindingSource2.DataSource = this.collegeSet;
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
            this.nameDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.majorBindingSource;
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
            // majorBindingSource
            // 
            this.majorBindingSource.DataMember = "Major";
            this.majorBindingSource.DataSource = this.collegeSet;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 87);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Major";
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
            // studentTableAdapter
            // 
            this.studentTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.Wow,
            this.NameA});
            this.dataGridView1.DataSource = this.studentBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 289);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(503, 82);
            this.dataGridView1.TabIndex = 35;
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            this.dataGridView1.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridView1_UserDeletedRow);
            this.dataGridView1.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridView1_UserDeletingRow_1);
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "UniqueID";
            this.dataGridViewTextBoxColumn3.HeaderText = "ID";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // Wow
            // 
            this.Wow.DataPropertyName = "Major";
            this.Wow.HeaderText = "Major";
            this.Wow.Name = "Wow";
            // 
            // NameA
            // 
            this.NameA.DataPropertyName = "Name";
            this.NameA.HeaderText = "Name";
            this.NameA.Name = "NameA";
            // 
            // majorTableAdapter
            // 
            this.majorTableAdapter.ClearBeforeFill = true;
            // 
            // filterTextBox
            // 
            this.filterTextBox.AccessibleName = "";
            this.filterTextBox.Location = new System.Drawing.Point(799, 388);
            this.filterTextBox.Name = "filterTextBox";
            this.filterTextBox.Size = new System.Drawing.Size(100, 20);
            this.filterTextBox.TabIndex = 36;
            this.filterTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(726, 391);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 37;
            this.label3.Text = "Major";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // filterButton
            // 
            this.filterButton.AccessibleName = "filterButton";
            this.filterButton.Location = new System.Drawing.Point(729, 438);
            this.filterButton.Name = "filterButton";
            this.filterButton.Size = new System.Drawing.Size(182, 23);
            this.filterButton.TabIndex = 38;
            this.filterButton.Text = "Filter by Major";
            this.filterButton.UseVisualStyleBackColor = true;
            this.filterButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 536);
            this.Controls.Add(this.filterButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.filterTextBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.fillByToolStrip);
            this.Controls.Add(this.addSectionButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.MajorLabel);
            this.Controls.Add(this.selectedFacultyLabel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.Click += new System.EventHandler(this.Form5_Enter);
            ((System.ComponentModel.ISupportInitialize)(this.instructorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.collegeDataSetInstructor)).EndInit();
            this.fillByToolStrip.ResumeLayout(false);
            this.fillByToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.collegeDataSetSection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.collegeSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectionBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectionBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.instructorBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.instructorBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.majorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label selectedFacultyLabel;
        private CollegeDataSetInstructor collegeDataSetInstructor;
        private System.Windows.Forms.BindingSource instructorBindingSource;
        private CollegeDataSetInstructorTableAdapters.InstructorTableAdapter instructorTableAdapter;
        private System.Windows.Forms.TextBox MajorLabel;
        private System.Windows.Forms.TextBox NameLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addSectionButton;
        private CollegeDataSetSection collegeDataSetSection;
        private CollegeDataSetSectionTableAdapters.SectionTableAdapter sectionTableAdapter;
        private CollegeDataSetSectionTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ToolStrip fillByToolStrip;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton;
        private System.Windows.Forms.BindingSource sectionBindingSource;
        private System.Windows.Forms.BindingSource sectionBindingSource1;
        private System.Windows.Forms.BindingSource instructorBindingSource1;
        private CollegeDataSetSectionTableAdapters.InstructorTableAdapter instructorTableAdapter1;
        private CollegeSet collegeSet;
        private System.Windows.Forms.BindingSource instructorBindingSource2;
        private CollegeSetTableAdapters.InstructorTableAdapter instructorTableAdapter2;
        private System.Windows.Forms.BindingSource sectionBindingSource2;
        private CollegeSetTableAdapters.SectionTableAdapter sectionTableAdapter1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource courseBindingSource;
        private CollegeSetTableAdapters.CourseTableAdapter courseTableAdapter;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private CollegeSetTableAdapters.StudentTableAdapter studentTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Wow;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameA;
        private System.Windows.Forms.BindingSource majorBindingSource;
        private CollegeSetTableAdapters.MajorTableAdapter majorTableAdapter;
        private System.Windows.Forms.TextBox filterTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button filterButton;
    }
}

