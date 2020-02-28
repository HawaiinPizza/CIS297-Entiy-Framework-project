using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace February27th_EntityFramework
{
    public partial class Form1 : Form
    {
        CollegeEntities collegeEntities;
        public Form1()
        {
            InitializeComponent();
            collegeEntities = new CollegeEntities();
            UpdateCourseList();
            BindFacultyList();
        }

        private void BindFacultyList()
        {
            facultyListBox.DataSource = collegeEntities.Instructors.ToList();
            facultyListBox.DisplayMember = "Name";
            facultyListBox.ValueMember = "Id";
        }

        private void UpdateCourseList(string courseNumberFilter = "")
        {
            label1.Text = $"Courses:{Environment.NewLine}";

            foreach (var course in collegeEntities.Courses.Where( c => c.Sections.Count > 0 ))
            {
                if (courseNumberFilter != "" &&
                    !course.Number.StartsWith(courseNumberFilter))
                {
                    continue;
                }
                    
                
                label1.Text += $"{course} {Environment.NewLine}";
                foreach (var section in course.Sections)
                {
                    label1.Text += $"\t{section.Instructor.Name} {section.Days} {section.TIme}{Environment.NewLine}";
                }
               
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Course newCourse = new Course
            {
                Department = departmentTextBox.Text,
                Number = numberTextBox.Text,
                Name = nameTextBox.Text,
                Credits = Convert.ToInt32(creditsTextBox.Text)
            };
            collegeEntities.Courses.Add(newCourse);
            try
            {
                collegeEntities.SaveChanges();
            }
            catch (DbUpdateException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            UpdateCourseList();
        }

        private void courseNumberFilterTextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateCourseList(courseNumberFilterTextBox.Text);
        }

        private void facultyListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Instructor selectedInstructor = facultyListBox.SelectedItem as Instructor;
            selectedFacultyLabel.Text = $"{selectedInstructor.Name} {selectedInstructor.Phone}";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FacultyForm facultyForm = new FacultyForm();
            facultyForm.Show();
        }

        private void Form1_Enter(object sender, EventArgs e)
        {
            BindFacultyList();
        }
    }
}
