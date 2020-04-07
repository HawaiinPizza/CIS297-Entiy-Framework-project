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
            // TODO: This line of code loads data into the 'collegeSet.Enrollment' table. You can move, or remove it, as needed.
            this.enrollmentTableAdapter.Fill(this.collegeSet.Enrollment);
            // TODO: This line of code loads data into the 'collegeSet.Major' table. You can move, or remove it, as needed.
            this.majorTableAdapter.Fill(this.collegeSet.Major);
            // TODO: This line of code loads data into the 'collegeSet.Student' table. You can move, or remove it, as needed.
            this.studentTableAdapter.Fill(this.collegeSet.Student);
            // TODO: This line of code loads data into the 'collegeSet.Course' table. You can move, or remove it, as needed.
            this.courseTableAdapter.Fill(this.collegeSet.Course);
            // TODO: This line of code loads data into the 'collegeSet.Section' table. You can move, or remove it, as needed.
            this.sectionTableAdapter1.Fill(this.collegeSet.Section);
            // TODO: This line of code loads data into the 'collegeSet.Instructor' table. You can move, or remove it, as needed.
            this.instructorTableAdapter2.Fill(this.collegeSet.Instructor);
            // TODO: This line of code loads data into the 'collegeDataSetSection.Instructor' table. You can move, or remove it, as needed.
            this.instructorTableAdapter1.Fill(this.collegeDataSetSection.Instructor);
            // TODO: This line of code loads data into the 'collegeDataSetInstructor.Instructor' table. You can move, or remove it, as needed.
            this.instructorTableAdapter.Fill(this.collegeDataSetInstructor.Instructor);

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
                    collegeEntities.Student.Add(newInstructor);
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

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.instructorTableAdapter.FillBy(this.collegeDataSetInstructor.Instructor);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show("Incredible point");
            string Change=dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
            int ID = Int32.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            var query = collegeEntities.Students.Where(s => s.UniqueID == ID);


            switch (e.ColumnIndex)
            {
                case 1:
                    query.FirstOrDefault().Major = Int32.Parse(Change);
                    break;
                case 2:
                    query.FirstOrDefault().Name = Change;
                    break;
            }
            collegeEntities.SaveChanges();

        }

        private void addInstructorButton_Click(object sender, EventArgs e)
        {

            if (
                InstructorLabel.TextLength == 0 ||
                StudentLabel.TextLength == 0 ||
               SectionID.TextLength == 0 ||
               GradeLabel.Text.Length == 0 
                )
            {
                MessageBox.Show("One of the data fields is eMPTY");

            }
            else
            {

                float Grade = Int32.Parse(GradeLabel.Text);
                if (Grade > 100 || Grade < 0)
                    throw new Exception("Grade is not percentage");
                //This is a try and catch block, in case a user puts in incorrect Course and Section ID
                try {
                    Enrollment temp = new Enrollment()
                    {
                        InstructorID = Int32.Parse(InstructorLabel.Text),
                        StudentID = Int32.Parse(StudentLabel.Text),
                        SectionID = Int32.Parse(SectionID.Text),
                        Grade = float.Parse(GradeLabel.Text),
                    };
                    collegeEntities.Enrollments.Add(temp);
                    collegeEntities.SaveChanges();
                    dataGridView1.DataSource = collegeEntities.Enrollments.ToList();
                    dataGridView1.Refresh();
                    }
                catch (Exception j)
                {
                    MessageBox.Show("Grade is not percentage, or instructor/section/student is null");
                }
            }
        }

        private void fillByToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.sectionTableAdapter.FillBy(this.collegeDataSetSection.Section);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {


        }

        private void dataGridView1_UserDeletingRow_1(object sender, DataGridViewRowCancelEventArgs e)
        {
            MessageBox.Show(e.Row.Cells[0].ToString() + '\t' + e.Row.Cells[2].Value);
            int DeleteID = Int32.Parse(e.Row.Cells[0].Value.ToString());
            var query=collegeEntities.Students.Where(s => s.UniqueID == DeleteID);
            collegeEntities.Students.Remove(query.FirstOrDefault());
            collegeEntities.SaveChanges();

        }
    }
}
