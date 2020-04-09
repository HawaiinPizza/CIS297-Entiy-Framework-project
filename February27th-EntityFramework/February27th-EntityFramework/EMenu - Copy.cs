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
    public partial class Form6 : Form
    {
        private CollegeEntities collegeEntities;
        public Form6()
        {
            InitializeComponent();
            collegeEntities = new CollegeEntities();
        }



        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void courseNumberFilterTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void facultyListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FacultyForm facultyForm = new FacultyForm();
            facultyForm.Show();
        }

        private void Form6_Enter(object sender, EventArgs e)
        {
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'collegeSet.Section' table. You can move, or remove it, as needed.
            this.sectionTableAdapter.Fill(this.collegeSet.Section);
            // TODO: This line of code loads data into the 'collegeSet.Enrollment' table. You can move, or remove it, as needed.
            this.enrollmentTableAdapter.Fill(this.collegeSet.Enrollment);
            // TODO: This line of code loads data into the 'collegeSet.Section' table. You can move, or remove it, as needed.
            this.sectionTableAdapter.Fill(this.collegeSet.Section);
            // TODO: This line of code loads data into the 'collegeSet.Student' table. You can move, or remove it, as needed.
            this.studentTableAdapter.Fill(this.collegeSet.Student);
            // TODO: This line of code loads data into the 'collegeSet.Instructor' table. You can move, or remove it, as needed.
            this.instructorTableAdapter.Fill(this.collegeSet.Instructor);
            // TODO: This line of code loads data into the 'collegeSet.Enrollment' table. You can move, or remove it, as needed.

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_ColumnRemoved(object sender, DataGridViewColumnEventArgs e)
        {
            MessageBox.Show(e.ToString());

        }

        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {

        }


        private void dataGridView1_CurrentCellChanged(object sender, EventArgs e)
        {
            MessageBox.Show(e.ToString());

        }

        private void dataGridView1_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            MessageBox.Show("WOW");
        }

        private void dataGridView1_NewRowNeeded(object sender, DataGridViewRowEventArgs e)
        {
            /*
                    Instructor newInstructor = new Instructor()
                    {
                        Id = Int32.Parse(e.Row.Cells[0].Value.ToString()),
                        Name = e.Row.Cells[1].Value.ToString(),
                        Phone = e.Row.Cells[2].Value.ToString(),
                        Office = e.Row.Cells[3].Value.ToString(),
                    }
                    ;
                    collegeEntities.Instructors.Add(newInstructor);
            collegeEntities.SaveChanges();
            */

        }

        private void dataGridView1_CellValuePushed(object sender, DataGridViewCellValueEventArgs e)
        {
        }

        private void dataGridView1_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            //MessageBox.Show("Complete");
        }

        private void dataGridView1_CellValueNeeded(object sender, DataGridViewCellValueEventArgs e)
        {
            //MessageBox.Show("CellNeeded");
        }


        private void dataGridView1_CellEndEdit_1(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void addInstructorButton_Click(object sender, EventArgs e)
        {
            if (
                SectionLabel.Text.Length == 0 ||
                StudentLabel.Text.Length == 0 ||
                GradeLabel.Text.Length == 0
                )
            {
                MessageBox.Show("One of the data fields is eMPTY");

            }
            else
            {

                //This is a try and catch block, in case a user puts in incorrect Course and Section ID
                try {
                    MessageBox.Show(SectionLabel.Text + '\t' + StudentLabel.Text);
                    Enrollment temp = new Enrollment()
                    {
                        SectionID = Int32.Parse(SectionLabel.Text),
                        StudentID = Int32.Parse(StudentLabel.Text),
                        Grade = float.Parse(GradeLabel.Text),

                    };

                    collegeEntities.Enrollments.Add(temp);
                    collegeEntities.SaveChanges();
                    dataGridView4.DataSource = collegeEntities.Enrollments.ToList();
                    dataGridView4.Refresh();
                    }
                catch (Exception j)
                {
                    MessageBox.Show("Either section/student id is not valid, or grade is not a number" );
                }
            }
        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView4_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show("Incredible point");
            string Change=dataGridView4.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
            int ID = Int32.Parse(dataGridView4.Rows[e.RowIndex].Cells[0].Value.ToString());
            var query = collegeEntities.Enrollments.Where(s => s.Id == ID);


            try
            {
                MessageBox.Show(e.ColumnIndex.ToString());
                switch (e.ColumnIndex)
                {
                    case 1:
                        query.FirstOrDefault().SectionID = Int32.Parse(Change);
                        break;
                    case 2:
                        query.FirstOrDefault().StudentID = Int32.Parse(Change);
                        break;
                    case 3:
                        query.FirstOrDefault().Grade = float.Parse(Change);
                        break;
                }
            }
            catch(Exception j)
            {
                MessageBox.Show("You enter invalid id, or not a number for grade");
            }
            collegeEntities.SaveChanges();


        }

        private void dataGridView4_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            int DeleteID = Int32.Parse(e.Row.Cells[0].Value.ToString());
            var query=collegeEntities.Enrollments.Where(s => s.Id == DeleteID);
            collegeEntities.Enrollments.Remove(query.FirstOrDefault());
            collegeEntities.SaveChanges();
            //MessageBox.Show(query.FirstOrDefault().Id.ToString());

        }

        private void filterButton_Click(object sender, EventArgs e)
        {

            var searchString = filterTextBox1.Text;
            var Enrollment = from s in collegeEntities.Enrollments
                           select s;
            Enrollment = Enrollment.Where(s => s.Student.Name.Contains(searchString));
            if (Enrollment.Count() == 0)
            {
                dataGridView4.DataSource = collegeEntities.Enrollments.ToList();
            }
            else
            {
                dataGridView4.DataSource = Enrollment.ToList();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var searchString = filterTextBox2.Text;
            var Enrollment = from s in collegeEntities.Enrollments
                           select s;
            Enrollment = Enrollment.Where(s => s.Section.Semester.Contains(searchString));
            if (Enrollment.Count() == 0)
            {
                dataGridView4.DataSource = collegeEntities.Enrollments.ToList();
                MessageBox.Show("Sucess");
            }
            else
            {
                dataGridView4.DataSource = Enrollment.ToList();
                MessageBox.Show("Failure");
            }

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void displayGradesButton_Click(object sender, EventArgs e)
        {
            var searchString = Int32.Parse(gradeTextBox.Text);
            var Enrollment = from s in collegeEntities.Enrollments
                             select s;
            Enrollment = Enrollment.Where(s => s.SectionID == searchString);

            int F = 0;
            int D = 0;
            int C = 0;
            int B = 0;
            int A = 0;

            foreach (var i in Enrollment.ToList())
            {
                if (i.Grade < 60)
                {
                    F++;
                } 
                else if (i.Grade >= 60 && i.Grade < 70)
                {
                    D++;
                }
                else if (i.Grade >= 70 && i.Grade < 80)
                {
                    C++;
                }
                else if (i.Grade >= 80 && i.Grade < 90)
                {
                    B++;
                }
                else if (i.Grade > 90)
                {
                    A++;
                }
            }

            double fPercent = (double)F / Enrollment.ToList().Count;
            double dPercent = (double)D / Enrollment.ToList().Count;
            double cPercent = (double)C / Enrollment.ToList().Count;
            double bPercent = (double)B / Enrollment.ToList().Count;
            double aPercent = (double)A / Enrollment.ToList().Count;

            string restultString = "A: " + aPercent + ", B: " + bPercent + ", C: " + cPercent + ", D: " + dPercent + ", F: " + fPercent;

            MessageBox.Show(restultString);
        }
    }
}
