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
    public partial class Form3 : Form
    {
        private CollegeEntities collegeEntities;
        public Form3()
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

        private void Form3_Enter(object sender, EventArgs e)
        {
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'collegeSet.Section' table. You can move, or remove it, as needed.
            this.sectionTableAdapter.Fill(this.collegeSet.Section);
            // TODO: This line of code loads data into the 'collegeSet.Course' table. You can move, or remove it, as needed.
            this.courseTableAdapter.Fill(this.collegeSet.Course);
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


        private void dataGridView1_CurrentCellChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
        }

        private void dataGridView1_NewRowNeeded(object sender, DataGridViewRowEventArgs e)
        {
        }

        private void dataGridView1_CellValuePushed(object sender, DataGridViewCellValueEventArgs e)
        {
        }

        private void dataGridView1_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
        }

        private void dataGridView1_CellValueNeeded(object sender, DataGridViewCellValueEventArgs e)
        {
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

        // From stuff onward is reproduacable code.
        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            string Change=dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
            int ID = Int32.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            var query = collegeEntities.Courses.Where(s => s.Id == ID);
            switch (e.ColumnIndex)
            {
                case 2:
                    query.FirstOrDefault().Department = Change;
                    break;
                case 1:
                    query.FirstOrDefault().Name = Change;
                    break;
                case 3:
                    query.FirstOrDefault().Credits = Int32.Parse(Change);
                    break;
                case 4:
                    query.FirstOrDefault().Number = Change;
                    break;
            }


            query.FirstOrDefault().Name = Change;
            collegeEntities.SaveChanges();

        }

        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            try
            {
                int DeleteID = Int32.Parse(e.Row.Cells[0].Value.ToString());
                var query = collegeEntities.Courses.Where(s => s.Id == DeleteID);
                collegeEntities.Courses.Remove(query.FirstOrDefault());
                collegeEntities.SaveChanges();
            }
            catch (Exception j)
            {
                MessageBox.Show("Course is dependant on a enrollment");
            }
            //MessageBox.Show(query.FirstOrDefault().Id.ToString());
        }

        private void addInstructorButton_Click(object sender, EventArgs e)
        {
            if (
                NameLabel.Text.Length == 0
                )
            {
                MessageBox.Show("One of the data fields is eMPTY");

            }
            else
            {
                try {
                    Course temp = new Course()
                    {
                        Name = NameLabel.Text,
                        Department = DepartmentLabel.Text,
                        Credits = Int32.Parse(textBox2.Text),
                        Number = textBox1.Text,
                    };
                    collegeEntities.Courses.Add(temp);
                    collegeEntities.SaveChanges();
                    dataGridView1.DataSource = collegeEntities.Courses.ToList();
                    dataGridView1.Refresh();
                }
                catch (Exception j)
                {
                    MessageBox.Show("You have credits as a string, not an interger");
                }
            }
        }

        private void goSection_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 temp = new Form2();
            temp.Show();


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
