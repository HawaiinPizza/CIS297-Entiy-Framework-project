using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace February27th_EntityFramework
{
    public partial class FacultyForm : Form
    {
        CollegeEntities collegeEntities;
        public FacultyForm()
        {
            InitializeComponent();
            collegeEntities = new CollegeEntities();
            facultyListBox.DataSource = collegeEntities.Instructors.ToList();
            facultyListBox.DisplayMember = "Name";
            facultyListBox.ValueMember = "Id";
        }

        private void facultyListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Instructor selectedInstructor = facultyListBox.SelectedItem as Instructor;
            nameTextBox.Text = selectedInstructor.Name;
            phoneTextBox.Text = selectedInstructor.Phone;
            officeTextBox.Text = selectedInstructor.Office;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Instructor selectedInstructor = facultyListBox.SelectedItem as Instructor;
            selectedInstructor.Name = nameTextBox.Text;
            selectedInstructor.Phone = phoneTextBox.Text;
            selectedInstructor.Office = officeTextBox.Text;
            collegeEntities.SaveChanges();
        }
    }
}
