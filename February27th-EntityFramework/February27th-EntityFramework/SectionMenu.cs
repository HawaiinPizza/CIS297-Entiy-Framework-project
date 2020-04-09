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
    public partial class Form2 : Form
    {
        private CollegeEntities collegeEntities;
        public Form2()
        {
            InitializeComponent();
            collegeEntities = new CollegeEntities();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            var College = new CollegeEntities();
            for(int i=0; i < dataGridView1.Rows.Count-1; i++)
            {
                if (0 > Int32.Parse(dataGridView1.Rows[i].Cells[0].Value.ToString()))
                {
                }
                else
                    MessageBox.Show("I can't even beat my dick");
            }
            College.SaveChanges();

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

        private void Form2_Enter(object sender, EventArgs e)
        {
        }

        private void Form2_Load(object sender, EventArgs e)
        {
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
            //MessageBox.Show(query.FirstOrDefault().Id.ToString());

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

        private void dataGridView1_CellEndEdit_1(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show("Incredible point");
            string Change=dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
            int ID = Int32.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            var query = collegeEntities.Sections.Where(s => s.Id == ID);


            switch (e.ColumnIndex)
            {
                case 1:
                    query.FirstOrDefault().Course_Id = Int32.Parse(Change);
                    break;
                case 4:
                    query.FirstOrDefault().Instructor_ID = Int32.Parse(Change);
                                            break;
                case 3:
                    query.FirstOrDefault().Days = Change;
                    break;
                case 2:
                    query.FirstOrDefault().Time = Change;
                    break;
            }
            collegeEntities.SaveChanges();

        }

        private void addInstructorButton_Click(object sender, EventArgs e)
        {
            if (
                DaysLabel.Text.Length == 0 ||
                TimeLabel.Text.Length == 0 ||
                InstructorLabel.Text.Length == 0 ||
                CourseLabel.Text.Length == 0
                )
            {
                MessageBox.Show("One of the data fields is eMPTY");

            }
            else
            {

                //This is a try and catch block, in case a user puts in incorrect Course and Section ID
                try {
                    Section temp = new Section()
                    {
                        Course_Id=Int32.Parse(CourseLabel.Text),
                        Instructor_ID=Int32.Parse(InstructorLabel.Text),
                        Days=DaysLabel.Text,
                        Time=TimeLabel.Text
                    };
                    collegeEntities.Sections.Add(temp);
                    collegeEntities.SaveChanges();
                    dataGridView1.DataSource = collegeEntities.Sections.ToList();
                    dataGridView1.Refresh();
                    }
                catch (Exception j)
                {
                    MessageBox.Show("For Course or Insturcotr ID, they are incorrect values bro");
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

        private void dataGridView1_UserDeletingRow_1(object sender, DataGridViewRowCancelEventArgs e)
        {
            int DeleteID = Int32.Parse(e.Row.Cells[0].Value.ToString());
            var query=collegeEntities.Sections.Where(s => s.Id == DeleteID);
            collegeEntities.Sections.Remove(query.FirstOrDefault());
            collegeEntities.SaveChanges();

        }
    }
}
