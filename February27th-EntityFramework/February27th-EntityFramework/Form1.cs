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
                    label1.Text += $"\t{section.Instructor.Name} {section.Days} {section.Time}{Environment.NewLine}";
                }
               
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var College = new CollegeEntities();
            College.SaveChanges();
            MessageBox.Show("How?");
        }

        private void courseNumberFilterTextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateCourseList(courseNumberFilterTextBox.Text);

        }

        private void facultyListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FacultyForm facultyForm = new FacultyForm();
            facultyForm.Show();
        }

        private void Form1_Enter(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'collegeDataSetInstructor.Instructor' table. You can move, or remove it, as needed.
            this.instructorTableAdapter.Fill(this.collegeDataSetInstructor.Instructor);

        }
    }
}
