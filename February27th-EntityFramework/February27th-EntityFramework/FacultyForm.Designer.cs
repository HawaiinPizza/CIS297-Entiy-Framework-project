namespace February27th_EntityFramework
{
    partial class FacultyForm
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
            this.facultyListBox = new System.Windows.Forms.ListBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.officeTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // facultyListBox
            // 
            this.facultyListBox.FormattingEnabled = true;
            this.facultyListBox.ItemHeight = 25;
            this.facultyListBox.Location = new System.Drawing.Point(346, 191);
            this.facultyListBox.Name = "facultyListBox";
            this.facultyListBox.Size = new System.Drawing.Size(386, 254);
            this.facultyListBox.TabIndex = 0;
            this.facultyListBox.SelectedIndexChanged += new System.EventHandler(this.facultyListBox_SelectedIndexChanged);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(962, 177);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 31);
            this.nameTextBox.TabIndex = 1;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Location = new System.Drawing.Point(962, 241);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(100, 31);
            this.phoneTextBox.TabIndex = 2;
            // 
            // officeTextBox
            // 
            this.officeTextBox.Location = new System.Drawing.Point(962, 305);
            this.officeTextBox.Name = "officeTextBox";
            this.officeTextBox.Size = new System.Drawing.Size(100, 31);
            this.officeTextBox.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(962, 394);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 51);
            this.button1.TabIndex = 4;
            this.button1.Text = "Update Faculty";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FacultyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1549, 806);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.officeTextBox);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.facultyListBox);
            this.Name = "FacultyForm";
            this.Text = "FacultyForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox facultyListBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.TextBox officeTextBox;
        private System.Windows.Forms.Button button1;
    }
}