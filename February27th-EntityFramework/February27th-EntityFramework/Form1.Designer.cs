namespace February27th_EntityFramework
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.departmentTextBox = new System.Windows.Forms.TextBox();
            this.numberTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.creditsTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.courseNumberFilterTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.facultyListBox = new System.Windows.Forms.ListBox();
            this.selectedFacultyLabel = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(715, 233);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1032, 235);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(208, 51);
            this.button1.TabIndex = 1;
            this.button1.Text = "Add Course";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // departmentTextBox
            // 
            this.departmentTextBox.Location = new System.Drawing.Point(1032, 429);
            this.departmentTextBox.Name = "departmentTextBox";
            this.departmentTextBox.Size = new System.Drawing.Size(100, 31);
            this.departmentTextBox.TabIndex = 2;
            // 
            // numberTextBox
            // 
            this.numberTextBox.Location = new System.Drawing.Point(1032, 486);
            this.numberTextBox.Name = "numberTextBox";
            this.numberTextBox.Size = new System.Drawing.Size(100, 31);
            this.numberTextBox.TabIndex = 3;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(1032, 556);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 31);
            this.nameTextBox.TabIndex = 4;
            // 
            // creditsTextBox
            // 
            this.creditsTextBox.Location = new System.Drawing.Point(1032, 605);
            this.creditsTextBox.Name = "creditsTextBox";
            this.creditsTextBox.Size = new System.Drawing.Size(100, 31);
            this.creditsTextBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(890, 429);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Department";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(890, 489);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(890, 556);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(890, 594);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "Credits";
            // 
            // courseNumberFilterTextBox
            // 
            this.courseNumberFilterTextBox.Location = new System.Drawing.Point(703, 95);
            this.courseNumberFilterTextBox.Name = "courseNumberFilterTextBox";
            this.courseNumberFilterTextBox.Size = new System.Drawing.Size(100, 31);
            this.courseNumberFilterTextBox.TabIndex = 12;
            this.courseNumberFilterTextBox.TextChanged += new System.EventHandler(this.courseNumberFilterTextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(409, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(238, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "Find course by number:";
            // 
            // facultyListBox
            // 
            this.facultyListBox.FormattingEnabled = true;
            this.facultyListBox.ItemHeight = 25;
            this.facultyListBox.Location = new System.Drawing.Point(290, 331);
            this.facultyListBox.Name = "facultyListBox";
            this.facultyListBox.Size = new System.Drawing.Size(288, 304);
            this.facultyListBox.TabIndex = 14;
            this.facultyListBox.SelectedIndexChanged += new System.EventHandler(this.facultyListBox_SelectedIndexChanged);
            // 
            // selectedFacultyLabel
            // 
            this.selectedFacultyLabel.AutoSize = true;
            this.selectedFacultyLabel.Location = new System.Drawing.Point(374, 762);
            this.selectedFacultyLabel.Name = "selectedFacultyLabel";
            this.selectedFacultyLabel.Size = new System.Drawing.Size(70, 25);
            this.selectedFacultyLabel.TabIndex = 15;
            this.selectedFacultyLabel.Text = "label7";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1466, 64);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(254, 62);
            this.button2.TabIndex = 16;
            this.button2.Text = "Faculty";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1822, 1031);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.selectedFacultyLabel);
            this.Controls.Add(this.facultyListBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.courseNumberFilterTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.creditsTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.numberTextBox);
            this.Controls.Add(this.departmentTextBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Click += new System.EventHandler(this.Form1_Enter);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox departmentTextBox;
        private System.Windows.Forms.TextBox numberTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox creditsTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox courseNumberFilterTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox facultyListBox;
        private System.Windows.Forms.Label selectedFacultyLabel;
        private System.Windows.Forms.Button button2;
    }
}

